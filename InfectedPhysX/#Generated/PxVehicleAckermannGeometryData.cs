// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct PxVehicleAckermannGeometryData
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleAckermannGeometryData@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleAckermannGeometryData* @this);

    public unsafe void Constructor()
    {
        fixed (PxVehicleAckermannGeometryData* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [FieldOffset(0)] public float mAccuracy;

    [FieldOffset(4)] public float mFrontWidth;

    [FieldOffset(8)] public float mRearWidth;

    [FieldOffset(12)] public float mAxleSeparation;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleAckermannGeometryData@physx@@AEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxVehicleAckermannGeometryData* @this);

    public unsafe bool isValid()
    {
        fixed (PxVehicleAckermannGeometryData* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleAckermannGeometryData@physx@@QEAA@W4PxEMPTY@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleAckermannGeometryData* @this, PxEMPTY __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter);

    public unsafe void Constructor(PxEMPTY __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter)
    {
        fixed (PxVehicleAckermannGeometryData* @this = &this)
        { Constructor_PInvoke(@this, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter); }
    }
}