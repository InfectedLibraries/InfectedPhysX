// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using PhysX.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxCooking
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void release()
        {
            fixed (PxCooking* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setParams(PxCookingParams* @params)
        {
            fixed (PxCooking* @this = &this)
            { VirtualMethodTablePointer->setParams(@this, @params); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxCookingParams* getParams()
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->getParams(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool platformMismatch()
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->platformMismatch(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool cookTriangleMesh(PxTriangleMeshDesc* desc, PxOutputStream* stream, PxTriangleMeshCookingResult* condition = null)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->cookTriangleMesh(@this, desc, stream, condition); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxTriangleMesh* createTriangleMesh(PxTriangleMeshDesc* desc, PxPhysicsInsertionCallback* insertionCallback, PxTriangleMeshCookingResult* condition = null)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->createTriangleMesh(@this, desc, insertionCallback, condition); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool validateTriangleMesh(PxTriangleMeshDesc* desc)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->validateTriangleMesh(@this, desc); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool cookConvexMesh(PxConvexMeshDesc* desc, PxOutputStream* stream, PxConvexMeshCookingResult* condition = null)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->cookConvexMesh(@this, desc, stream, condition); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxConvexMesh* createConvexMesh(PxConvexMeshDesc* desc, PxPhysicsInsertionCallback* insertionCallback, PxConvexMeshCookingResult* condition = null)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->createConvexMesh(@this, desc, insertionCallback, condition); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool validateConvexMesh(PxConvexMeshDesc* desc)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->validateConvexMesh(@this, desc); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool computeHullPolygons(PxSimpleTriangleMesh* mesh, PxAllocatorCallback* inCallback, uint* nbVerts, PxVec3** vertices, uint* nbIndices, uint** indices, uint* nbPolygons, PxHullPolygon** hullPolygons)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->computeHullPolygons(@this, mesh, inCallback, nbVerts, vertices, nbIndices, indices, nbPolygons, hullPolygons); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool cookHeightField(PxHeightFieldDesc* desc, PxOutputStream* stream)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->cookHeightField(@this, desc, stream); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxHeightField* createHeightField(PxHeightFieldDesc* desc, PxPhysicsInsertionCallback* insertionCallback)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->createHeightField(@this, desc, insertionCallback); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool cookBVHStructure(PxBVHStructureDesc* desc, PxOutputStream* stream)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->cookBVHStructure(@this, desc, stream); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxBVHStructure* createBVHStructure(PxBVHStructureDesc* desc, PxPhysicsInsertionCallback* insertionCallback)
        {
            fixed (PxCooking* @this = &this)
            { return VirtualMethodTablePointer->createBVHStructure(@this, desc, insertionCallback); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxCooking* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, void> release;
            /// <summary>Virtual method pointer for `setParams`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxCookingParams*, void> setParams;
            /// <summary>Virtual method pointer for `getParams`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxCookingParams*> getParams;
            /// <summary>Virtual method pointer for `platformMismatch`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, NativeBoolean> platformMismatch;
            /// <summary>Virtual method pointer for `cookTriangleMesh`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxTriangleMeshDesc*, PxOutputStream*, PxTriangleMeshCookingResult*, NativeBoolean> cookTriangleMesh;
            /// <summary>Virtual method pointer for `createTriangleMesh`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxTriangleMeshDesc*, PxPhysicsInsertionCallback*, PxTriangleMeshCookingResult*, PxTriangleMesh*> createTriangleMesh;
            /// <summary>Virtual method pointer for `validateTriangleMesh`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxTriangleMeshDesc*, NativeBoolean> validateTriangleMesh;
            /// <summary>Virtual method pointer for `cookConvexMesh`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxConvexMeshDesc*, PxOutputStream*, PxConvexMeshCookingResult*, NativeBoolean> cookConvexMesh;
            /// <summary>Virtual method pointer for `createConvexMesh`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxConvexMeshDesc*, PxPhysicsInsertionCallback*, PxConvexMeshCookingResult*, PxConvexMesh*> createConvexMesh;
            /// <summary>Virtual method pointer for `validateConvexMesh`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxConvexMeshDesc*, NativeBoolean> validateConvexMesh;
            /// <summary>Virtual method pointer for `computeHullPolygons`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxSimpleTriangleMesh*, PxAllocatorCallback*, uint*, PxVec3**, uint*, uint**, uint*, PxHullPolygon**, NativeBoolean> computeHullPolygons;
            /// <summary>Virtual method pointer for `cookHeightField`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxHeightFieldDesc*, PxOutputStream*, NativeBoolean> cookHeightField;
            /// <summary>Virtual method pointer for `createHeightField`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxHeightFieldDesc*, PxPhysicsInsertionCallback*, PxHeightField*> createHeightField;
            /// <summary>Virtual method pointer for `cookBVHStructure`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxBVHStructureDesc*, PxOutputStream*, NativeBoolean> cookBVHStructure;
            /// <summary>Virtual method pointer for `createBVHStructure`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, PxBVHStructureDesc*, PxPhysicsInsertionCallback*, PxBVHStructure*> createBVHStructure;
            /// <summary>Virtual method pointer for `~PxCooking`</summary>
            public delegate* unmanaged[Cdecl]<PxCooking*, void> __DeletingDestructorPointer;
        }
    }
}
