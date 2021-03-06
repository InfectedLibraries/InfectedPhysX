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
    public unsafe partial struct PxFixedJoint
    {
        [FieldOffset(0)] public PxJoint Base;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setProjectionLinearTolerance(float tolerance)
        {
            fixed (PxFixedJoint* @this = &this)
            { VirtualMethodTablePointer->setProjectionLinearTolerance(@this, tolerance); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getProjectionLinearTolerance()
        {
            fixed (PxFixedJoint* @this = &this)
            { return VirtualMethodTablePointer->getProjectionLinearTolerance(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setProjectionAngularTolerance(float tolerance)
        {
            fixed (PxFixedJoint* @this = &this)
            { VirtualMethodTablePointer->setProjectionAngularTolerance(@this, tolerance); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getProjectionAngularTolerance()
        {
            fixed (PxFixedJoint* @this = &this)
            { return VirtualMethodTablePointer->getProjectionAngularTolerance(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* getConcreteTypeName()
        {
            fixed (PxFixedJoint* @this = &this)
            { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxFixedJoint@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxFixedJoint* @this, ushort concreteType, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
        {
            fixed (PxFixedJoint* @this = &this)
            { Constructor_PInvoke(@this, concreteType, baseFlags); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxFixedJoint@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxFixedJoint* @this, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxBaseFlags baseFlags)
        {
            fixed (PxFixedJoint* @this = &this)
            { Constructor_PInvoke(@this, baseFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isKindOf(byte* name)
        {
            fixed (PxFixedJoint* @this = &this)
            { return VirtualMethodTablePointer->isKindOf(@this, name); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxFixedJoint*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxBase*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxFixedJoint`</summary>
            public delegate* unmanaged[Cdecl]<PxFixedJoint*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public delegate* unmanaged[Cdecl]<PxFixedJoint*, byte*, NativeBoolean> isKindOf;
            /// <summary>Virtual method pointer for `setActors`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxRigidActor*, PxRigidActor*, void> setActors;
            /// <summary>Virtual method pointer for `getActors`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxRigidActor**, PxRigidActor**, void> getActors;
            /// <summary>Virtual method pointer for `setLocalPose`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxJointActorIndex, PxTransform*, void> setLocalPose;
            /// <summary>Virtual method pointer for `getLocalPose`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxTransform*, PxJointActorIndex, PxTransform*> getLocalPose;
            /// <summary>Virtual method pointer for `getRelativeTransform`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxTransform*, PxTransform*> getRelativeTransform;
            /// <summary>Virtual method pointer for `getRelativeLinearVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxVec3*, PxVec3*> getRelativeLinearVelocity;
            /// <summary>Virtual method pointer for `getRelativeAngularVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxVec3*, PxVec3*> getRelativeAngularVelocity;
            /// <summary>Virtual method pointer for `setBreakForce`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, float, float, void> setBreakForce;
            /// <summary>Virtual method pointer for `getBreakForce`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, float*, float*, void> getBreakForce;
            /// <summary>Virtual method pointer for `setConstraintFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags, void> setConstraintFlags;
            /// <summary>Virtual method pointer for `setConstraintFlag`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags, NativeBoolean, void> setConstraintFlag;
            /// <summary>Virtual method pointer for `getConstraintFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags*, PxConstraintFlags*> getConstraintFlags;
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
            /// <summary>Virtual method pointer for `setProjectionLinearTolerance`</summary>
            public delegate* unmanaged[Cdecl]<PxFixedJoint*, float, void> setProjectionLinearTolerance;
            /// <summary>Virtual method pointer for `getProjectionLinearTolerance`</summary>
            public delegate* unmanaged[Cdecl]<PxFixedJoint*, float> getProjectionLinearTolerance;
            /// <summary>Virtual method pointer for `setProjectionAngularTolerance`</summary>
            public delegate* unmanaged[Cdecl]<PxFixedJoint*, float, void> setProjectionAngularTolerance;
            /// <summary>Virtual method pointer for `getProjectionAngularTolerance`</summary>
            public delegate* unmanaged[Cdecl]<PxFixedJoint*, float> getProjectionAngularTolerance;
        }
    }
}
