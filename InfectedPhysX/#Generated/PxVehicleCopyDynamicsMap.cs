// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 40)]
public unsafe partial struct PxVehicleCopyDynamicsMap
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleCopyDynamicsMap@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleCopyDynamicsMap* @this);

    public unsafe void Constructor()
    {
        fixed (PxVehicleCopyDynamicsMap* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [FieldOffset(0)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU8_20 sourceWheelIds;

    [FieldOffset(20)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU8_20 targetWheelIds;
}
