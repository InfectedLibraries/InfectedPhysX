// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct PxDefaultFileOutputStream
{
    [FieldOffset(0)] public PxOutputStream Base;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxDefaultFileOutputStream@physx@@QEAA@PEBD@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxDefaultFileOutputStream* @this, byte* name);

    public unsafe void Constructor(byte* name)
    {
        fixed (PxDefaultFileOutputStream* @this = &this)
        { Constructor_PInvoke(@this, name); }
    }

    public unsafe void Destructor()
    {
        fixed (PxDefaultFileOutputStream* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    public unsafe uint write(void* src, uint count)
    {
        fixed (PxDefaultFileOutputStream* @this = &this)
        { return VirtualMethodTablePointer->write(@this, src, count); }
    }

    public unsafe bool isValid()
    {
        fixed (PxDefaultFileOutputStream* @this = &this)
        { return VirtualMethodTablePointer->isValid(@this); }
    }

    [FieldOffset(8)] public /* Failed to emit TranslatedNormalField mFile: Failed to resolve `Ref resolved by _iobuf` during emit time. */
    int* mFile;


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `write`</summary>
        public delegate* unmanaged[Cdecl]<PxDefaultFileOutputStream*, void*, uint, uint> write;
        /// <summary>Virtual method pointer for `~PxDefaultFileOutputStream`</summary>
        public delegate* unmanaged[Cdecl]<PxDefaultFileOutputStream*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isValid`</summary>
        public delegate* unmanaged[Cdecl]<PxDefaultFileOutputStream*, bool> isValid;
    }
}