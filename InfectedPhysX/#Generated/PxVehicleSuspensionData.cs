// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 48)]
public unsafe partial struct PxVehicleSuspensionData
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleSuspensionData@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleSuspensionData* @this);

    public unsafe void Constructor()
    {
        fixed (PxVehicleSuspensionData* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [FieldOffset(0)] public float mSpringStrength;

    [FieldOffset(4)] public float mSpringDamperRate;

    [FieldOffset(8)] public float mMaxCompression;

    [FieldOffset(12)] public float mMaxDroop;

    [FieldOffset(16)] public float mSprungMass;

    [FieldOffset(20)] public float mCamberAtRest;

    [FieldOffset(24)] public float mCamberAtMaxCompression;

    [FieldOffset(28)] public float mCamberAtMaxDroop;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getRecipMaxCompression@PxVehicleSuspensionData@physx@@QEBAMXZ", ExactSpelling = true)]
    private static extern float getRecipMaxCompression_PInvoke(PxVehicleSuspensionData* @this);

    public unsafe float getRecipMaxCompression()
    {
        fixed (PxVehicleSuspensionData* @this = &this)
        { return getRecipMaxCompression_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getRecipMaxDroop@PxVehicleSuspensionData@physx@@QEBAMXZ", ExactSpelling = true)]
    private static extern float getRecipMaxDroop_PInvoke(PxVehicleSuspensionData* @this);

    public unsafe float getRecipMaxDroop()
    {
        fixed (PxVehicleSuspensionData* @this = &this)
        { return getRecipMaxDroop_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setMassAndPreserveNaturalFrequency@PxVehicleSuspensionData@physx@@QEAAXM@Z", ExactSpelling = true)]
    private static extern void setMassAndPreserveNaturalFrequency_PInvoke(PxVehicleSuspensionData* @this, float newSprungMass);

    public unsafe void setMassAndPreserveNaturalFrequency(float newSprungMass)
    {
        fixed (PxVehicleSuspensionData* @this = &this)
        { setMassAndPreserveNaturalFrequency_PInvoke(@this, newSprungMass); }
    }

    [FieldOffset(32)] public float mRecipMaxCompression;

    [FieldOffset(36)] public float mRecipMaxDroop;

    [FieldOffset(40)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_2 mPad;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleSuspensionData@physx@@AEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxVehicleSuspensionData* @this);

    public unsafe bool isValid()
    {
        fixed (PxVehicleSuspensionData* @this = &this)
        { return isValid_PInvoke(@this); }
    }
}
