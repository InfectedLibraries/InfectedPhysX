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
    public unsafe partial struct PxVehicleDifferential4WData
    {
        public enum Enum
        {
            eDIFF_TYPE_LS_4WD,
            eDIFF_TYPE_LS_FRONTWD,
            eDIFF_TYPE_LS_REARWD,
            eDIFF_TYPE_OPEN_4WD,
            eDIFF_TYPE_OPEN_FRONTWD,
            eDIFF_TYPE_OPEN_REARWD,
            eMAX_NB_DIFF_TYPES
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDifferential4WData@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDifferential4WData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxVehicleDifferential4WData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [FieldOffset(0)] public float mFrontRearSplit;

        [FieldOffset(4)] public float mFrontLeftRightSplit;

        [FieldOffset(8)] public float mRearLeftRightSplit;

        [FieldOffset(12)] public float mCentreBias;

        [FieldOffset(16)] public float mFrontBias;

        [FieldOffset(20)] public float mRearBias;

        [FieldOffset(24)] public Enum mType;

        [FieldOffset(28)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_1 mPad;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleDifferential4WData@physx@@AEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxVehicleDifferential4WData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxVehicleDifferential4WData* @this = &this)
            { return isValid_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDifferential4WData@physx@@QEAA@W4PxEMPTY@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDifferential4WData* @this, PxEMPTY arg0);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxEMPTY arg0)
        {
            fixed (PxVehicleDifferential4WData* @this = &this)
            { Constructor_PInvoke(@this, arg0); }
        }
    }
}
