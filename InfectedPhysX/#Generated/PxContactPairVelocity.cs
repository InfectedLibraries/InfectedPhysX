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
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public unsafe partial struct PxContactPairVelocity
    {
        [FieldOffset(0)] public PxContactPairExtraDataItem Base;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxContactPairVelocity@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxContactPairVelocity* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxContactPairVelocity* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [FieldOffset(4)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxVec3_2 linearVelocity;

        [FieldOffset(28)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxVec3_2 angularVelocity;
    }
}
