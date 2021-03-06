﻿// This is a quick and dirty proof-of-concept port of the PhysX Hello World snippet to InfectedPhysX
// https://github.com/InfectedLibraries/PhysX/blob/909a7c4fe940154be8c1aca19d655137435dd2f5/physx/snippets/snippethelloworld/SnippetHelloWorld.cpp
// Some quirks due to unimplemented features or bugs in Biohazrd are marked with "BIOQUIRK" comments.
// This sample does not necessarily represent the final shape of how Biohazrd will expose C++ classes to C#.
using PhysX;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
// Switch between these to change the allocator implementation:
using Allocator = InfectedPhysX.Sample.BasicAllocator;
//using Allocator = InfectedPhysX.Sample.LoggingAllocator;
using static PhysX.Globals;

namespace InfectedPhysX.Sample
{
    public static unsafe class Program
    {
        public static void Main(string[] args)
        {
            NativeLibrary.SetDllImportResolver(typeof(PxDefaultErrorCallback).Assembly, NativeLibraryResolver);

            //---------------------------------------------------------------------------------------------------------------------------------------
            //BIOQUIRK: Can't use PxDefaultErrorCallback because it's in a static library.
            Console.WriteLine("Initializing error callback");
            PxErrorCallback errorCallback = ErrorCallback.Create();

            //---------------------------------------------------------------------------------------------------------------------------------------
            //BIOQUIRK: It'd be nice to use the default C++ allocator here to see if there's a performance difference, but we need to be able to initialize a PxDefaultAllocator
            // We can't because it needs the vTable initialized but it has no constructor. - https://github.com/InfectedLibraries/Biohazrd/issues/31
            // On the bright side, this is a nice demonstration of manually extending a C++ type in C#.
            Console.WriteLine("Initializing allocator callback");
            PxAllocatorCallback allocator = Allocator.Create();

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Initializing foundation");
            const uint PX_PHYSICS_VERSION = (4 << 24) + (1 << 16) + (1 << 8);
            PxFoundation* foundation = PxCreateFoundation(PX_PHYSICS_VERSION, &allocator, &errorCallback);

            if (foundation == null)
            {
                Console.Error.WriteLine("Failed to create foundation.");
                return;
            }

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Initializing Pvd...");
            PxPvd* pvd = PxCreatePvd(foundation);

            PxPvdTransport* transport;
            byte[] host = Encoding.ASCII.GetBytes("127.0.0.1");
            fixed (byte* hostP = host)
            { transport = PxDefaultPvdSocketTransportCreate(hostP, 5425, 10); }

            Console.WriteLine("Connecting to Pvd...");
            pvd->connect(transport, PxPvdInstrumentationFlags.eALL);

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Initializing physics");
            PxTolerancesScale scale = default;
            scale.Constructor();
            PxPhysics* physics = PxCreatePhysics(PX_PHYSICS_VERSION, foundation, &scale, trackOutstandingAllocations: true, pvd);

            if (physics == null)
            {
                Console.Error.WriteLine("Failed to create physics.");
                return;
            }

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Creating dispatcher");
            PxDefaultCpuDispatcher* dispatcher = PxDefaultCpuDispatcherCreate(2, null);

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Creating scene");
            PxSceneDesc sceneDescription = default;
            sceneDescription.Constructor(physics->getTolerancesScale());
            sceneDescription.gravity = new PxVec3() { x = 0f, y = -9.81f, z = 0f };
            sceneDescription.cpuDispatcher = (PxCpuDispatcher*)dispatcher;
            sceneDescription.filterShader =
                (delegate* unmanaged[Cdecl]<uint, PxFilterData, uint, PxFilterData, PxPairFlags*, void*, uint, PxFilterFlags>)
                //BIOQUIRK: We're basically trying to get a pointer to this function in PhysX.
                // We can't actually use a function pointer here because C# considers this a managed function (since it could be a managed stub.)
                //&PxDefaultSimulationFilterShader.PxDefaultSimulationFilterShader__
                // As such, we manually use NativeLibrary.GetExport here.
                // This code should be improved by https://github.com/InfectedLibraries/Biohazrd/issues/80
                NativeLibrary.GetExport(PhysXDllHandle, "?PxDefaultSimulationFilterShader@physx@@YA?AV?$PxFlags@W4Enum@PxFilterFlag@physx@@G@1@IUPxFilterData@1@I0AEAV?$PxFlags@W4Enum@PxPairFlag@physx@@G@1@PEBXI@Z")
            ;
            PxScene* scene = physics->createScene(&sceneDescription);

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Configuring scene Pvd client");
            PxPvdSceneClient* pvdClient = scene->getScenePvdClient();
            if (pvdClient != null)
            {
                pvdClient->setScenePvdFlag(PxPvdSceneFlags.eTRANSMIT_CONSTRAINTS, true);
                pvdClient->setScenePvdFlag(PxPvdSceneFlags.eTRANSMIT_CONTACTS, true);
                pvdClient->setScenePvdFlag(PxPvdSceneFlags.eTRANSMIT_SCENEQUERIES, true);
            }

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Creating a basic material");
            PxMaterial* material = physics->createMaterial(0.5f, 0.5f, 0.6f);

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Adding a ground plane");
            PxPlane planeDescription = new PxPlane()
            {
                n = new PxVec3()
                {
                    x = 0f,
                    y = 1f,
                    z = 0f
                },
                d = 0f
            };
            PxRigidStatic* groundPlane = PxCreatePlane(physics, &planeDescription, material);
            scene->addActor((PxActor*)groundPlane, null);

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Adding stacks");
            {
                PxBoxGeometry stackBoxGeometry = new PxBoxGeometry();
                const float halfExtent = 2f;
                stackBoxGeometry.Constructor(halfExtent, halfExtent, halfExtent);
                PxShape* shape = physics->createShape((PxGeometry*)&stackBoxGeometry, material, isExclusive: false, PxShapeFlags.eVISUALIZATION | PxShapeFlags.eSCENE_QUERY_SHAPE | PxShapeFlags.eSIMULATION_SHAPE);
                float stackZ = 10f;
                for (int stackNum = 0; stackNum < 5; stackNum++)
                {
                    const int size = 10;

                    PxVec3 transformPosition = new PxVec3()
                    {
                        x = 0f,
                        y = 0f,
                        z = stackZ -= 10f
                    };
                    PxTransform transform = default;
                    transform.Constructor(&transformPosition);

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size - i; j++)
                        {
                            PxVec3 position = new PxVec3()
                            {
                                x = ((float)(j * 2) - (float)(size - i)) * halfExtent,
                                y = ((float)(i * 2 + 1)) * halfExtent,
                                z = 0f
                            };
                            PxTransform localTransform = default;
                            localTransform.Constructor(&position);

                            PxTransform bodyTransform = transform.transform(&localTransform);
                            PxRigidDynamic* body = physics->createRigidDynamic(&bodyTransform);
                            body->Base.Base.attachShape(shape);
                            PxRigidBodyExt.updateMassAndInertia((PxRigidBody*)body, 10f);
                            scene->addActor((PxActor*)body);
                        }
                    }
                }
                shape->release();
            }

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Throwing a ball at the stacks");
            {
                PxVec3 position = new PxVec3()
                {
                    x = 0f,
                    y = 40f,
                    z = 100f,
                };
                PxTransform transform = default;
                transform.Constructor(&position);

                PxSphereGeometry geometry = default;
                geometry.Constructor(10f);

                PxVec3 velocity = new PxVec3()
                {
                    x = 0f,
                    y = -50f,
                    z = -100f
                };

                PxTransform identity = default;
                identity.Constructor(default(PxIDENTITY));
                PxRigidDynamic* dynamic = PxCreateDynamic(physics, &transform, (PxGeometry*)&geometry, material, 10f, &identity);
                dynamic->Base.setAngularDamping(0.5f);
                dynamic->Base.setLinearVelocity(&velocity);
                scene->addActor((PxActor*)dynamic);
            }

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Simulating the world... (Press escape to stop.)");
            Stopwatch sw = new Stopwatch();
            int frameNum = 0;

            const uint scratchMemoryBlockSize = 16 * 1024;
            const uint scratchMemoryBlockCount = 4;
            uint scratchMemorySize = scratchMemoryBlockSize * scratchMemoryBlockCount;
            void* scratchMemory = allocator.allocate(scratchMemorySize, null, null, 0);

            while (true)
            {
                double msSinceLastTick = sw.Elapsed.TotalMilliseconds;
                Console.Title = $"Simulating frame {frameNum} -- {msSinceLastTick:0.00} ms -- {1.0 / (msSinceLastTick / 1000.0):00.0} FPS -- {Allocator.AllocationCount} allocations";
                Allocator.AllocationCount = 0;
                frameNum++;

                sw.Restart();

                scene->simulate(1f / 60f, scratchMemBlock: scratchMemory, scratchMemBlockSize: scratchMemorySize);

                uint errors;
                scene->fetchResults(true, &errors);
                if (errors != 0)
                { Console.WriteLine($"fetchResults error: {errors}"); }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                { break; }
            }

            //---------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Shutting down");
            allocator.deallocate(scratchMemory);
            physics->release();
            foundation->release();
        }

        private static IntPtr PhysXDllHandle;
        private static IntPtr NativeLibraryResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (libraryName == "TODO.dll")
            { return PhysXDllHandle = NativeLibrary.Load(@"InfectedPhysX.Native_64.dll"); }

            return IntPtr.Zero;
        }
    }
}
