// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct PxSphericalJoint
{
    [FieldOffset(0)] public PxJoint Base;

    public unsafe PxJointLimitCone getLimitCone()
    {
        fixed (PxSphericalJoint* @this = &this)
        {
            PxJointLimitCone __returnBuffer;
            VirtualMethodTablePointer->getLimitCone(@this, out __returnBuffer);
            return __returnBuffer;
        }
    }

    public unsafe void setLimitCone(PxJointLimitCone* limit)
    {
        fixed (PxSphericalJoint* @this = &this)
        { VirtualMethodTablePointer->setLimitCone(@this, limit); }
    }

    public unsafe float getSwingYAngle()
    {
        fixed (PxSphericalJoint* @this = &this)
        { return VirtualMethodTablePointer->getSwingYAngle(@this); }
    }

    public unsafe float getSwingZAngle()
    {
        fixed (PxSphericalJoint* @this = &this)
        { return VirtualMethodTablePointer->getSwingZAngle(@this); }
    }

    public unsafe void setSphericalJointFlags(PxSphericalJointFlags flags)
    {
        fixed (PxSphericalJoint* @this = &this)
        { VirtualMethodTablePointer->setSphericalJointFlags(@this, flags); }
    }

    public unsafe void setSphericalJointFlag(PxSphericalJointFlags flag, bool value)
    {
        fixed (PxSphericalJoint* @this = &this)
        { VirtualMethodTablePointer->setSphericalJointFlag(@this, flag, value); }
    }

    public unsafe PxSphericalJointFlags getSphericalJointFlags()
    {
        fixed (PxSphericalJoint* @this = &this)
        { return VirtualMethodTablePointer->getSphericalJointFlags(@this); }
    }

    public unsafe void setProjectionLinearTolerance(float tolerance)
    {
        fixed (PxSphericalJoint* @this = &this)
        { VirtualMethodTablePointer->setProjectionLinearTolerance(@this, tolerance); }
    }

    public unsafe float getProjectionLinearTolerance()
    {
        fixed (PxSphericalJoint* @this = &this)
        { return VirtualMethodTablePointer->getProjectionLinearTolerance(@this); }
    }

    public unsafe byte* getConcreteTypeName()
    {
        fixed (PxSphericalJoint* @this = &this)
        { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxSphericalJoint@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxSphericalJoint* @this, ushort concreteType, PxBaseFlags baseFlags);

    public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
    {
        fixed (PxSphericalJoint* @this = &this)
        { Constructor_PInvoke(@this, concreteType, baseFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxSphericalJoint@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxSphericalJoint* @this, PxBaseFlags baseFlags);

    public unsafe void Constructor(PxBaseFlags baseFlags)
    {
        fixed (PxSphericalJoint* @this = &this)
        { Constructor_PInvoke(@this, baseFlags); }
    }

    public unsafe bool isKindOf(byte* name)
    {
        fixed (PxSphericalJoint* @this = &this)
        { return VirtualMethodTablePointer->isKindOf(@this, name); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxSphericalJointCreate@physx@@YAPEAVPxSphericalJoint@1@AEAVPxPhysics@1@PEAVPxRigidActor@1@AEBVPxTransform@1@12@Z", ExactSpelling = true)]
    public static extern PxSphericalJoint* PxSphericalJointCreate(PxPhysics* physics, PxRigidActor* actor0, PxTransform* localFrame0, PxRigidActor* actor1, PxTransform* localFrame1);


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, void> release;
        /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, byte*> getConcreteTypeName;
        /// <summary>Virtual method pointer for `isReleasable`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, bool> isReleasable;
        /// <summary>Virtual method pointer for `~PxSphericalJoint`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isKindOf`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, byte*, bool> isKindOf;
        /// <summary>Virtual method pointer for `setActors`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxRigidActor*, PxRigidActor*, void> setActors;
        /// <summary>Virtual method pointer for `getActors`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxRigidActor**, PxRigidActor**, void> getActors;
        /// <summary>Virtual method pointer for `setLocalPose`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxJointActorIndex, PxTransform*, void> setLocalPose;
        /// <summary>Virtual method pointer for `getLocalPose`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, out PxTransform, PxJointActorIndex, void> getLocalPose;
        /// <summary>Virtual method pointer for `getRelativeTransform`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, out PxTransform, void> getRelativeTransform;
        /// <summary>Virtual method pointer for `getRelativeLinearVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, out PxVec3, void> getRelativeLinearVelocity;
        /// <summary>Virtual method pointer for `getRelativeAngularVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, out PxVec3, void> getRelativeAngularVelocity;
        /// <summary>Virtual method pointer for `setBreakForce`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, float, void> setBreakForce;
        /// <summary>Virtual method pointer for `getBreakForce`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float*, float*, void> getBreakForce;
        /// <summary>Virtual method pointer for `setConstraintFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags, void> setConstraintFlags;
        /// <summary>Virtual method pointer for `setConstraintFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags, bool, void> setConstraintFlag;
        /// <summary>Virtual method pointer for `getConstraintFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags> getConstraintFlags;
        /// <summary>Virtual method pointer for `setInvMassScale0`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, void> setInvMassScale0;
        /// <summary>Virtual method pointer for `getInvMassScale0`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float> getInvMassScale0;
        /// <summary>Virtual method pointer for `setInvInertiaScale0`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, void> setInvInertiaScale0;
        /// <summary>Virtual method pointer for `getInvInertiaScale0`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float> getInvInertiaScale0;
        /// <summary>Virtual method pointer for `setInvMassScale1`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, void> setInvMassScale1;
        /// <summary>Virtual method pointer for `getInvMassScale1`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float> getInvMassScale1;
        /// <summary>Virtual method pointer for `setInvInertiaScale1`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, void> setInvInertiaScale1;
        /// <summary>Virtual method pointer for `getInvInertiaScale1`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float> getInvInertiaScale1;
        /// <summary>Virtual method pointer for `getConstraint`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraint*> getConstraint;
        /// <summary>Virtual method pointer for `setName`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, byte*, void> setName;
        /// <summary>Virtual method pointer for `getName`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, byte*> getName;
        /// <summary>Virtual method pointer for `getScene`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxScene*> getScene;
        /// <summary>Virtual method pointer for `getLimitCone`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, out PxJointLimitCone, void> getLimitCone;
        /// <summary>Virtual method pointer for `setLimitCone`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, PxJointLimitCone*, void> setLimitCone;
        /// <summary>Virtual method pointer for `getSwingYAngle`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, float> getSwingYAngle;
        /// <summary>Virtual method pointer for `getSwingZAngle`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, float> getSwingZAngle;
        /// <summary>Virtual method pointer for `setSphericalJointFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, PxSphericalJointFlags, void> setSphericalJointFlags;
        /// <summary>Virtual method pointer for `setSphericalJointFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, PxSphericalJointFlags, bool, void> setSphericalJointFlag;
        /// <summary>Virtual method pointer for `getSphericalJointFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, PxSphericalJointFlags> getSphericalJointFlags;
        /// <summary>Virtual method pointer for `setProjectionLinearTolerance`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, float, void> setProjectionLinearTolerance;
        /// <summary>Virtual method pointer for `getProjectionLinearTolerance`</summary>
        public delegate* unmanaged[Cdecl]<PxSphericalJoint*, float> getProjectionLinearTolerance;
    }
}
