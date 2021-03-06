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
    public unsafe partial struct PxDeletionListener
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void onRelease(PxBase* observed, void* userData, PxDeletionEventFlags deletionEvent)
        {
            fixed (PxDeletionListener* @this = &this)
            { VirtualMethodTablePointer->onRelease(@this, observed, userData, deletionEvent); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxDeletionListener@physx@@IEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxDeletionListener* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxDeletionListener* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxDeletionListener* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `onRelease`</summary>
            public delegate* unmanaged[Cdecl]<PxDeletionListener*, PxBase*, void*, PxDeletionEventFlags, void> onRelease;
            /// <summary>Virtual method pointer for `~PxDeletionListener`</summary>
            public delegate* unmanaged[Cdecl]<PxDeletionListener*, void> __DeletingDestructorPointer;
        }
    }
}
