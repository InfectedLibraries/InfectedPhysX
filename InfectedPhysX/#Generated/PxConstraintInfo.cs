// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct PxConstraintInfo
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxConstraintInfo@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxConstraintInfo* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxConstraintInfo* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxConstraintInfo@physx@@QEAA@PEAVPxConstraint@1@PEAXI@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxConstraintInfo* @this, PxConstraint* c, void* extRef, uint t);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxConstraint* c, void* extRef, uint t)
        {
            fixed (PxConstraintInfo* @this = &this)
            { Constructor_PInvoke(@this, c, extRef, t); }
        }

        [FieldOffset(0)] public PxConstraint* constraint;

        [FieldOffset(8)] public void* externalReference;

        [FieldOffset(16)] public uint type;
    }
}
