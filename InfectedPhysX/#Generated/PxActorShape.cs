// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct PxActorShape
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxActorShape@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxActorShape* @this);

    public unsafe void Constructor()
    {
        fixed (PxActorShape* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxActorShape@physx@@QEAA@PEAVPxRigidActor@1@PEAVPxShape@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxActorShape* @this, PxRigidActor* a, PxShape* s);

    public unsafe void Constructor(PxRigidActor* a, PxShape* s)
    {
        fixed (PxActorShape* @this = &this)
        { Constructor_PInvoke(@this, a, s); }
    }

    [FieldOffset(0)] public PxRigidActor* actor;

    [FieldOffset(8)] public PxShape* shape;
}
