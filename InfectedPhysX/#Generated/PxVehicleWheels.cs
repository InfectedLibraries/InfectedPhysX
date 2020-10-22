// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.ComponentModel;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 192)]
public unsafe partial struct PxVehicleWheels
{
    [FieldOffset(0)] public PxBase Base;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getVehicleType@PxVehicleWheels@physx@@QEBAIXZ", ExactSpelling = true)]
    private static extern uint getVehicleType_PInvoke(PxVehicleWheels* @this);

    public unsafe uint getVehicleType()
    {
        fixed (PxVehicleWheels* @this = &this)
        { return getVehicleType_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getRigidDynamicActor@PxVehicleWheels@physx@@QEAAPEAVPxRigidDynamic@2@XZ", ExactSpelling = true)]
    private static extern PxRigidDynamic* getRigidDynamicActor_PInvoke(PxVehicleWheels* @this);

    public unsafe PxRigidDynamic* getRigidDynamicActor()
    {
        fixed (PxVehicleWheels* @this = &this)
        { return getRigidDynamicActor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getRigidDynamicActor@PxVehicleWheels@physx@@QEBAPEBVPxRigidDynamic@2@XZ", ExactSpelling = true)]
    private static extern PxRigidDynamic* getRigidDynamicActor_Const_PInvoke(PxVehicleWheels* @this);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe PxRigidDynamic* getRigidDynamicActor_Const()
    {
        fixed (PxVehicleWheels* @this = &this)
        { return getRigidDynamicActor_Const_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?computeForwardSpeed@PxVehicleWheels@physx@@QEBAMXZ", ExactSpelling = true)]
    private static extern float computeForwardSpeed_PInvoke(PxVehicleWheels* @this);

    public unsafe float computeForwardSpeed()
    {
        fixed (PxVehicleWheels* @this = &this)
        { return computeForwardSpeed_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?computeSidewaysSpeed@PxVehicleWheels@physx@@QEBAMXZ", ExactSpelling = true)]
    private static extern float computeSidewaysSpeed_PInvoke(PxVehicleWheels* @this);

    public unsafe float computeSidewaysSpeed()
    {
        fixed (PxVehicleWheels* @this = &this)
        { return computeSidewaysSpeed_PInvoke(@this); }
    }

    [FieldOffset(16)] public PxVehicleWheelsSimData mWheelsSimData;

    [FieldOffset(112)] public PxVehicleWheelsDynData mWheelsDynData;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToRestState@PxVehicleWheels@physx@@IEAAXXZ", ExactSpelling = true)]
    private static extern void setToRestState_PInvoke(PxVehicleWheels* @this);

    public unsafe void setToRestState()
    {
        fixed (PxVehicleWheels* @this = &this)
        { setToRestState_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleWheels@physx@@IEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxVehicleWheels* @this);

    public unsafe bool isValid()
    {
        fixed (PxVehicleWheels* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?computeByteSize@PxVehicleWheels@physx@@KAII@Z", ExactSpelling = true)]
    public static extern uint computeByteSize(uint nbWheels);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?patchupPointers@PxVehicleWheels@physx@@KAPEAEIPEAV12@PEAE@Z", ExactSpelling = true)]
    public static extern byte* patchupPointers(uint nbWheels, PxVehicleWheels* vehWheels, byte* ptr);

    public unsafe void init(uint numWheels)
    {
        fixed (PxVehicleWheels* @this = &this)
        { VirtualMethodTablePointer->init(@this, numWheels); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?free@PxVehicleWheels@physx@@IEAAXXZ", ExactSpelling = true)]
    private static extern void free_PInvoke(PxVehicleWheels* @this);

    public unsafe void free()
    {
        fixed (PxVehicleWheels* @this = &this)
        { free_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?onConstraintRelease@PxVehicleWheels@physx@@IEAAXXZ", ExactSpelling = true)]
    private static extern void onConstraintRelease_PInvoke(PxVehicleWheels* @this);

    public unsafe void onConstraintRelease()
    {
        fixed (PxVehicleWheels* @this = &this)
        { onConstraintRelease_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setup@PxVehicleWheels@physx@@IEAAXPEAVPxPhysics@2@PEAVPxRigidDynamic@2@AEBVPxVehicleWheelsSimData@2@II@Z", ExactSpelling = true)]
    private static extern void setup_PInvoke(PxVehicleWheels* @this, PxPhysics* physics, PxRigidDynamic* vehActor, PxVehicleWheelsSimData* wheelsData, uint nbDrivenWheels, uint nbNonDrivenWheels);

    public unsafe void setup(PxPhysics* physics, PxRigidDynamic* vehActor, PxVehicleWheelsSimData* wheelsData, uint nbDrivenWheels, uint nbNonDrivenWheels)
    {
        fixed (PxVehicleWheels* @this = &this)
        { setup_PInvoke(@this, physics, vehActor, wheelsData, nbDrivenWheels, nbNonDrivenWheels); }
    }

    [FieldOffset(160)] public PxRigidDynamic* mActor;

    [FieldOffset(168)] public uint mNbNonDrivenWheels;

    [FieldOffset(172)] public byte mOnConstraintReleaseCounter;

    [FieldOffset(173)] public byte mType;

    [FieldOffset(174)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU8_14 mPad0;

    public unsafe void requiresObjects(PxProcessPxBaseCallback* c)
    {
        fixed (PxVehicleWheels* @this = &this)
        { VirtualMethodTablePointer->requiresObjects(@this, c); }
    }

    public unsafe byte* getConcreteTypeName()
    {
        fixed (PxVehicleWheels* @this = &this)
        { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
    }

    public unsafe bool isKindOf(byte* name)
    {
        fixed (PxVehicleWheels* @this = &this)
        { return VirtualMethodTablePointer->isKindOf(@this, name); }
    }

    public unsafe void preExportDataReset()
    {
        fixed (PxVehicleWheels* @this = &this)
        { VirtualMethodTablePointer->preExportDataReset(@this); }
    }

    public unsafe void exportExtraData(PxSerializationContext* __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter)
    {
        fixed (PxVehicleWheels* @this = &this)
        { VirtualMethodTablePointer->exportExtraData(@this, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?importExtraData@PxVehicleWheels@physx@@QEAAXAEAVPxDeserializationContext@2@@Z", ExactSpelling = true)]
    private static extern void importExtraData_PInvoke(PxVehicleWheels* @this, PxDeserializationContext* __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter);

    public unsafe void importExtraData(PxDeserializationContext* __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter)
    {
        fixed (PxVehicleWheels* @this = &this)
        { importExtraData_PInvoke(@this, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?resolveReferences@PxVehicleWheels@physx@@QEAAXAEAVPxDeserializationContext@2@@Z", ExactSpelling = true)]
    private static extern void resolveReferences_PInvoke(PxVehicleWheels* @this, PxDeserializationContext* __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter);

    public unsafe void resolveReferences(PxDeserializationContext* __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter)
    {
        fixed (PxVehicleWheels* @this = &this)
        { resolveReferences_PInvoke(@this, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBinaryMetaData@PxVehicleWheels@physx@@SAXAEAVPxOutputStream@2@@Z", ExactSpelling = true)]
    public static extern void getBinaryMetaData(PxOutputStream* stream);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getNbNonDrivenWheels@PxVehicleWheels@physx@@QEBAIXZ", ExactSpelling = true)]
    private static extern uint getNbNonDrivenWheels_PInvoke(PxVehicleWheels* @this);

    public unsafe uint getNbNonDrivenWheels()
    {
        fixed (PxVehicleWheels* @this = &this)
        { return getNbNonDrivenWheels_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleWheels@physx@@QEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleWheels* @this, ushort concreteType, PxBaseFlags baseFlags);

    public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
    {
        fixed (PxVehicleWheels* @this = &this)
        { Constructor_PInvoke(@this, concreteType, baseFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleWheels@physx@@QEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleWheels* @this, PxBaseFlags baseFlags);

    public unsafe void Constructor(PxBaseFlags baseFlags)
    {
        fixed (PxVehicleWheels* @this = &this)
        { Constructor_PInvoke(@this, baseFlags); }
    }

    public unsafe void Destructor()
    {
        fixed (PxVehicleWheels* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    public unsafe void release()
    {
        fixed (PxVehicleWheels* @this = &this)
        { VirtualMethodTablePointer->release(@this); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxVehicleWheels*, void> release;
        /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
        public delegate* unmanaged[Cdecl]<PxVehicleWheels*, byte*> getConcreteTypeName;
        /// <summary>Virtual method pointer for `isReleasable`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, bool> isReleasable;
        /// <summary>Virtual method pointer for `~PxVehicleWheels`</summary>
        public delegate* unmanaged[Cdecl]<PxVehicleWheels*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isKindOf`</summary>
        public delegate* unmanaged[Cdecl]<PxVehicleWheels*, byte*, bool> isKindOf;
        /// <summary>Virtual method pointer for `init`</summary>
        public delegate* unmanaged[Cdecl]<PxVehicleWheels*, uint, void> init;
        /// <summary>Virtual method pointer for `requiresObjects`</summary>
        public delegate* unmanaged[Cdecl]<PxVehicleWheels*, PxProcessPxBaseCallback*, void> requiresObjects;
        /// <summary>Virtual method pointer for `preExportDataReset`</summary>
        public delegate* unmanaged[Cdecl]<PxVehicleWheels*, void> preExportDataReset;
        /// <summary>Virtual method pointer for `exportExtraData`</summary>
        public delegate* unmanaged[Cdecl]<PxVehicleWheels*, PxSerializationContext*, void> exportExtraData;
    }
}