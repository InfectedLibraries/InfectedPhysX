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
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct PxVehicleAntiRollBarData
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleAntiRollBarData@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleAntiRollBarData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxVehicleAntiRollBarData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [FieldOffset(0)] public uint mWheel0;

        [FieldOffset(4)] public uint mWheel1;

        [FieldOffset(8)] public float mStiffness;

        [FieldOffset(12)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxF32_1 mPad;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleAntiRollBarData@physx@@AEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxVehicleAntiRollBarData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxVehicleAntiRollBarData* @this = &this)
            { return isValid_PInvoke(@this); }
        }
    }
}
