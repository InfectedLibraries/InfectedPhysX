// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct PxHeightFieldGeometry
{
    [FieldOffset(0)] public PxGeometry Base;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxHeightFieldGeometry@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxHeightFieldGeometry* @this);

    public unsafe void Constructor()
    {
        fixed (PxHeightFieldGeometry* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxHeightFieldGeometry@physx@@QEAA@PEAVPxHeightField@1@V?$PxFlags@W4Enum@PxMeshGeometryFlag@physx@@E@1@MMM@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxHeightFieldGeometry* @this, PxHeightField* hf, PxMeshGeometryFlags flags, float heightScale_, float rowScale_, float columnScale_);

    public unsafe void Constructor(PxHeightField* hf, PxMeshGeometryFlags flags, float heightScale_, float rowScale_, float columnScale_)
    {
        fixed (PxHeightFieldGeometry* @this = &this)
        { Constructor_PInvoke(@this, hf, flags, heightScale_, rowScale_, columnScale_); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxHeightFieldGeometry@physx@@QEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxHeightFieldGeometry* @this);

    public unsafe bool isValid()
    {
        fixed (PxHeightFieldGeometry* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [FieldOffset(8)] public PxHeightField* heightField;

    [FieldOffset(16)] public float heightScale;

    [FieldOffset(20)] public float rowScale;

    [FieldOffset(24)] public float columnScale;

    [FieldOffset(28)] public PxMeshGeometryFlags heightFieldFlags;
}
