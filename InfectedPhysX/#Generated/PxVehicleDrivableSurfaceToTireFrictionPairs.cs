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
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct PxVehicleDrivableSurfaceToTireFrictionPairs
    {
        public const int eMAX_NB_SURFACE_TYPES = 256;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?allocate@PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@SAPEAV12@II@Z", ExactSpelling = true)]
        public static extern PxVehicleDrivableSurfaceToTireFrictionPairs* allocate(uint maxNbTireTypes, uint maxNbSurfaceTypes);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setup@PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@QEAAXIIPEAPEBVPxMaterial@2@PEBUPxVehicleDrivableSurfaceType@2@@Z", ExactSpelling = true)]
        private static extern void setup_PInvoke(PxVehicleDrivableSurfaceToTireFrictionPairs* @this, uint nbTireTypes, uint nbSurfaceTypes, PxMaterial** drivableSurfaceMaterials, PxVehicleDrivableSurfaceType* drivableSurfaceTypes);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setup(uint nbTireTypes, uint nbSurfaceTypes, PxMaterial** drivableSurfaceMaterials, PxVehicleDrivableSurfaceType* drivableSurfaceTypes)
        {
            fixed (PxVehicleDrivableSurfaceToTireFrictionPairs* @this = &this)
            { setup_PInvoke(@this, nbTireTypes, nbSurfaceTypes, drivableSurfaceMaterials, drivableSurfaceTypes); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?release@PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@QEAAXXZ", ExactSpelling = true)]
        private static extern void release_PInvoke(PxVehicleDrivableSurfaceToTireFrictionPairs* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void release()
        {
            fixed (PxVehicleDrivableSurfaceToTireFrictionPairs* @this = &this)
            { release_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setTypePairFriction@PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@QEAAXIIM@Z", ExactSpelling = true)]
        private static extern void setTypePairFriction_PInvoke(PxVehicleDrivableSurfaceToTireFrictionPairs* @this, uint surfaceType, uint tireType, float value);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setTypePairFriction(uint surfaceType, uint tireType, float value)
        {
            fixed (PxVehicleDrivableSurfaceToTireFrictionPairs* @this = &this)
            { setTypePairFriction_PInvoke(@this, surfaceType, tireType, value); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getTypePairFriction@PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@QEBAMII@Z", ExactSpelling = true)]
        private static extern float getTypePairFriction_PInvoke(PxVehicleDrivableSurfaceToTireFrictionPairs* @this, uint surfaceType, uint tireType);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getTypePairFriction(uint surfaceType, uint tireType)
        {
            fixed (PxVehicleDrivableSurfaceToTireFrictionPairs* @this = &this)
            { return getTypePairFriction_PInvoke(@this, surfaceType, tireType); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getMaxNbSurfaceTypes@PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getMaxNbSurfaceTypes_PInvoke(PxVehicleDrivableSurfaceToTireFrictionPairs* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getMaxNbSurfaceTypes()
        {
            fixed (PxVehicleDrivableSurfaceToTireFrictionPairs* @this = &this)
            { return getMaxNbSurfaceTypes_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getMaxNbTireTypes@PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getMaxNbTireTypes_PInvoke(PxVehicleDrivableSurfaceToTireFrictionPairs* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getMaxNbTireTypes()
        {
            fixed (PxVehicleDrivableSurfaceToTireFrictionPairs* @this = &this)
            { return getMaxNbTireTypes_PInvoke(@this); }
        }

        [FieldOffset(0)] public float* mPairs;

        [FieldOffset(8)] public PxMaterial** mDrivableSurfaceMaterials;

        [FieldOffset(16)] public PxVehicleDrivableSurfaceType* mDrivableSurfaceTypes;

        [FieldOffset(24)] public uint mNbSurfaceTypes;

        [FieldOffset(28)] public uint mMaxNbSurfaceTypes;

        [FieldOffset(32)] public uint mNbTireTypes;

        [FieldOffset(36)] public uint mMaxNbTireTypes;

        [FieldOffset(40)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32_2 mPad;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@AEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDrivableSurfaceToTireFrictionPairs* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxVehicleDrivableSurfaceToTireFrictionPairs* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??1PxVehicleDrivableSurfaceToTireFrictionPairs@physx@@AEAA@XZ", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(PxVehicleDrivableSurfaceToTireFrictionPairs* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxVehicleDrivableSurfaceToTireFrictionPairs* @this = &this)
            { Destructor_PInvoke(@this); }
        }
    }
}
