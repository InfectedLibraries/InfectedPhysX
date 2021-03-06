// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public unsafe partial struct PxBatchQueryDesc
    {
        [FieldOffset(0)] public void* filterShaderData;

        [FieldOffset(8)] public uint filterShaderDataSize;

        [FieldOffset(16)] public delegate* unmanaged[Cdecl]<PxFilterData, PxFilterData, void*, uint, PxHitFlags*, PxQueryHitType> preFilterShader;

        [FieldOffset(24)] public delegate* unmanaged[Cdecl]<PxFilterData, PxFilterData, void*, uint, PxQueryHit*, PxQueryHitType> postFilterShader;

        [FieldOffset(32)] public PxBatchQueryMemory queryMemory;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxBatchQueryDesc@physx@@QEAA@III@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxBatchQueryDesc* @this, uint maxRaycastsPerExecute, uint maxSweepsPerExecute, uint maxOverlapsPerExecute);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(uint maxRaycastsPerExecute, uint maxSweepsPerExecute, uint maxOverlapsPerExecute)
        {
            fixed (PxBatchQueryDesc* @this = &this)
            { Constructor_PInvoke(@this, maxRaycastsPerExecute, maxSweepsPerExecute, maxOverlapsPerExecute); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxBatchQueryDesc@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxBatchQueryDesc* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxBatchQueryDesc* @this = &this)
            { return isValid_PInvoke(@this); }
        }
    }
}
