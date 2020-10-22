// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxCacheAllocator
{
    public unsafe byte* allocateCacheData(uint byteSize)
    {
        fixed (PxCacheAllocator* @this = &this)
        { return VirtualMethodTablePointer->allocateCacheData(@this, byteSize); }
    }

    public unsafe void Destructor()
    {
        fixed (PxCacheAllocator* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `allocateCacheData`</summary>
        public delegate* unmanaged[Cdecl]<PxCacheAllocator*, uint, byte*> allocateCacheData;
        /// <summary>Virtual method pointer for `~PxCacheAllocator`</summary>
        public delegate* unmanaged[Cdecl]<PxCacheAllocator*, void> __DeletingDestructorPointer;
    }
}
