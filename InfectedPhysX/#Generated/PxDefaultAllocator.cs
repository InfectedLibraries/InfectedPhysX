// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxDefaultAllocator
{
    [FieldOffset(0)] public PxAllocatorCallback Base;

    public unsafe void* allocate(ulong size, byte* __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter_0, byte* __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter_1, int __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter_2)
    {
        fixed (PxDefaultAllocator* @this = &this)
        { return VirtualMethodTablePointer->allocate(@this, size, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter_0, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter_1, __UNICODE_003C____UNICODE_003E__UnnamedTranslatedParameter_2); }
    }

    public unsafe void deallocate(void* ptr)
    {
        fixed (PxDefaultAllocator* @this = &this)
        { VirtualMethodTablePointer->deallocate(@this, ptr); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?platformAlignedAlloc@physx@@YAPEAX_K@Z", ExactSpelling = true)]
    public static extern void* platformAlignedAlloc(ulong size);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?platformAlignedFree@physx@@YAXPEAX@Z", ExactSpelling = true)]
    public static extern void platformAlignedFree(void* ptr);


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `~PxDefaultAllocator`</summary>
        public delegate* unmanaged[Cdecl]<PxDefaultAllocator*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `allocate`</summary>
        public delegate* unmanaged[Cdecl]<PxDefaultAllocator*, ulong, byte*, byte*, int, void*> allocate;
        /// <summary>Virtual method pointer for `deallocate`</summary>
        public delegate* unmanaged[Cdecl]<PxDefaultAllocator*, void*, void> deallocate;
    }
}