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
    public unsafe partial struct PxAssertHandler
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxAssertHandler* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void operator_Call(byte* exp, byte* file, int line, bool* ignore)
        {
            fixed (PxAssertHandler* @this = &this)
            { VirtualMethodTablePointer->operator_Call(@this, exp, file, line, ignore); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `~PxAssertHandler`</summary>
            public delegate* unmanaged[Cdecl]<PxAssertHandler*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `operator()`</summary>
            public delegate* unmanaged[Cdecl]<PxAssertHandler*, byte*, byte*, int, bool*, void> operator_Call;
        }
    }
}
