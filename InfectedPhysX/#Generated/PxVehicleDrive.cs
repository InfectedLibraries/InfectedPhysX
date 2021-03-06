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
    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public unsafe partial struct PxVehicleDrive
    {
        [FieldOffset(0)] public PxVehicleWheels Base;

        [FieldOffset(192)] public PxVehicleDriveDynData mDriveDynData;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleDrive@physx@@IEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxVehicleDrive* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxVehicleDrive* @this = &this)
            { return isValid_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToRestState@PxVehicleDrive@physx@@IEAAXXZ", ExactSpelling = true)]
        private static extern void setToRestState_PInvoke(PxVehicleDrive* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setToRestState()
        {
            fixed (PxVehicleDrive* @this = &this)
            { setToRestState_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?computeByteSize@PxVehicleDrive@physx@@KAII@Z", ExactSpelling = true)]
        public static extern uint computeByteSize(uint numWheels);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?patchupPointers@PxVehicleDrive@physx@@KAPEAEIPEAV12@PEAE@Z", ExactSpelling = true)]
        public static extern byte* patchupPointers(uint nbWheels, PxVehicleDrive* vehDrive, byte* ptr);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void init(uint numWheels)
        {
            fixed (PxVehicleDrive* @this = &this)
            { VirtualMethodTablePointer->init(@this, numWheels); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?free@PxVehicleDrive@physx@@IEAAXXZ", ExactSpelling = true)]
        private static extern void free_PInvoke(PxVehicleDrive* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void free()
        {
            fixed (PxVehicleDrive* @this = &this)
            { free_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setup@PxVehicleDrive@physx@@IEAAXPEAVPxPhysics@2@PEAVPxRigidDynamic@2@AEBVPxVehicleWheelsSimData@2@II@Z", ExactSpelling = true)]
        private static extern void setup_PInvoke(PxVehicleDrive* @this, PxPhysics* physics, PxRigidDynamic* vehActor, PxVehicleWheelsSimData* wheelsData, uint nbDrivenWheels, uint nbNonDrivenWheels);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setup(PxPhysics* physics, PxRigidDynamic* vehActor, PxVehicleWheelsSimData* wheelsData, uint nbDrivenWheels, uint nbNonDrivenWheels)
        {
            fixed (PxVehicleDrive* @this = &this)
            { setup_PInvoke(@this, physics, vehActor, wheelsData, nbDrivenWheels, nbNonDrivenWheels); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBinaryMetaData@PxVehicleDrive@physx@@SAXAEAVPxOutputStream@2@@Z", ExactSpelling = true)]
        public static extern void getBinaryMetaData(PxOutputStream* stream);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDrive@physx@@QEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDrive* @this, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxBaseFlags baseFlags)
        {
            fixed (PxVehicleDrive* @this = &this)
            { Constructor_PInvoke(@this, baseFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* getConcreteTypeName()
        {
            fixed (PxVehicleDrive* @this = &this)
            { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDrive@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDrive* @this, ushort concreteType, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
        {
            fixed (PxVehicleDrive* @this = &this)
            { Constructor_PInvoke(@this, concreteType, baseFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxVehicleDrive* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isKindOf(byte* name)
        {
            fixed (PxVehicleDrive* @this = &this)
            { return VirtualMethodTablePointer->isKindOf(@this, name); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleDrive*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxBase*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxVehicleDrive`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleDrive*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleDrive*, byte*, NativeBoolean> isKindOf;
            /// <summary>Virtual method pointer for `init`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleDrive*, uint, void> init;
            /// <summary>Virtual method pointer for `requiresObjects`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, PxProcessPxBaseCallback*, void> requiresObjects;
            /// <summary>Virtual method pointer for `preExportDataReset`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, void> preExportDataReset;
            /// <summary>Virtual method pointer for `exportExtraData`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, PxSerializationContext*, void> exportExtraData;
        }
    }
}
