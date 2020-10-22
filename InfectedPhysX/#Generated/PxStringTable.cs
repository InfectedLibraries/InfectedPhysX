// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxStringTable
{
    public unsafe void Destructor()
    {
        fixed (PxStringTable* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    public unsafe byte* allocateStr(byte* inSrc)
    {
        fixed (PxStringTable* @this = &this)
        { return VirtualMethodTablePointer->allocateStr(@this, inSrc); }
    }

    public unsafe void release()
    {
        fixed (PxStringTable* @this = &this)
        { VirtualMethodTablePointer->release(@this); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `~PxStringTable`</summary>
        public delegate* unmanaged[Cdecl]<PxStringTable*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `allocateStr`</summary>
        public delegate* unmanaged[Cdecl]<PxStringTable*, byte*, byte*> allocateStr;
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxStringTable*, void> release;
    }
}
