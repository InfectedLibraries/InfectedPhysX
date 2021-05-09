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
    public unsafe partial struct PxJointLimitCone
    {
        [FieldOffset(0)] public PxJointLimitParameters Base;

        [FieldOffset(20)] public float yAngle;

        [FieldOffset(24)] public float zAngle;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJointLimitCone@physx@@QEAA@MMM@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxJointLimitCone* @this, float yLimitAngle, float zLimitAngle, float contactDist);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(float yLimitAngle, float zLimitAngle, float contactDist = -1f)
        {
            fixed (PxJointLimitCone* @this = &this)
            { Constructor_PInvoke(@this, yLimitAngle, zLimitAngle, contactDist); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJointLimitCone@physx@@QEAA@MMAEBVPxSpring@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxJointLimitCone* @this, float yLimitAngle, float zLimitAngle, PxSpring* spring);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(float yLimitAngle, float zLimitAngle, PxSpring* spring)
        {
            fixed (PxJointLimitCone* @this = &this)
            { Constructor_PInvoke(@this, yLimitAngle, zLimitAngle, spring); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxJointLimitCone@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxJointLimitCone* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxJointLimitCone* @this = &this)
            { return isValid_PInvoke(@this); }
        }
    }
}
