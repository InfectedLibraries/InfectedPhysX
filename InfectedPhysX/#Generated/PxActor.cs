// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct PxActor
{
    [FieldOffset(0)] public PxBase Base;

    public unsafe void release()
    {
        fixed (PxActor* @this = &this)
        { VirtualMethodTablePointer->release(@this); }
    }

    public unsafe PxActorType getType()
    {
        fixed (PxActor* @this = &this)
        { return VirtualMethodTablePointer->getType(@this); }
    }

    public unsafe PxScene* getScene()
    {
        fixed (PxActor* @this = &this)
        { return VirtualMethodTablePointer->getScene(@this); }
    }

    public unsafe void setName(byte* name)
    {
        fixed (PxActor* @this = &this)
        { VirtualMethodTablePointer->setName(@this, name); }
    }

    public unsafe byte* getName()
    {
        fixed (PxActor* @this = &this)
        { return VirtualMethodTablePointer->getName(@this); }
    }

    public unsafe PxBounds3 getWorldBounds(float inflation = 1.00999999f)
    {
        fixed (PxActor* @this = &this)
        {
            PxBounds3 __returnBuffer;
            VirtualMethodTablePointer->getWorldBounds(@this, out __returnBuffer, inflation);
            return __returnBuffer;
        }
    }

    public unsafe void setActorFlag(PxActorFlags flag, bool value)
    {
        fixed (PxActor* @this = &this)
        { VirtualMethodTablePointer->setActorFlag(@this, flag, value); }
    }

    public unsafe void setActorFlags(PxActorFlags inFlags)
    {
        fixed (PxActor* @this = &this)
        { VirtualMethodTablePointer->setActorFlags(@this, inFlags); }
    }

    public unsafe PxActorFlags getActorFlags()
    {
        fixed (PxActor* @this = &this)
        { return VirtualMethodTablePointer->getActorFlags(@this); }
    }

    public unsafe void setDominanceGroup(byte dominanceGroup)
    {
        fixed (PxActor* @this = &this)
        { VirtualMethodTablePointer->setDominanceGroup(@this, dominanceGroup); }
    }

    public unsafe byte getDominanceGroup()
    {
        fixed (PxActor* @this = &this)
        { return VirtualMethodTablePointer->getDominanceGroup(@this); }
    }

    public unsafe void setOwnerClient(byte inClient)
    {
        fixed (PxActor* @this = &this)
        { VirtualMethodTablePointer->setOwnerClient(@this, inClient); }
    }

    public unsafe byte getOwnerClient()
    {
        fixed (PxActor* @this = &this)
        { return VirtualMethodTablePointer->getOwnerClient(@this); }
    }

    public unsafe PxAggregate* getAggregate()
    {
        fixed (PxActor* @this = &this)
        { return VirtualMethodTablePointer->getAggregate(@this); }
    }

    [FieldOffset(16)] public void* userData;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxActor@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxActor* @this, ushort concreteType, PxBaseFlags baseFlags);

    public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
    {
        fixed (PxActor* @this = &this)
        { Constructor_PInvoke(@this, concreteType, baseFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxActor@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxActor* @this, PxBaseFlags baseFlags);

    public unsafe void Constructor(PxBaseFlags baseFlags)
    {
        fixed (PxActor* @this = &this)
        { Constructor_PInvoke(@this, baseFlags); }
    }

    public unsafe void Destructor()
    {
        fixed (PxActor* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    public unsafe bool isKindOf(byte* name)
    {
        fixed (PxActor* @this = &this)
        { return VirtualMethodTablePointer->isKindOf(@this, name); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, void> release;
        /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, byte*> getConcreteTypeName;
        /// <summary>Virtual method pointer for `isReleasable`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, bool> isReleasable;
        /// <summary>Virtual method pointer for `~PxActor`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isKindOf`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte*, bool> isKindOf;
        /// <summary>Virtual method pointer for `getType`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxActorType> getType;
        /// <summary>Virtual method pointer for `getScene`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxScene*> getScene;
        /// <summary>Virtual method pointer for `setName`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte*, void> setName;
        /// <summary>Virtual method pointer for `getName`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte*> getName;
        /// <summary>Virtual method pointer for `getWorldBounds`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, out PxBounds3, float, void> getWorldBounds;
        /// <summary>Virtual method pointer for `setActorFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags, bool, void> setActorFlag;
        /// <summary>Virtual method pointer for `setActorFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags, void> setActorFlags;
        /// <summary>Virtual method pointer for `getActorFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxActorFlags> getActorFlags;
        /// <summary>Virtual method pointer for `setDominanceGroup`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte, void> setDominanceGroup;
        /// <summary>Virtual method pointer for `getDominanceGroup`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte> getDominanceGroup;
        /// <summary>Virtual method pointer for `setOwnerClient`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte, void> setOwnerClient;
        /// <summary>Virtual method pointer for `getOwnerClient`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, byte> getOwnerClient;
        /// <summary>Virtual method pointer for `getAggregate`</summary>
        public delegate* unmanaged[Cdecl]<PxActor*, PxAggregate*> getAggregate;
    }
}
