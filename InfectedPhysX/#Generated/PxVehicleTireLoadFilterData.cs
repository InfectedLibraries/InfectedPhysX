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
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct PxVehicleTireLoadFilterData
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleTireLoadFilterData@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleTireLoadFilterData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxVehicleTireLoadFilterData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [FieldOffset(0)] public float mMinNormalisedLoad;

        [FieldOffset(4)] public float mMinFilteredNormalisedLoad;

        [FieldOffset(8)] public float mMaxNormalisedLoad;

        [FieldOffset(12)] public float mMaxFilteredNormalisedLoad;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getDenominator@PxVehicleTireLoadFilterData@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float getDenominator_PInvoke(PxVehicleTireLoadFilterData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getDenominator()
        {
            fixed (PxVehicleTireLoadFilterData* @this = &this)
            { return getDenominator_PInvoke(@this); }
        }

        [FieldOffset(16)] public float mDenominator;

        [FieldOffset(20)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32_3 mPad;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleTireLoadFilterData@physx@@AEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxVehicleTireLoadFilterData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxVehicleTireLoadFilterData* @this = &this)
            { return isValid_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleTireLoadFilterData@physx@@QEAA@W4PxEMPTY@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleTireLoadFilterData* @this, PxEMPTY arg0);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxEMPTY arg0)
        {
            fixed (PxVehicleTireLoadFilterData* @this = &this)
            { Constructor_PInvoke(@this, arg0); }
        }
    }
}
