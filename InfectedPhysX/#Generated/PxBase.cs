// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct PxBase
{
    public unsafe void release()
    {
        fixed (PxBase* @this = &this)
        { VirtualMethodTablePointer->release(@this); }
    }

    public unsafe byte* getConcreteTypeName()
    {
        fixed (PxBase* @this = &this)
        { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getConcreteType@PxBase@physx@@QEBAGXZ", ExactSpelling = true)]
    private static extern ushort getConcreteType_PInvoke(PxBase* @this);

    public unsafe ushort getConcreteType()
    {
        fixed (PxBase* @this = &this)
        { return getConcreteType_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setBaseFlag@PxBase@physx@@QEAAXW4Enum@PxBaseFlag@2@_N@Z", ExactSpelling = true)]
    private static extern void setBaseFlag_PInvoke(PxBase* @this, PxBaseFlags flag, bool value);

    public unsafe void setBaseFlag(PxBaseFlags flag, bool value)
    {
        fixed (PxBase* @this = &this)
        { setBaseFlag_PInvoke(@this, flag, value); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setBaseFlags@PxBase@physx@@QEAAXV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@2@@Z", ExactSpelling = true)]
    private static extern void setBaseFlags_PInvoke(PxBase* @this, PxBaseFlags inFlags);

    public unsafe void setBaseFlags(PxBaseFlags inFlags)
    {
        fixed (PxBase* @this = &this)
        { setBaseFlags_PInvoke(@this, inFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBaseFlags@PxBase@physx@@QEBA?AV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@2@XZ", ExactSpelling = true)]
    private static extern PxBaseFlags getBaseFlags_PInvoke(PxBase* @this);

    public unsafe PxBaseFlags getBaseFlags()
    {
        fixed (PxBase* @this = &this)
        { return getBaseFlags_PInvoke(@this); }
    }

    public unsafe bool isReleasable()
    {
        fixed (PxBase* @this = &this)
        { return VirtualMethodTablePointer->isReleasable(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxBase@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxBase* @this, ushort concreteType, PxBaseFlags baseFlags);

    public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
    {
        fixed (PxBase* @this = &this)
        { Constructor_PInvoke(@this, concreteType, baseFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxBase@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxBase* @this, PxBaseFlags baseFlags);

    public unsafe void Constructor(PxBaseFlags baseFlags)
    {
        fixed (PxBase* @this = &this)
        { Constructor_PInvoke(@this, baseFlags); }
    }

    public unsafe void Destructor()
    {
        fixed (PxBase* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    public unsafe bool isKindOf(byte* superClass)
    {
        fixed (PxBase* @this = &this)
        { return VirtualMethodTablePointer->isKindOf(@this, superClass); }
    }

    [FieldOffset(8)] public ushort mConcreteType;

    [FieldOffset(10)] public PxBaseFlags mBaseFlags;


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, void> release;
        /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, byte*> getConcreteTypeName;
        /// <summary>Virtual method pointer for `isReleasable`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, bool> isReleasable;
        /// <summary>Virtual method pointer for `~PxBase`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isKindOf`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, byte*, bool> isKindOf;
    }
}
