// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 2)]
public unsafe partial struct PxDominanceGroupPair
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxDominanceGroupPair@physx@@QEAA@EE@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxDominanceGroupPair* @this, byte a, byte b);

    public unsafe void Constructor(byte a, byte b)
    {
        fixed (PxDominanceGroupPair* @this = &this)
        { Constructor_PInvoke(@this, a, b); }
    }

    [FieldOffset(0)] public byte dominance0;

    [FieldOffset(1)] public byte dominance1;
}
