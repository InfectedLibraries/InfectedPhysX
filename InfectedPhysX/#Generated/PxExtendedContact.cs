// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct PxExtendedContact
{
    [FieldOffset(0)] public PxContact Base;

    [FieldOffset(16)] public PxVec3 targetVelocity;

    [FieldOffset(28)] public float maxImpulse;
}
