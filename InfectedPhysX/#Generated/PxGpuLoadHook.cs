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
    public unsafe partial struct PxGpuLoadHook
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxGpuLoadHook@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxGpuLoadHook* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxGpuLoadHook* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxGpuLoadHook* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* getPhysXGpuDllName()
        {
            fixed (PxGpuLoadHook* @this = &this)
            { return VirtualMethodTablePointer->getPhysXGpuDllName(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `~PxGpuLoadHook`</summary>
            public delegate* unmanaged[Cdecl]<PxGpuLoadHook*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `getPhysXGpuDllName`</summary>
            public delegate* unmanaged[Cdecl]<PxGpuLoadHook*, byte*> getPhysXGpuDllName;
        }
    }
}
