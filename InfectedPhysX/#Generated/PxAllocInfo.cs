// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct PxAllocInfo
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxAllocInfo@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxAllocInfo* @this);

    public unsafe void Constructor()
    {
        fixed (PxAllocInfo* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxAllocInfo@physx@@QEAA@PEBDH0W4Enum@PxAllocId@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxAllocInfo* @this, byte* file, int line, byte* allocName, PxAllocId allocId);

    public unsafe void Constructor(byte* file, int line, byte* allocName, PxAllocId allocId)
    {
        fixed (PxAllocInfo* @this = &this)
        { Constructor_PInvoke(@this, file, line, allocName, allocId); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getFileName@PxAllocInfo@physx@@QEBAPEBDXZ", ExactSpelling = true)]
    private static extern byte* getFileName_PInvoke(PxAllocInfo* @this);

    public unsafe byte* getFileName()
    {
        fixed (PxAllocInfo* @this = &this)
        { return getFileName_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getLine@PxAllocInfo@physx@@QEBAHXZ", ExactSpelling = true)]
    private static extern int getLine_PInvoke(PxAllocInfo* @this);

    public unsafe int getLine()
    {
        fixed (PxAllocInfo* @this = &this)
        { return getLine_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAllocName@PxAllocInfo@physx@@QEBAPEBDXZ", ExactSpelling = true)]
    private static extern byte* getAllocName_PInvoke(PxAllocInfo* @this);

    public unsafe byte* getAllocName()
    {
        fixed (PxAllocInfo* @this = &this)
        { return getAllocName_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAllocId@PxAllocInfo@physx@@QEBA?AW4Enum@PxAllocId@2@XZ", ExactSpelling = true)]
    private static extern PxAllocId getAllocId_PInvoke(PxAllocInfo* @this);

    public unsafe PxAllocId getAllocId()
    {
        fixed (PxAllocInfo* @this = &this)
        { return getAllocId_PInvoke(@this); }
    }

    [FieldOffset(0)] public byte* mFileName;

    [FieldOffset(8)] public int mLine;

    [FieldOffset(16)] public byte* mAllocName;

    [FieldOffset(24)] public PxAllocId mAllocId;
}
