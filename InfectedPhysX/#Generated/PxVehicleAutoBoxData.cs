// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 256)]
public unsafe partial struct PxVehicleAutoBoxData
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleAutoBoxData@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleAutoBoxData* @this);

    public unsafe void Constructor()
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [FieldOffset(0)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_32 mUpRatios;

    [FieldOffset(128)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_32 mDownRatios;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setLatency@PxVehicleAutoBoxData@physx@@QEAAXM@Z", ExactSpelling = true)]
    private static extern void setLatency_PInvoke(PxVehicleAutoBoxData* @this, float latency);

    public unsafe void setLatency(float latency)
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { setLatency_PInvoke(@this, latency); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getLatency@PxVehicleAutoBoxData@physx@@QEBAMXZ", ExactSpelling = true)]
    private static extern float getLatency_PInvoke(PxVehicleAutoBoxData* @this);

    public unsafe float getLatency()
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { return getLatency_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleAutoBoxData@physx@@AEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxVehicleAutoBoxData* @this);

    public unsafe bool isValid()
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleAutoBoxData@physx@@QEAA@W4PxEMPTY@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleAutoBoxData* @this, PxEMPTY __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter);

    public unsafe void Constructor(PxEMPTY __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter)
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { Constructor_PInvoke(@this, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getUpRatios@PxVehicleAutoBoxData@physx@@QEBAMW4Enum@PxVehicleGearsData@2@@Z", ExactSpelling = true)]
    private static extern float getUpRatios_PInvoke(PxVehicleAutoBoxData* @this, PxVehicleGearsData.Enum a);

    public unsafe float getUpRatios(PxVehicleGearsData.Enum a)
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { return getUpRatios_PInvoke(@this, a); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setUpRatios@PxVehicleAutoBoxData@physx@@QEAAXW4Enum@PxVehicleGearsData@2@M@Z", ExactSpelling = true)]
    private static extern void setUpRatios_PInvoke(PxVehicleAutoBoxData* @this, PxVehicleGearsData.Enum a, float ratio);

    public unsafe void setUpRatios(PxVehicleGearsData.Enum a, float ratio)
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { setUpRatios_PInvoke(@this, a, ratio); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getDownRatios@PxVehicleAutoBoxData@physx@@QEBAMW4Enum@PxVehicleGearsData@2@@Z", ExactSpelling = true)]
    private static extern float getDownRatios_PInvoke(PxVehicleAutoBoxData* @this, PxVehicleGearsData.Enum a);

    public unsafe float getDownRatios(PxVehicleGearsData.Enum a)
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { return getDownRatios_PInvoke(@this, a); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setDownRatios@PxVehicleAutoBoxData@physx@@QEAAXW4Enum@PxVehicleGearsData@2@M@Z", ExactSpelling = true)]
    private static extern void setDownRatios_PInvoke(PxVehicleAutoBoxData* @this, PxVehicleGearsData.Enum a, float ratio);

    public unsafe void setDownRatios(PxVehicleGearsData.Enum a, float ratio)
    {
        fixed (PxVehicleAutoBoxData* @this = &this)
        { setDownRatios_PInvoke(@this, a, ratio); }
    }
}
