// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxScopedCudaLock
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxScopedCudaLock@physx@@QEAA@AEAVPxCudaContextManager@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxScopedCudaLock* @this, PxCudaContextManager* ctx);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxCudaContextManager* ctx)
        {
            fixed (PxScopedCudaLock* @this = &this)
            { Constructor_PInvoke(@this, ctx); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??1PxScopedCudaLock@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(PxScopedCudaLock* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxScopedCudaLock* @this = &this)
            { Destructor_PInvoke(@this); }
        }

        [FieldOffset(0)] public PxCudaContextManager* mCtx;
    }
}
