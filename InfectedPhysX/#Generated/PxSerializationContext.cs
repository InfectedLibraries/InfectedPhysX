// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxSerializationContext
{
    public unsafe void registerReference(PxBase* @base, uint kind, ulong reference)
    {
        fixed (PxSerializationContext* @this = &this)
        { VirtualMethodTablePointer->registerReference(@this, @base, kind, reference); }
    }

    public unsafe PxCollection* getCollection()
    {
        fixed (PxSerializationContext* @this = &this)
        { return VirtualMethodTablePointer->getCollection(@this); }
    }

    public unsafe void writeData(void* data, uint size)
    {
        fixed (PxSerializationContext* @this = &this)
        { VirtualMethodTablePointer->writeData(@this, data, size); }
    }

    public unsafe void alignData(uint alignment = 16)
    {
        fixed (PxSerializationContext* @this = &this)
        { VirtualMethodTablePointer->alignData(@this, alignment); }
    }

    public unsafe void writeName(byte* name)
    {
        fixed (PxSerializationContext* @this = &this)
        { VirtualMethodTablePointer->writeName(@this, name); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxSerializationContext@physx@@IEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxSerializationContext* @this);

    public unsafe void Constructor()
    {
        fixed (PxSerializationContext* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    public unsafe void Destructor()
    {
        fixed (PxSerializationContext* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `registerReference`</summary>
        public delegate* unmanaged[Cdecl]<PxSerializationContext*, PxBase*, uint, ulong, void> registerReference;
        /// <summary>Virtual method pointer for `getCollection`</summary>
        public delegate* unmanaged[Cdecl]<PxSerializationContext*, PxCollection*> getCollection;
        /// <summary>Virtual method pointer for `writeData`</summary>
        public delegate* unmanaged[Cdecl]<PxSerializationContext*, void*, uint, void> writeData;
        /// <summary>Virtual method pointer for `alignData`</summary>
        public delegate* unmanaged[Cdecl]<PxSerializationContext*, uint, void> alignData;
        /// <summary>Virtual method pointer for `writeName`</summary>
        public delegate* unmanaged[Cdecl]<PxSerializationContext*, byte*, void> writeName;
        /// <summary>Virtual method pointer for `~PxSerializationContext`</summary>
        public delegate* unmanaged[Cdecl]<PxSerializationContext*, void> __DeletingDestructorPointer;
    }
}