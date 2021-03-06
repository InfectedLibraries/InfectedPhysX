// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public unsafe partial struct PxJointAngularLimitPair
    {
        [FieldOffset(0)] public PxJointLimitParameters Base;

        [FieldOffset(20)] public float upper;

        [FieldOffset(24)] public float lower;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJointAngularLimitPair@physx@@QEAA@MMM@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxJointAngularLimitPair* @this, float lowerLimit, float upperLimit, float contactDist);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(float lowerLimit, float upperLimit, float contactDist = -1f)
        {
            fixed (PxJointAngularLimitPair* @this = &this)
            { Constructor_PInvoke(@this, lowerLimit, upperLimit, contactDist); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJointAngularLimitPair@physx@@QEAA@MMAEBVPxSpring@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxJointAngularLimitPair* @this, float lowerLimit, float upperLimit, PxSpring* spring);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(float lowerLimit, float upperLimit, PxSpring* spring)
        {
            fixed (PxJointAngularLimitPair* @this = &this)
            { Constructor_PInvoke(@this, lowerLimit, upperLimit, spring); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxJointAngularLimitPair@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxJointAngularLimitPair* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxJointAngularLimitPair* @this = &this)
            { return isValid_PInvoke(@this); }
        }
    }
}
