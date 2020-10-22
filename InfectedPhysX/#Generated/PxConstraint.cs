// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct PxConstraint
{
    [FieldOffset(0)] public PxBase Base;

    public unsafe void release()
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->release(@this); }
    }

    public unsafe PxScene* getScene()
    {
        fixed (PxConstraint* @this = &this)
        { return VirtualMethodTablePointer->getScene(@this); }
    }

    public unsafe void getActors(PxRigidActor** actor0, PxRigidActor** actor1)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->getActors(@this, actor0, actor1); }
    }

    public unsafe void setActors(PxRigidActor* actor0, PxRigidActor* actor1)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->setActors(@this, actor0, actor1); }
    }

    public unsafe void markDirty()
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->markDirty(@this); }
    }

    public unsafe void setFlags(PxConstraintFlags flags)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->setFlags(@this, flags); }
    }

    public unsafe PxConstraintFlags getFlags()
    {
        fixed (PxConstraint* @this = &this)
        { return VirtualMethodTablePointer->getFlags(@this); }
    }

    public unsafe void setFlag(PxConstraintFlags flag, bool value)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->setFlag(@this, flag, value); }
    }

    public unsafe void getForce(PxVec3* linear, PxVec3* angular)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->getForce(@this, linear, angular); }
    }

    public unsafe bool isValid()
    {
        fixed (PxConstraint* @this = &this)
        { return VirtualMethodTablePointer->isValid(@this); }
    }

    public unsafe void setBreakForce(float linear, float angular)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->setBreakForce(@this, linear, angular); }
    }

    public unsafe void getBreakForce(float* linear, float* angular)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->getBreakForce(@this, linear, angular); }
    }

    public unsafe void setMinResponseThreshold(float threshold)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->setMinResponseThreshold(@this, threshold); }
    }

    public unsafe float getMinResponseThreshold()
    {
        fixed (PxConstraint* @this = &this)
        { return VirtualMethodTablePointer->getMinResponseThreshold(@this); }
    }

    public unsafe void* getExternalReference(uint* typeID)
    {
        fixed (PxConstraint* @this = &this)
        { return VirtualMethodTablePointer->getExternalReference(@this, typeID); }
    }

    public unsafe void setConstraintFunctions(PxConstraintConnector* connector, PxConstraintShaderTable* shaders)
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->setConstraintFunctions(@this, connector, shaders); }
    }

    public unsafe byte* getConcreteTypeName()
    {
        fixed (PxConstraint* @this = &this)
        { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxConstraint@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxConstraint* @this, ushort concreteType, PxBaseFlags baseFlags);

    public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
    {
        fixed (PxConstraint* @this = &this)
        { Constructor_PInvoke(@this, concreteType, baseFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxConstraint@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxConstraint* @this, PxBaseFlags baseFlags);

    public unsafe void Constructor(PxBaseFlags baseFlags)
    {
        fixed (PxConstraint* @this = &this)
        { Constructor_PInvoke(@this, baseFlags); }
    }

    public unsafe void Destructor()
    {
        fixed (PxConstraint* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    public unsafe bool isKindOf(byte* name)
    {
        fixed (PxConstraint* @this = &this)
        { return VirtualMethodTablePointer->isKindOf(@this, name); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, void> release;
        /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, byte*> getConcreteTypeName;
        /// <summary>Virtual method pointer for `isReleasable`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, bool> isReleasable;
        /// <summary>Virtual method pointer for `~PxConstraint`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isKindOf`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, byte*, bool> isKindOf;
        /// <summary>Virtual method pointer for `getScene`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, PxScene*> getScene;
        /// <summary>Virtual method pointer for `getActors`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, PxRigidActor**, PxRigidActor**, void> getActors;
        /// <summary>Virtual method pointer for `setActors`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, PxRigidActor*, PxRigidActor*, void> setActors;
        /// <summary>Virtual method pointer for `markDirty`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, void> markDirty;
        /// <summary>Virtual method pointer for `setFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, PxConstraintFlags, void> setFlags;
        /// <summary>Virtual method pointer for `getFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, PxConstraintFlags> getFlags;
        /// <summary>Virtual method pointer for `setFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, PxConstraintFlags, bool, void> setFlag;
        /// <summary>Virtual method pointer for `getForce`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, PxVec3*, PxVec3*, void> getForce;
        /// <summary>Virtual method pointer for `isValid`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, bool> isValid;
        /// <summary>Virtual method pointer for `setBreakForce`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, float, float, void> setBreakForce;
        /// <summary>Virtual method pointer for `getBreakForce`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, float*, float*, void> getBreakForce;
        /// <summary>Virtual method pointer for `setMinResponseThreshold`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, float, void> setMinResponseThreshold;
        /// <summary>Virtual method pointer for `getMinResponseThreshold`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, float> getMinResponseThreshold;
        /// <summary>Virtual method pointer for `getExternalReference`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, uint*, void*> getExternalReference;
        /// <summary>Virtual method pointer for `setConstraintFunctions`</summary>
        public delegate* unmanaged[Cdecl]<PxConstraint*, PxConstraintConnector*, PxConstraintShaderTable*, void> setConstraintFunctions;
    }
}