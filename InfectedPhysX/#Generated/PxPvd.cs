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
    public unsafe partial struct PxPvd
    {
        [FieldOffset(0)] public PxProfilerCallback Base;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool connect(PxPvdTransport* transport, PxPvdInstrumentationFlags flags)
        {
            fixed (PxPvd* @this = &this)
            { return VirtualMethodTablePointer->connect(@this, transport, flags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void disconnect()
        {
            fixed (PxPvd* @this = &this)
            { VirtualMethodTablePointer->disconnect(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isConnected(bool useCachedStatus = true)
        {
            fixed (PxPvd* @this = &this)
            { return VirtualMethodTablePointer->isConnected(@this, useCachedStatus); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxPvdTransport* getTransport()
        {
            fixed (PxPvd* @this = &this)
            { return VirtualMethodTablePointer->getTransport(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxPvdInstrumentationFlags getInstrumentationFlags()
        {
            fixed (PxPvd* @this = &this)
            {
                PxPvdInstrumentationFlags __returnBuffer;
                VirtualMethodTablePointer->getInstrumentationFlags(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void release()
        {
            fixed (PxPvd* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxPvd* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `~PxPvd`</summary>
            public delegate* unmanaged[Cdecl]<PxPvd*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `zoneStart`</summary>
            public delegate* unmanaged[Cdecl]<PxProfilerCallback*, byte*, NativeBoolean, ulong, void*> zoneStart;
            /// <summary>Virtual method pointer for `zoneEnd`</summary>
            public delegate* unmanaged[Cdecl]<PxProfilerCallback*, void*, byte*, NativeBoolean, ulong, void> zoneEnd;
            /// <summary>Virtual method pointer for `connect`</summary>
            public delegate* unmanaged[Cdecl]<PxPvd*, PxPvdTransport*, PxPvdInstrumentationFlags, NativeBoolean> connect;
            /// <summary>Virtual method pointer for `disconnect`</summary>
            public delegate* unmanaged[Cdecl]<PxPvd*, void> disconnect;
            /// <summary>Virtual method pointer for `isConnected`</summary>
            public delegate* unmanaged[Cdecl]<PxPvd*, NativeBoolean, NativeBoolean> isConnected;
            /// <summary>Virtual method pointer for `getTransport`</summary>
            public delegate* unmanaged[Cdecl]<PxPvd*, PxPvdTransport*> getTransport;
            /// <summary>Virtual method pointer for `getInstrumentationFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxPvd*, PxPvdInstrumentationFlags*, PxPvdInstrumentationFlags*> getInstrumentationFlags;
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxPvd*, void> release;
        }
    }
}
