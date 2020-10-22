// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 40)]
public unsafe partial struct PxHeightFieldDesc
{
    [FieldOffset(0)] public uint nbRows;

    [FieldOffset(4)] public uint nbColumns;

    [FieldOffset(8)] public PxHeightFieldFormat format;

    [FieldOffset(16)] public PxStridedData samples;

    [FieldOffset(32)] public float convexEdgeThreshold;

    [FieldOffset(36)] public PxHeightFieldFlags flags;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxHeightFieldDesc@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxHeightFieldDesc* @this);

    public unsafe void Constructor()
    {
        fixed (PxHeightFieldDesc* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToDefault@PxHeightFieldDesc@physx@@QEAAXXZ", ExactSpelling = true)]
    private static extern void setToDefault_PInvoke(PxHeightFieldDesc* @this);

    public unsafe void setToDefault()
    {
        fixed (PxHeightFieldDesc* @this = &this)
        { setToDefault_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxHeightFieldDesc@physx@@QEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxHeightFieldDesc* @this);

    public unsafe bool isValid()
    {
        fixed (PxHeightFieldDesc* @this = &this)
        { return isValid_PInvoke(@this); }
    }
}