// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct PxRigidDynamic
{
    [FieldOffset(0)] public PxRigidBody Base;

    public unsafe void setKinematicTarget(PxTransform* destination)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->setKinematicTarget(@this, destination); }
    }

    public unsafe bool getKinematicTarget(PxTransform* target)
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->getKinematicTarget(@this, target); }
    }

    public unsafe bool isSleeping()
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->isSleeping(@this); }
    }

    public unsafe void setSleepThreshold(float threshold)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->setSleepThreshold(@this, threshold); }
    }

    public unsafe float getSleepThreshold()
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->getSleepThreshold(@this); }
    }

    public unsafe void setStabilizationThreshold(float threshold)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->setStabilizationThreshold(@this, threshold); }
    }

    public unsafe float getStabilizationThreshold()
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->getStabilizationThreshold(@this); }
    }

    public unsafe PxRigidDynamicLockFlags getRigidDynamicLockFlags()
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->getRigidDynamicLockFlags(@this); }
    }

    public unsafe void setRigidDynamicLockFlag(PxRigidDynamicLockFlags flag, bool value)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->setRigidDynamicLockFlag(@this, flag, value); }
    }

    public unsafe void setRigidDynamicLockFlags(PxRigidDynamicLockFlags flags)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->setRigidDynamicLockFlags(@this, flags); }
    }

    public unsafe void setWakeCounter(float wakeCounterValue)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->setWakeCounter(@this, wakeCounterValue); }
    }

    public unsafe float getWakeCounter()
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->getWakeCounter(@this); }
    }

    public unsafe void wakeUp()
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->wakeUp(@this); }
    }

    public unsafe void putToSleep()
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->putToSleep(@this); }
    }

    public unsafe void setSolverIterationCounts(uint minPositionIters, uint minVelocityIters = 1)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->setSolverIterationCounts(@this, minPositionIters, minVelocityIters); }
    }

    public unsafe void getSolverIterationCounts(uint* minPositionIters, uint* minVelocityIters)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->getSolverIterationCounts(@this, minPositionIters, minVelocityIters); }
    }

    public unsafe float getContactReportThreshold()
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->getContactReportThreshold(@this); }
    }

    public unsafe void setContactReportThreshold(float threshold)
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->setContactReportThreshold(@this, threshold); }
    }

    public unsafe byte* getConcreteTypeName()
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxRigidDynamic@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxRigidDynamic* @this, ushort concreteType, PxBaseFlags baseFlags);

    public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
    {
        fixed (PxRigidDynamic* @this = &this)
        { Constructor_PInvoke(@this, concreteType, baseFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxRigidDynamic@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxRigidDynamic* @this, PxBaseFlags baseFlags);

    public unsafe void Constructor(PxBaseFlags baseFlags)
    {
        fixed (PxRigidDynamic* @this = &this)
        { Constructor_PInvoke(@this, baseFlags); }
    }

    public unsafe void Destructor()
    {
        fixed (PxRigidDynamic* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    public unsafe bool isKindOf(byte* name)
    {
        fixed (PxRigidDynamic* @this = &this)
        { return VirtualMethodTablePointer->isKindOf(@this, name); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidActor*, void> release;
        /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, byte*> getConcreteTypeName;
        /// <summary>Virtual method pointer for `isReleasable`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, bool> isReleasable;
        /// <summary>Virtual method pointer for `~PxRigidDynamic`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isKindOf`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, byte*, bool> isKindOf;
        /// <summary>Virtual method pointer for `getType`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxActorType> getType;
        /// <summary>Virtual method pointer for `getScene`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxScene*> getScene;
        /// <summary>Virtual method pointer for `setName`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte*, void> setName;
        /// <summary>Virtual method pointer for `getName`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte*> getName;
        /// <summary>Virtual method pointer for `getWorldBounds`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, out PxBounds3, float, void> getWorldBounds;
        /// <summary>Virtual method pointer for `setActorFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags, bool, void> setActorFlag;
        /// <summary>Virtual method pointer for `setActorFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags, void> setActorFlags;
        /// <summary>Virtual method pointer for `getActorFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags> getActorFlags;
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
        public delegate* unmanaged[Cdecl]<PxRigidActor*, out PxTransform, void> getGlobalPose;
        /// <summary>Virtual method pointer for `setGlobalPose`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidActor*, PxTransform*, bool, void> setGlobalPose;
        /// <summary>Virtual method pointer for `attachShape`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidActor*, PxShape*, bool> attachShape;
        /// <summary>Virtual method pointer for `detachShape`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidActor*, PxShape*, bool, void> detachShape;
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
        public delegate* unmanaged[Cdecl]<PxRigidBody*, out PxTransform, void> getCMassLocalPose;
        /// <summary>Virtual method pointer for `setMass`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMass;
        /// <summary>Virtual method pointer for `getMass`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMass;
        /// <summary>Virtual method pointer for `getInvMass`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getInvMass;
        /// <summary>Virtual method pointer for `setMassSpaceInertiaTensor`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, void> setMassSpaceInertiaTensor;
        /// <summary>Virtual method pointer for `getMassSpaceInertiaTensor`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, out PxVec3, void> getMassSpaceInertiaTensor;
        /// <summary>Virtual method pointer for `getMassSpaceInvInertiaTensor`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, out PxVec3, void> getMassSpaceInvInertiaTensor;
        /// <summary>Virtual method pointer for `setLinearDamping`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setLinearDamping;
        /// <summary>Virtual method pointer for `getLinearDamping`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getLinearDamping;
        /// <summary>Virtual method pointer for `setAngularDamping`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setAngularDamping;
        /// <summary>Virtual method pointer for `getAngularDamping`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getAngularDamping;
        /// <summary>Virtual method pointer for `getLinearVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, out PxVec3, void> getLinearVelocity;
        /// <summary>Virtual method pointer for `setLinearVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, bool, void> setLinearVelocity;
        /// <summary>Virtual method pointer for `getAngularVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, out PxVec3, void> getAngularVelocity;
        /// <summary>Virtual method pointer for `setAngularVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, bool, void> setAngularVelocity;
        /// <summary>Virtual method pointer for `setMaxAngularVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMaxAngularVelocity;
        /// <summary>Virtual method pointer for `getMaxAngularVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMaxAngularVelocity;
        /// <summary>Virtual method pointer for `setMaxLinearVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float, void> setMaxLinearVelocity;
        /// <summary>Virtual method pointer for `getMaxLinearVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, float> getMaxLinearVelocity;
        /// <summary>Virtual method pointer for `addForce`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxForceMode, bool, void> addForce;
        /// <summary>Virtual method pointer for `addTorque`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxForceMode, bool, void> addTorque;
        /// <summary>Virtual method pointer for `clearForce`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxForceMode, void> clearForce;
        /// <summary>Virtual method pointer for `clearTorque`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxForceMode, void> clearTorque;
        /// <summary>Virtual method pointer for `setForceAndTorque`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxVec3*, PxVec3*, PxForceMode, void> setForceAndTorque;
        /// <summary>Virtual method pointer for `setRigidBodyFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxRigidBodyFlags, bool, void> setRigidBodyFlag;
        /// <summary>Virtual method pointer for `setRigidBodyFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxRigidBodyFlags, void> setRigidBodyFlags;
        /// <summary>Virtual method pointer for `getRigidBodyFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidBody*, PxRigidBodyFlags> getRigidBodyFlags;
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
        /// <summary>Virtual method pointer for `setKinematicTarget`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, PxTransform*, void> setKinematicTarget;
        /// <summary>Virtual method pointer for `getKinematicTarget`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, PxTransform*, bool> getKinematicTarget;
        /// <summary>Virtual method pointer for `isSleeping`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, bool> isSleeping;
        /// <summary>Virtual method pointer for `setSleepThreshold`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, float, void> setSleepThreshold;
        /// <summary>Virtual method pointer for `getSleepThreshold`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, float> getSleepThreshold;
        /// <summary>Virtual method pointer for `setStabilizationThreshold`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, float, void> setStabilizationThreshold;
        /// <summary>Virtual method pointer for `getStabilizationThreshold`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, float> getStabilizationThreshold;
        /// <summary>Virtual method pointer for `getRigidDynamicLockFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, PxRigidDynamicLockFlags> getRigidDynamicLockFlags;
        /// <summary>Virtual method pointer for `setRigidDynamicLockFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, PxRigidDynamicLockFlags, bool, void> setRigidDynamicLockFlag;
        /// <summary>Virtual method pointer for `setRigidDynamicLockFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, PxRigidDynamicLockFlags, void> setRigidDynamicLockFlags;
        /// <summary>Virtual method pointer for `setWakeCounter`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, float, void> setWakeCounter;
        /// <summary>Virtual method pointer for `getWakeCounter`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, float> getWakeCounter;
        /// <summary>Virtual method pointer for `wakeUp`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, void> wakeUp;
        /// <summary>Virtual method pointer for `putToSleep`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, void> putToSleep;
        /// <summary>Virtual method pointer for `setSolverIterationCounts`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, uint, uint, void> setSolverIterationCounts;
        /// <summary>Virtual method pointer for `getSolverIterationCounts`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, uint*, uint*, void> getSolverIterationCounts;
        /// <summary>Virtual method pointer for `getContactReportThreshold`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, float> getContactReportThreshold;
        /// <summary>Virtual method pointer for `setContactReportThreshold`</summary>
        public delegate* unmanaged[Cdecl]<PxRigidDynamic*, float, void> setContactReportThreshold;
    }
}