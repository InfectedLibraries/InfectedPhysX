// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using PhysX.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxCudaBuffer
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxCudaMemoryManager* getCudaMemoryManager()
        {
            fixed (PxCudaBuffer* @this = &this)
            { return VirtualMethodTablePointer->getCudaMemoryManager(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool free()
        {
            fixed (PxCudaBuffer* @this = &this)
            { return VirtualMethodTablePointer->free(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool realloc(ulong size, byte* file = null, int line = 0, byte* allocName = null, PxAllocId allocId = PxAllocId.UNASSIGNED)
        {
            fixed (PxCudaBuffer* @this = &this)
            { return VirtualMethodTablePointer->realloc(@this, size, file, line, allocName, allocId); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxCudaBufferType* getType()
        {
            fixed (PxCudaBuffer* @this = &this)
            { return VirtualMethodTablePointer->getType(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ulong getPtr()
        {
            fixed (PxCudaBuffer* @this = &this)
            { return VirtualMethodTablePointer->getPtr(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ulong getSize()
        {
            fixed (PxCudaBuffer* @this = &this)
            { return VirtualMethodTablePointer->getSize(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxCudaBuffer* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `getCudaMemoryManager`</summary>
            public delegate* unmanaged[Cdecl]<PxCudaBuffer*, PxCudaMemoryManager*> getCudaMemoryManager;
            /// <summary>Virtual method pointer for `free`</summary>
            public delegate* unmanaged[Cdecl]<PxCudaBuffer*, NativeBoolean> free;
            /// <summary>Virtual method pointer for `realloc`</summary>
            public delegate* unmanaged[Cdecl]<PxCudaBuffer*, ulong, byte*, int, byte*, PxAllocId, NativeBoolean> realloc;
            /// <summary>Virtual method pointer for `getType`</summary>
            public delegate* unmanaged[Cdecl]<PxCudaBuffer*, PxCudaBufferType*> getType;
            /// <summary>Virtual method pointer for `getPtr`</summary>
            public delegate* unmanaged[Cdecl]<PxCudaBuffer*, ulong> getPtr;
            /// <summary>Virtual method pointer for `getSize`</summary>
            public delegate* unmanaged[Cdecl]<PxCudaBuffer*, ulong> getSize;
            /// <summary>Virtual method pointer for `~PxCudaBuffer`</summary>
            public delegate* unmanaged[Cdecl]<PxCudaBuffer*, void> __DeletingDestructorPointer;
        }
    }
}
