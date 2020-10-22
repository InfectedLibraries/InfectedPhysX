// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct PxJoint
{
    [FieldOffset(0)] public PxBase Base;

    public unsafe void setActors(PxRigidActor* actor0, PxRigidActor* actor1)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setActors(@this, actor0, actor1); }
    }

    public unsafe void getActors(PxRigidActor** actor0, PxRigidActor** actor1)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->getActors(@this, actor0, actor1); }
    }

    public unsafe void setLocalPose(PxJointActorIndex actor, PxTransform* localPose)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setLocalPose(@this, actor, localPose); }
    }

    public unsafe PxTransform getLocalPose(PxJointActorIndex actor)
    {
        fixed (PxJoint* @this = &this)
        {
            PxTransform __returnBuffer;
            VirtualMethodTablePointer->getLocalPose(@this, out __returnBuffer, actor);
            return __returnBuffer;
        }
    }

    public unsafe PxTransform getRelativeTransform()
    {
        fixed (PxJoint* @this = &this)
        {
            PxTransform __returnBuffer;
            VirtualMethodTablePointer->getRelativeTransform(@this, out __returnBuffer);
            return __returnBuffer;
        }
    }

    public unsafe PxVec3 getRelativeLinearVelocity()
    {
        fixed (PxJoint* @this = &this)
        {
            PxVec3 __returnBuffer;
            VirtualMethodTablePointer->getRelativeLinearVelocity(@this, out __returnBuffer);
            return __returnBuffer;
        }
    }

    public unsafe PxVec3 getRelativeAngularVelocity()
    {
        fixed (PxJoint* @this = &this)
        {
            PxVec3 __returnBuffer;
            VirtualMethodTablePointer->getRelativeAngularVelocity(@this, out __returnBuffer);
            return __returnBuffer;
        }
    }

    public unsafe void setBreakForce(float force, float torque)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setBreakForce(@this, force, torque); }
    }

    public unsafe void getBreakForce(float* force, float* torque)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->getBreakForce(@this, force, torque); }
    }

    public unsafe void setConstraintFlags(PxConstraintFlags flags)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setConstraintFlags(@this, flags); }
    }

    public unsafe void setConstraintFlag(PxConstraintFlags flag, bool value)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setConstraintFlag(@this, flag, value); }
    }

    public unsafe PxConstraintFlags getConstraintFlags()
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->getConstraintFlags(@this); }
    }

    public unsafe void setInvMassScale0(float invMassScale)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setInvMassScale0(@this, invMassScale); }
    }

    public unsafe float getInvMassScale0()
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->getInvMassScale0(@this); }
    }

    public unsafe void setInvInertiaScale0(float invInertiaScale)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setInvInertiaScale0(@this, invInertiaScale); }
    }

    public unsafe float getInvInertiaScale0()
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->getInvInertiaScale0(@this); }
    }

    public unsafe void setInvMassScale1(float invMassScale)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setInvMassScale1(@this, invMassScale); }
    }

    public unsafe float getInvMassScale1()
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->getInvMassScale1(@this); }
    }

    public unsafe void setInvInertiaScale1(float invInertiaScale)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setInvInertiaScale1(@this, invInertiaScale); }
    }

    public unsafe float getInvInertiaScale1()
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->getInvInertiaScale1(@this); }
    }

    public unsafe PxConstraint* getConstraint()
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->getConstraint(@this); }
    }

    public unsafe void setName(byte* name)
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->setName(@this, name); }
    }

    public unsafe byte* getName()
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->getName(@this); }
    }

    public unsafe void release()
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->release(@this); }
    }

    public unsafe PxScene* getScene()
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->getScene(@this); }
    }

    [FieldOffset(16)] public void* userData;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBinaryMetaData@PxJoint@physx@@SAXAEAVPxOutputStream@2@@Z", ExactSpelling = true)]
    public static extern void getBinaryMetaData(PxOutputStream* stream);

    public unsafe void Destructor()
    {
        fixed (PxJoint* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJoint@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxJoint* @this, ushort concreteType, PxBaseFlags baseFlags);

    public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
    {
        fixed (PxJoint* @this = &this)
        { Constructor_PInvoke(@this, concreteType, baseFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJoint@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxJoint* @this, PxBaseFlags baseFlags);

    public unsafe void Constructor(PxBaseFlags baseFlags)
    {
        fixed (PxJoint* @this = &this)
        { Constructor_PInvoke(@this, baseFlags); }
    }

    public unsafe bool isKindOf(byte* name)
    {
        fixed (PxJoint* @this = &this)
        { return VirtualMethodTablePointer->isKindOf(@this, name); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void PxSetJointGlobalFrame(PxJoint* joint, PxVec3* wsAnchor, PxVec3* wsAxis);


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, void> release;
        /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, byte*> getConcreteTypeName;
        /// <summary>Virtual method pointer for `isReleasable`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, bool> isReleasable;
        /// <summary>Virtual method pointer for `~PxJoint`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isKindOf`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, byte*, bool> isKindOf;
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
    }
}
