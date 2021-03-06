// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct PxJacobianRow
    {
        [FieldOffset(0)] public PxVec3 linear0;

        [FieldOffset(12)] public PxVec3 linear1;

        [FieldOffset(24)] public PxVec3 angular0;

        [FieldOffset(36)] public PxVec3 angular1;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJacobianRow@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxJacobianRow* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxJacobianRow* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJacobianRow@physx@@QEAA@AEBVPxVec3@1@000@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxJacobianRow* @this, PxVec3* lin0, PxVec3* lin1, PxVec3* ang0, PxVec3* ang1);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxVec3* lin0, PxVec3* lin1, PxVec3* ang0, PxVec3* ang1)
        {
            fixed (PxJacobianRow* @this = &this)
            { Constructor_PInvoke(@this, lin0, lin1, ang0, ang1); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??XPxJacobianRow@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void operator_StarEqual_PInvoke(PxJacobianRow* @this, float scale);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void operator_StarEqual(float scale)
        {
            fixed (PxJacobianRow* @this = &this)
            { operator_StarEqual_PInvoke(@this, scale); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??DPxJacobianRow@physx@@QEBA?AU01@M@Z", ExactSpelling = true)]
        private static extern PxJacobianRow* operator_Star_PInvoke(PxJacobianRow* @this, out PxJacobianRow __returnBuffer, float scale);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxJacobianRow operator_Star(float scale)
        {
            fixed (PxJacobianRow* @this = &this)
            {
                PxJacobianRow __returnBuffer;
                operator_Star_PInvoke(@this, out __returnBuffer, scale);
                return __returnBuffer;
            }
        }
    }
}
