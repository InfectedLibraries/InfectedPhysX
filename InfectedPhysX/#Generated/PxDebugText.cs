// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct PxDebugText
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxDebugText@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxDebugText* @this);

    public unsafe void Constructor()
    {
        fixed (PxDebugText* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxDebugText@physx@@QEAA@AEBVPxVec3@1@AEBMAEBIPEBD@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxDebugText* @this, PxVec3* p, float* s, uint* c, byte* str);

    public unsafe void Constructor(PxVec3* p, float* s, uint* c, byte* str)
    {
        fixed (PxDebugText* @this = &this)
        { Constructor_PInvoke(@this, p, s, c, str); }
    }

    [FieldOffset(0)] public PxVec3 position;

    [FieldOffset(12)] public float size;

    [FieldOffset(16)] public uint color;

    [FieldOffset(24)] public byte* @string;
}
