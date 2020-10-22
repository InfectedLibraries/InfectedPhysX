// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxCollection
{
    public unsafe void add(PxBase* @object, ulong id = 0)
    {
        fixed (PxCollection* @this = &this)
        { VirtualMethodTablePointer->add_1(@this, @object, id); }
    }

    public unsafe void remove(PxBase* @object)
    {
        fixed (PxCollection* @this = &this)
        { VirtualMethodTablePointer->remove_1(@this, @object); }
    }

    public unsafe bool contains(PxBase* @object)
    {
        fixed (PxCollection* @this = &this)
        { return VirtualMethodTablePointer->contains(@this, @object); }
    }

    public unsafe void addId(PxBase* @object, ulong id)
    {
        fixed (PxCollection* @this = &this)
        { VirtualMethodTablePointer->addId(@this, @object, id); }
    }

    public unsafe void removeId(ulong id)
    {
        fixed (PxCollection* @this = &this)
        { VirtualMethodTablePointer->removeId(@this, id); }
    }

    public unsafe void add(PxCollection* collection)
    {
        fixed (PxCollection* @this = &this)
        { VirtualMethodTablePointer->add_0(@this, collection); }
    }

    public unsafe void remove(PxCollection* collection)
    {
        fixed (PxCollection* @this = &this)
        { VirtualMethodTablePointer->remove_0(@this, collection); }
    }

    public unsafe uint getNbObjects()
    {
        fixed (PxCollection* @this = &this)
        { return VirtualMethodTablePointer->getNbObjects(@this); }
    }

    public unsafe PxBase* getObject(uint index)
    {
        fixed (PxCollection* @this = &this)
        { return VirtualMethodTablePointer->getObject(@this, index); }
    }

    public unsafe uint getObjects(PxBase** userBuffer, uint bufferSize, uint startIndex = 0)
    {
        fixed (PxCollection* @this = &this)
        { return VirtualMethodTablePointer->getObjects(@this, userBuffer, bufferSize, startIndex); }
    }

    public unsafe PxBase* find(ulong id)
    {
        fixed (PxCollection* @this = &this)
        { return VirtualMethodTablePointer->find(@this, id); }
    }

    public unsafe uint getNbIds()
    {
        fixed (PxCollection* @this = &this)
        { return VirtualMethodTablePointer->getNbIds(@this); }
    }

    public unsafe uint getIds(ulong* userBuffer, uint bufferSize, uint startIndex = 0)
    {
        fixed (PxCollection* @this = &this)
        { return VirtualMethodTablePointer->getIds(@this, userBuffer, bufferSize, startIndex); }
    }

    public unsafe ulong getId(PxBase* @object)
    {
        fixed (PxCollection* @this = &this)
        { return VirtualMethodTablePointer->getId(@this, @object); }
    }

    public unsafe void release()
    {
        fixed (PxCollection* @this = &this)
        { VirtualMethodTablePointer->release(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxCollection@physx@@IEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxCollection* @this);

    public unsafe void Constructor()
    {
        fixed (PxCollection* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    public unsafe void Destructor()
    {
        fixed (PxCollection* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCreateCollection@@YAPEAVPxCollection@physx@@XZ", ExactSpelling = true)]
    public static extern PxCollection* PxCreateCollection();


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `add`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, PxCollection*, void> add_0;
        /// <summary>Virtual method pointer for `add`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, PxBase*, ulong, void> add_1;
        /// <summary>Virtual method pointer for `remove`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, PxCollection*, void> remove_0;
        /// <summary>Virtual method pointer for `remove`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, PxBase*, void> remove_1;
        /// <summary>Virtual method pointer for `contains`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, PxBase*, bool> contains;
        /// <summary>Virtual method pointer for `addId`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, PxBase*, ulong, void> addId;
        /// <summary>Virtual method pointer for `removeId`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, ulong, void> removeId;
        /// <summary>Virtual method pointer for `getNbObjects`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, uint> getNbObjects;
        /// <summary>Virtual method pointer for `getObject`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, uint, PxBase*> getObject;
        /// <summary>Virtual method pointer for `getObjects`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, PxBase**, uint, uint, uint> getObjects;
        /// <summary>Virtual method pointer for `find`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, ulong, PxBase*> find;
        /// <summary>Virtual method pointer for `getNbIds`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, uint> getNbIds;
        /// <summary>Virtual method pointer for `getIds`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, ulong*, uint, uint, uint> getIds;
        /// <summary>Virtual method pointer for `getId`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, PxBase*, ulong> getId;
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, void> release;
        /// <summary>Virtual method pointer for `~PxCollection`</summary>
        public delegate* unmanaged[Cdecl]<PxCollection*, void> __DeletingDestructorPointer;
    }
}
