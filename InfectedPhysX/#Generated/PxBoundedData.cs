// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct PxBoundedData
{
    [FieldOffset(0)] public PxStridedData Base;

    [FieldOffset(16)] public uint count;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxBoundedData@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxBoundedData* @this);

    public unsafe void Constructor()
    {
        fixed (PxBoundedData* @this = &this)
        { Constructor_PInvoke(@this); }
    }
}