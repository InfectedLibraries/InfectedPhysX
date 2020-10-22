// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 112)]
public unsafe partial struct PxSolverBodyData
{
    [FieldOffset(0)] public PxVec3 linearVelocity;

    [FieldOffset(12)] public float invMass;

    [FieldOffset(16)] public PxVec3 angularVelocity;

    [FieldOffset(28)] public float reportThreshold;

    [FieldOffset(32)] public PxMat33 sqrtInvInertia;

    [FieldOffset(68)] public float penBiasClamp;

    [FieldOffset(72)] public uint nodeIndex;

    [FieldOffset(76)] public float maxContactImpulse;

    [FieldOffset(80)] public PxTransform body2World;

    [FieldOffset(108)] public ushort lockFlags;

    [FieldOffset(110)] public ushort pad;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?projectVelocity@PxSolverBodyData@physx@@QEBAMAEBVPxVec3@2@0@Z", ExactSpelling = true)]
    private static extern float projectVelocity_PInvoke(PxSolverBodyData* @this, PxVec3* lin, PxVec3* ang);

    public unsafe float projectVelocity(PxVec3* lin, PxVec3* ang)
    {
        fixed (PxSolverBodyData* @this = &this)
        { return projectVelocity_PInvoke(@this, lin, ang); }
    }
}