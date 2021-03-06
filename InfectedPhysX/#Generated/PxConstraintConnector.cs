// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using PhysX.Infrastructure;
using PhysX.PvdSdk;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxConstraintConnector
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void* prepareData()
        {
            fixed (PxConstraintConnector* @this = &this)
            { return VirtualMethodTablePointer->prepareData(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool updatePvdProperties(PvdDataStream* pvdConnection, PxConstraint* c, PxPvdUpdateType updateType)
        {
            fixed (PxConstraintConnector* @this = &this)
            { return VirtualMethodTablePointer->updatePvdProperties(@this, pvdConnection, c, updateType); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void onConstraintRelease()
        {
            fixed (PxConstraintConnector* @this = &this)
            { VirtualMethodTablePointer->onConstraintRelease(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void onComShift(uint actor)
        {
            fixed (PxConstraintConnector* @this = &this)
            { VirtualMethodTablePointer->onComShift(@this, actor); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void onOriginShift(PxVec3* shift)
        {
            fixed (PxConstraintConnector* @this = &this)
            { VirtualMethodTablePointer->onOriginShift(@this, shift); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void* getExternalReference(uint* typeID)
        {
            fixed (PxConstraintConnector* @this = &this)
            { return VirtualMethodTablePointer->getExternalReference(@this, typeID); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxBase* getSerializable()
        {
            fixed (PxConstraintConnector* @this = &this)
            { return VirtualMethodTablePointer->getSerializable(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe delegate* unmanaged[Cdecl]<Px1DConstraint*, PxVec3*, uint, PxConstraintInvMassScale*, void*, PxTransform*, PxTransform*, NativeBoolean, PxVec3*, PxVec3*, uint> getPrep()
        {
            fixed (PxConstraintConnector* @this = &this)
            { return VirtualMethodTablePointer->getPrep(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void* getConstantBlock()
        {
            fixed (PxConstraintConnector* @this = &this)
            { return VirtualMethodTablePointer->getConstantBlock(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxConstraintConnector* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `prepareData`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, void*> prepareData;
            /// <summary>Virtual method pointer for `updatePvdProperties`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, PvdDataStream*, PxConstraint*, PxPvdUpdateType, NativeBoolean> updatePvdProperties;
            /// <summary>Virtual method pointer for `onConstraintRelease`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, void> onConstraintRelease;
            /// <summary>Virtual method pointer for `onComShift`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, uint, void> onComShift;
            /// <summary>Virtual method pointer for `onOriginShift`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, PxVec3*, void> onOriginShift;
            /// <summary>Virtual method pointer for `getExternalReference`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, uint*, void*> getExternalReference;
            /// <summary>Virtual method pointer for `getSerializable`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, PxBase*> getSerializable;
            /// <summary>Virtual method pointer for `getPrep`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, delegate* unmanaged[Cdecl]<Px1DConstraint*, PxVec3*, uint, PxConstraintInvMassScale*, void*, PxTransform*, PxTransform*, NativeBoolean, PxVec3*, PxVec3*, uint>> getPrep;
            /// <summary>Virtual method pointer for `getConstantBlock`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, void*> getConstantBlock;
            /// <summary>Virtual method pointer for `~PxConstraintConnector`</summary>
            public delegate* unmanaged[Cdecl]<PxConstraintConnector*, void> __DeletingDestructorPointer;
        }
    }
}
