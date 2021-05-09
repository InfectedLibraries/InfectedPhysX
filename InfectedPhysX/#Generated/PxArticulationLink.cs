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
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct PxArticulationLink
    {
        [FieldOffset(0)] public PxRigidBody Base;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void release()
        {
            fixed (PxArticulationLink* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxArticulationBase* getArticulation()
        {
            fixed (PxArticulationLink* @this = &this)
            { return VirtualMethodTablePointer->getArticulation(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxArticulationJointBase* getInboundJoint()
        {
            fixed (PxArticulationLink* @this = &this)
            { return VirtualMethodTablePointer->getInboundJoint(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getInboundJointDof()
        {
            fixed (PxArticulationLink* @this = &this)
            { return VirtualMethodTablePointer->getInboundJointDof(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getNbChildren()
        {
            fixed (PxArticulationLink* @this = &this)
            { return VirtualMethodTablePointer->getNbChildren(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getLinkIndex()
        {
            fixed (PxArticulationLink* @this = &this)
            { return VirtualMethodTablePointer->getLinkIndex(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getChildren(PxArticulationLink** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxArticulationLink* @this = &this)
            { return VirtualMethodTablePointer->getChildren(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* getConcreteTypeName()
        {
            fixed (PxArticulationLink* @this = &this)
            { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxArticulationLink@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxArticulationLink* @this, ushort concreteType, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
        {
            fixed (PxArticulationLink* @this = &this)
            { Constructor_PInvoke(@this, concreteType, baseFlags); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxArticulationLink@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxArticulationLink* @this, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxBaseFlags baseFlags)
        {
            fixed (PxArticulationLink* @this = &this)
            { Constructor_PInvoke(@this, baseFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxArticulationLink* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isKindOf(byte* name)
        {
            fixed (PxArticulationLink* @this = &this)
            { return VirtualMethodTablePointer->isKindOf(@this, name); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxBase*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxArticulationLink`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, byte*, NativeBoolean> isKindOf;
            /// <summary>Virtual method pointer for `getType`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, PxActorType> getType;
            /// <summary>Virtual method pointer for `getScene`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, PxScene*> getScene;
            /// <summary>Virtual method pointer for `setName`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, byte*, void> setName;
            /// <summary>Virtual method pointer for `getName`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, byte*> getName;
            /// <summary>Virtual method pointer for `getWorldBounds`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, PxBounds3*, float, PxBounds3*> getWorldBounds;
            /// <summary>Virtual method pointer for `setActorFlag`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags, NativeBoolean, void> setActorFlag;
            /// <summary>Virtual method pointer for `setActorFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags, void> setActorFlags;
            /// <summary>Virtual method pointer for `getActorFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags*, PxActorFlags*> getActorFlags;
            /// <summary>Virtual method pointer for `setDominanceGroup`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, byte, void> setDominanceGroup;
            /// <summary>Virtual method pointer for `getDominanceGroup`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, byte> getDominanceGroup;
            /// <summary>Virtual method pointer for `setOwnerClient`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, byte, void> setOwnerClient;
            /// <summary>Virtual method pointer for `getOwnerClient`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, byte> getOwnerClient;
            /// <summary>Virtual method pointer for `getAggregate`</summary>
            public delegate* unmanaged[Cdecl]<PxActor*, PxAggregate*> getAggregate;
            /// <summary>Virtual method pointer for `getGlobalPose`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidActor*, PxTransform*, PxTransform*> getGlobalPose;
            /// <summary>Virtual method pointer for `setGlobalPose`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidActor*, PxTransform*, NativeBoolean, void> setGlobalPose;
            /// <summary>Virtual method pointer for `attachShape`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidActor*, PxShape*, NativeBoolean> attachShape;
            /// <summary>Virtual method pointer for `detachShape`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidActor*, PxShape*, NativeBoolean, void> detachShape;
            /// <summary>Virtual method pointer for `getNbShapes`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidActor*, uint> getNbShapes;
            /// <summary>Virtual method pointer for `getShapes`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidActor*, PxShape**, uint, uint, uint> getShapes;
            /// <summary>Virtual method pointer for `getNbConstraints`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidActor*, uint> getNbConstraints;
            /// <summary>Virtual method pointer for `getConstraints`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidActor*, PxConstraint**, uint, uint, uint> getConstraints;
            /// <summary>Virtual method pointer for `setCMassLocalPose`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxTransform*, void> setCMassLocalPose;
            /// <summary>Virtual method pointer for `getCMassLocalPose`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxTransform*, PxTransform*> getCMassLocalPose;
            /// <summary>Virtual method pointer for `setMass`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMass;
            /// <summary>Virtual method pointer for `getMass`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMass;
            /// <summary>Virtual method pointer for `getInvMass`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getInvMass;
            /// <summary>Virtual method pointer for `setMassSpaceInertiaTensor`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, void> setMassSpaceInertiaTensor;
            /// <summary>Virtual method pointer for `getMassSpaceInertiaTensor`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxVec3*> getMassSpaceInertiaTensor;
            /// <summary>Virtual method pointer for `getMassSpaceInvInertiaTensor`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxVec3*> getMassSpaceInvInertiaTensor;
            /// <summary>Virtual method pointer for `setLinearDamping`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setLinearDamping;
            /// <summary>Virtual method pointer for `getLinearDamping`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getLinearDamping;
            /// <summary>Virtual method pointer for `setAngularDamping`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setAngularDamping;
            /// <summary>Virtual method pointer for `getAngularDamping`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getAngularDamping;
            /// <summary>Virtual method pointer for `getLinearVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxVec3*> getLinearVelocity;
            /// <summary>Virtual method pointer for `setLinearVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, NativeBoolean, void> setLinearVelocity;
            /// <summary>Virtual method pointer for `getAngularVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxVec3*> getAngularVelocity;
            /// <summary>Virtual method pointer for `setAngularVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, NativeBoolean, void> setAngularVelocity;
            /// <summary>Virtual method pointer for `setMaxAngularVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMaxAngularVelocity;
            /// <summary>Virtual method pointer for `getMaxAngularVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMaxAngularVelocity;
            /// <summary>Virtual method pointer for `setMaxLinearVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMaxLinearVelocity;
            /// <summary>Virtual method pointer for `getMaxLinearVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMaxLinearVelocity;
            /// <summary>Virtual method pointer for `addForce`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxForceMode, NativeBoolean, void> addForce;
            /// <summary>Virtual method pointer for `addTorque`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxForceMode, NativeBoolean, void> addTorque;
            /// <summary>Virtual method pointer for `clearForce`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxForceMode, void> clearForce;
            /// <summary>Virtual method pointer for `clearTorque`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxForceMode, void> clearTorque;
            /// <summary>Virtual method pointer for `setForceAndTorque`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxVec3*, PxForceMode, void> setForceAndTorque;
            /// <summary>Virtual method pointer for `setRigidBodyFlag`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxRigidBodyFlags, NativeBoolean, void> setRigidBodyFlag;
            /// <summary>Virtual method pointer for `setRigidBodyFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxRigidBodyFlags, void> setRigidBodyFlags;
            /// <summary>Virtual method pointer for `getRigidBodyFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, PxRigidBodyFlags*, PxRigidBodyFlags*> getRigidBodyFlags;
            /// <summary>Virtual method pointer for `setMinCCDAdvanceCoefficient`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMinCCDAdvanceCoefficient;
            /// <summary>Virtual method pointer for `getMinCCDAdvanceCoefficient`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMinCCDAdvanceCoefficient;
            /// <summary>Virtual method pointer for `setMaxDepenetrationVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMaxDepenetrationVelocity;
            /// <summary>Virtual method pointer for `getMaxDepenetrationVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMaxDepenetrationVelocity;
            /// <summary>Virtual method pointer for `setMaxContactImpulse`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMaxContactImpulse;
            /// <summary>Virtual method pointer for `getMaxContactImpulse`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMaxContactImpulse;
            /// <summary>Virtual method pointer for `getInternalIslandNodeIndex`</summary>
            public delegate* unmanaged[Cdecl]<PxRigidBody*, uint> getInternalIslandNodeIndex;
            /// <summary>Virtual method pointer for `getArticulation`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, PxArticulationBase*> getArticulation;
            /// <summary>Virtual method pointer for `getInboundJoint`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, PxArticulationJointBase*> getInboundJoint;
            /// <summary>Virtual method pointer for `getInboundJointDof`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, uint> getInboundJointDof;
            /// <summary>Virtual method pointer for `getNbChildren`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, uint> getNbChildren;
            /// <summary>Virtual method pointer for `getLinkIndex`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, uint> getLinkIndex;
            /// <summary>Virtual method pointer for `getChildren`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationLink*, PxArticulationLink**, uint, uint, uint> getChildren;
        }
    }
}
