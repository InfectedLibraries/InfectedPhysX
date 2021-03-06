// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct PxBatchQueryMemory
    {
        [FieldOffset(0)] public /* Failed to emit TranslatedNormalField userRaycastResultBuffer: Failed to resolve `Ref resolved by PxBatchQueryResult` during emit time. */
        int* userRaycastResultBuffer;

        [FieldOffset(8)] public PxRaycastHit* userRaycastTouchBuffer;

        [FieldOffset(16)] public /* Failed to emit TranslatedNormalField userSweepResultBuffer: Failed to resolve `Ref resolved by PxBatchQueryResult` during emit time. */
        int* userSweepResultBuffer;

        [FieldOffset(24)] public PxSweepHit* userSweepTouchBuffer;

        [FieldOffset(32)] public /* Failed to emit TranslatedNormalField userOverlapResultBuffer: Failed to resolve `Ref resolved by PxBatchQueryResult` during emit time. */
        int* userOverlapResultBuffer;

        [FieldOffset(40)] public PxOverlapHit* userOverlapTouchBuffer;

        [FieldOffset(48)] public uint raycastTouchBufferSize;

        [FieldOffset(52)] public uint sweepTouchBufferSize;

        [FieldOffset(56)] public uint overlapTouchBufferSize;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getMaxRaycastsPerExecute@PxBatchQueryMemory@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getMaxRaycastsPerExecute_PInvoke(PxBatchQueryMemory* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getMaxRaycastsPerExecute()
        {
            fixed (PxBatchQueryMemory* @this = &this)
            { return getMaxRaycastsPerExecute_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getMaxSweepsPerExecute@PxBatchQueryMemory@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getMaxSweepsPerExecute_PInvoke(PxBatchQueryMemory* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getMaxSweepsPerExecute()
        {
            fixed (PxBatchQueryMemory* @this = &this)
            { return getMaxSweepsPerExecute_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getMaxOverlapsPerExecute@PxBatchQueryMemory@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getMaxOverlapsPerExecute_PInvoke(PxBatchQueryMemory* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getMaxOverlapsPerExecute()
        {
            fixed (PxBatchQueryMemory* @this = &this)
            { return getMaxOverlapsPerExecute_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxBatchQueryMemory@physx@@QEAA@III@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxBatchQueryMemory* @this, uint raycastResultBufferSize_, uint sweepResultBufferSize_, uint overlapResultBufferSize_);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(uint raycastResultBufferSize_, uint sweepResultBufferSize_, uint overlapResultBufferSize_)
        {
            fixed (PxBatchQueryMemory* @this = &this)
            { Constructor_PInvoke(@this, raycastResultBufferSize_, sweepResultBufferSize_, overlapResultBufferSize_); }
        }

        [FieldOffset(60)] public uint raycastResultBufferSize;

        [FieldOffset(64)] public uint sweepResultBufferSize;

        [FieldOffset(68)] public uint overlapResultBufferSize;
    }
}
