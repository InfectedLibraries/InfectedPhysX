// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 360)]
public unsafe partial struct PxFeatherstoneArticulationLinkData
{
    [FieldOffset(0)] public PxMutableLinkData Base;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxFeatherstoneArticulationLinkData@immediate@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxFeatherstoneArticulationLinkData* @this);

    public unsafe void Constructor()
    {
        fixed (PxFeatherstoneArticulationLinkData* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?initData@PxFeatherstoneArticulationLinkData@immediate@physx@@QEAAXXZ", ExactSpelling = true)]
    private static extern void initData_PInvoke(PxFeatherstoneArticulationLinkData* @this);

    public unsafe void initData()
    {
        fixed (PxFeatherstoneArticulationLinkData* @this = &this)
        { initData_PInvoke(@this); }
    }

    [FieldOffset(36)] public PxFeatherstoneArticulationJointData inboundJoint;

    [FieldOffset(320)] public PxTransform pose;

    [FieldOffset(352)] public ulong parent;
}
