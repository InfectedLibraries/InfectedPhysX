// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxSphereGeometry
{
    [FieldOffset(0)] public PxGeometry Base;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxSphereGeometry@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxSphereGeometry* @this);

    public unsafe void Constructor()
    {
        fixed (PxSphereGeometry* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxSphereGeometry@physx@@QEAA@M@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxSphereGeometry* @this, float ir);

    public unsafe void Constructor(float ir)
    {
        fixed (PxSphereGeometry* @this = &this)
        { Constructor_PInvoke(@this, ir); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxSphereGeometry@physx@@QEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxSphereGeometry* @this);

    public unsafe bool isValid()
    {
        fixed (PxSphereGeometry* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [FieldOffset(4)] public float radius;
}