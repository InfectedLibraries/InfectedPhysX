// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 20)]
public unsafe partial struct PxQueryFilterData
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxQueryFilterData@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxQueryFilterData* @this);

    public unsafe void Constructor()
    {
        fixed (PxQueryFilterData* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxQueryFilterData@physx@@QEAA@AEBUPxFilterData@1@V?$PxFlags@W4Enum@PxQueryFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxQueryFilterData* @this, PxFilterData* fd, PxQueryFlags f);

    public unsafe void Constructor(PxFilterData* fd, PxQueryFlags f)
    {
        fixed (PxQueryFilterData* @this = &this)
        { Constructor_PInvoke(@this, fd, f); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxQueryFilterData@physx@@QEAA@V?$PxFlags@W4Enum@PxQueryFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxQueryFilterData* @this, PxQueryFlags f);

    public unsafe void Constructor(PxQueryFlags f)
    {
        fixed (PxQueryFilterData* @this = &this)
        { Constructor_PInvoke(@this, f); }
    }

    [FieldOffset(0)] public PxFilterData data;

    [FieldOffset(16)] public PxQueryFlags flags;
}