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
    public unsafe partial struct PxGroupsMask
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxGroupsMask@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxGroupsMask* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxGroupsMask* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??1PxGroupsMask@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(PxGroupsMask* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxGroupsMask* @this = &this)
            { Destructor_PInvoke(@this); }
        }

        [FieldOffset(0)] public ushort bits0;

        [FieldOffset(2)] public ushort bits1;

        [FieldOffset(4)] public ushort bits2;

        [FieldOffset(6)] public ushort bits3;
    }
}
