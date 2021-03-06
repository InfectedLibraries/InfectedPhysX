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
    public unsafe partial struct PxFoundation
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void release()
        {
            fixed (PxFoundation* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxErrorCallback* getErrorCallback()
        {
            fixed (PxFoundation* @this = &this)
            { return VirtualMethodTablePointer->getErrorCallback(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setErrorLevel(PxErrorCode mask = (PxErrorCode)(-1))
        {
            fixed (PxFoundation* @this = &this)
            { VirtualMethodTablePointer->setErrorLevel(@this, mask); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxErrorCode getErrorLevel()
        {
            fixed (PxFoundation* @this = &this)
            { return VirtualMethodTablePointer->getErrorLevel(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxAllocatorCallback* getAllocatorCallback()
        {
            fixed (PxFoundation* @this = &this)
            { return VirtualMethodTablePointer->getAllocatorCallback(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getReportAllocationNames()
        {
            fixed (PxFoundation* @this = &this)
            { return VirtualMethodTablePointer->getReportAllocationNames(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setReportAllocationNames(bool value)
        {
            fixed (PxFoundation* @this = &this)
            { VirtualMethodTablePointer->setReportAllocationNames(@this, value); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxFoundation* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxFoundation*, void> release;
            /// <summary>Virtual method pointer for `getErrorCallback`</summary>
            public delegate* unmanaged[Cdecl]<PxFoundation*, PxErrorCallback*> getErrorCallback;
            /// <summary>Virtual method pointer for `setErrorLevel`</summary>
            public delegate* unmanaged[Cdecl]<PxFoundation*, PxErrorCode, void> setErrorLevel;
            /// <summary>Virtual method pointer for `getErrorLevel`</summary>
            public delegate* unmanaged[Cdecl]<PxFoundation*, PxErrorCode> getErrorLevel;
            /// <summary>Virtual method pointer for `getAllocatorCallback`</summary>
            public delegate* unmanaged[Cdecl]<PxFoundation*, PxAllocatorCallback*> getAllocatorCallback;
            /// <summary>Virtual method pointer for `getReportAllocationNames`</summary>
            public delegate* unmanaged[Cdecl]<PxFoundation*, NativeBoolean> getReportAllocationNames;
            /// <summary>Virtual method pointer for `setReportAllocationNames`</summary>
            public delegate* unmanaged[Cdecl]<PxFoundation*, NativeBoolean, void> setReportAllocationNames;
            /// <summary>Virtual method pointer for `~PxFoundation`</summary>
            public delegate* unmanaged[Cdecl]<PxFoundation*, void> __DeletingDestructorPointer;
        }
    }
}
