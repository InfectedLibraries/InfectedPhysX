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
    public unsafe partial struct PxDelayLoadHook
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxDelayLoadHook@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxDelayLoadHook* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxDelayLoadHook* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxDelayLoadHook* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* getPhysXFoundationDllName()
        {
            fixed (PxDelayLoadHook* @this = &this)
            { return VirtualMethodTablePointer->getPhysXFoundationDllName(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* getPhysXCommonDllName()
        {
            fixed (PxDelayLoadHook* @this = &this)
            { return VirtualMethodTablePointer->getPhysXCommonDllName(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `~PxDelayLoadHook`</summary>
            public delegate* unmanaged[Cdecl]<PxDelayLoadHook*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `getPhysXFoundationDllName`</summary>
            public delegate* unmanaged[Cdecl]<PxDelayLoadHook*, byte*> getPhysXFoundationDllName;
            /// <summary>Virtual method pointer for `getPhysXCommonDllName`</summary>
            public delegate* unmanaged[Cdecl]<PxDelayLoadHook*, byte*> getPhysXCommonDllName;
        }
    }
}
