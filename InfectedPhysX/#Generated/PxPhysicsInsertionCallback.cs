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
    public unsafe partial struct PxPhysicsInsertionCallback
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxPhysicsInsertionCallback@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxPhysicsInsertionCallback* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxPhysicsInsertionCallback* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxBase* buildObjectFromData(PxConcreteType type, void* data)
        {
            fixed (PxPhysicsInsertionCallback* @this = &this)
            { return VirtualMethodTablePointer->buildObjectFromData(@this, type, data); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxPhysicsInsertionCallback* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `buildObjectFromData`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysicsInsertionCallback*, PxConcreteType, void*, PxBase*> buildObjectFromData;
            /// <summary>Virtual method pointer for `~PxPhysicsInsertionCallback`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysicsInsertionCallback*, void> __DeletingDestructorPointer;
        }
    }
}
