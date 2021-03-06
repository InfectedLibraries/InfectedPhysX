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
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct PxAggregate
    {
        [FieldOffset(0)] public PxBase Base;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void release()
        {
            fixed (PxAggregate* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool addActor(PxActor* actor, PxBVHStructure* bvhStructure = null)
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->addActor(@this, actor, bvhStructure); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool removeActor(PxActor* actor)
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->removeActor(@this, actor); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool addArticulation(PxArticulationBase* articulation)
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->addArticulation(@this, articulation); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool removeArticulation(PxArticulationBase* articulation)
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->removeArticulation(@this, articulation); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getNbActors()
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->getNbActors(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getMaxNbActors()
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->getMaxNbActors(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getActors(PxActor** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->getActors(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxScene* getScene()
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->getScene(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getSelfCollision()
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->getSelfCollision(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* getConcreteTypeName()
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxAggregate@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxAggregate* @this, ushort concreteType, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
        {
            fixed (PxAggregate* @this = &this)
            { Constructor_PInvoke(@this, concreteType, baseFlags); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxAggregate@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxAggregate* @this, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxBaseFlags baseFlags)
        {
            fixed (PxAggregate* @this = &this)
            { Constructor_PInvoke(@this, baseFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxAggregate* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isKindOf(byte* name)
        {
            fixed (PxAggregate* @this = &this)
            { return VirtualMethodTablePointer->isKindOf(@this, name); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxBase*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxAggregate`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, byte*, NativeBoolean> isKindOf;
            /// <summary>Virtual method pointer for `addActor`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, PxActor*, PxBVHStructure*, NativeBoolean> addActor;
            /// <summary>Virtual method pointer for `removeActor`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, PxActor*, NativeBoolean> removeActor;
            /// <summary>Virtual method pointer for `addArticulation`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, PxArticulationBase*, NativeBoolean> addArticulation;
            /// <summary>Virtual method pointer for `removeArticulation`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, PxArticulationBase*, NativeBoolean> removeArticulation;
            /// <summary>Virtual method pointer for `getNbActors`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, uint> getNbActors;
            /// <summary>Virtual method pointer for `getMaxNbActors`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, uint> getMaxNbActors;
            /// <summary>Virtual method pointer for `getActors`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, PxActor**, uint, uint, uint> getActors;
            /// <summary>Virtual method pointer for `getScene`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, PxScene*> getScene;
            /// <summary>Virtual method pointer for `getSelfCollision`</summary>
            public delegate* unmanaged[Cdecl]<PxAggregate*, NativeBoolean> getSelfCollision;
        }
    }
}
