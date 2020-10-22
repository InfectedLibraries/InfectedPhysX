// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct PxVehicleClutchData
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleClutchData@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleClutchData* @this);

    public unsafe void Constructor()
    {
        fixed (PxVehicleClutchData* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [FieldOffset(0)] public float mStrength;

    [FieldOffset(4)] public PxVehicleClutchAccuracyMode mAccuracyMode;

    [FieldOffset(8)] public uint mEstimateIterations;

    [FieldOffset(12)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU8_4 mPad;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleClutchData@physx@@AEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxVehicleClutchData* @this);

    public unsafe bool isValid()
    {
        fixed (PxVehicleClutchData* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleClutchData@physx@@QEAA@W4PxEMPTY@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleClutchData* @this, PxEMPTY __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter);

    public unsafe void Constructor(PxEMPTY __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter)
    {
        fixed (PxVehicleClutchData* @this = &this)
        { Constructor_PInvoke(@this, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter); }
    }
}