// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxInputStream
{
    public unsafe uint read(void* dest, uint count)
    {
        fixed (PxInputStream* @this = &this)
        { return VirtualMethodTablePointer->read(@this, dest, count); }
    }

    public unsafe void Destructor()
    {
        fixed (PxInputStream* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `read`</summary>
        public delegate* unmanaged[Cdecl]<PxInputStream*, void*, uint, uint> read;
        /// <summary>Virtual method pointer for `~PxInputStream`</summary>
        public delegate* unmanaged[Cdecl]<PxInputStream*, void> __DeletingDestructorPointer;
    }
}