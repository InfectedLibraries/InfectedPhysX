// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 12)]
public unsafe partial struct PxMidphaseDesc
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxMidphaseDesc@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxMidphaseDesc* @this);

    public unsafe void Constructor()
    {
        fixed (PxMidphaseDesc* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getType@PxMidphaseDesc@physx@@QEBA?AW4Enum@PxMeshMidPhase@2@XZ", ExactSpelling = true)]
    private static extern PxMeshMidPhase getType_PInvoke(PxMidphaseDesc* @this);

    public unsafe PxMeshMidPhase getType()
    {
        fixed (PxMidphaseDesc* @this = &this)
        { return getType_PInvoke(@this); }
    }

    [FieldOffset(0)] public PxBVH33MidphaseDesc mBVH33Desc;

    [FieldOffset(0)] public PxBVH34MidphaseDesc mBVH34Desc;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToDefault@PxMidphaseDesc@physx@@QEAAXW4Enum@PxMeshMidPhase@2@@Z", ExactSpelling = true)]
    private static extern void setToDefault_PInvoke(PxMidphaseDesc* @this, PxMeshMidPhase type);

    public unsafe void setToDefault(PxMeshMidPhase type)
    {
        fixed (PxMidphaseDesc* @this = &this)
        { setToDefault_PInvoke(@this, type); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxMidphaseDesc@physx@@QEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxMidphaseDesc* @this);

    public unsafe bool isValid()
    {
        fixed (PxMidphaseDesc* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??4PxMidphaseDesc@physx@@QEAAAEAV01@W4Enum@PxMeshMidPhase@1@@Z", ExactSpelling = true)]
    private static extern PxMidphaseDesc* operator_Equal_PInvoke(PxMidphaseDesc* @this, PxMeshMidPhase descType);

    public unsafe PxMidphaseDesc* operator_Equal(PxMeshMidPhase descType)
    {
        fixed (PxMidphaseDesc* @this = &this)
        { return operator_Equal_PInvoke(@this, descType); }
    }

    [FieldOffset(8)] public PxMeshMidPhase mType;
}