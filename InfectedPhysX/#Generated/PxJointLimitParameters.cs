// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 20)]
public unsafe partial struct PxJointLimitParameters
{
    [FieldOffset(0)] public float restitution;

    [FieldOffset(4)] public float bounceThreshold;

    [FieldOffset(8)] public float stiffness;

    [FieldOffset(12)] public float damping;

    [FieldOffset(16)] public float contactDistance;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJointLimitParameters@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxJointLimitParameters* @this);

    public unsafe void Constructor()
    {
        fixed (PxJointLimitParameters* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxJointLimitParameters@physx@@QEAA@AEBV01@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxJointLimitParameters* @this, PxJointLimitParameters* p);

    public unsafe void Constructor(PxJointLimitParameters* p)
    {
        fixed (PxJointLimitParameters* @this = &this)
        { Constructor_PInvoke(@this, p); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxJointLimitParameters@physx@@QEBA_NXZ", ExactSpelling = true)]
    private static extern bool isValid_PInvoke(PxJointLimitParameters* @this);

    public unsafe bool isValid()
    {
        fixed (PxJointLimitParameters* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isSoft@PxJointLimitParameters@physx@@QEBA_NXZ", ExactSpelling = true)]
    private static extern bool isSoft_PInvoke(PxJointLimitParameters* @this);

    public unsafe bool isSoft()
    {
        fixed (PxJointLimitParameters* @this = &this)
        { return isSoft_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??_DPxJointLimitParameters@physx@@IEAAXXZ", ExactSpelling = true)]
    private static extern void Destructor_PInvoke(PxJointLimitParameters* @this);

    public unsafe void Destructor()
    {
        fixed (PxJointLimitParameters* @this = &this)
        { Destructor_PInvoke(@this); }
    }
}