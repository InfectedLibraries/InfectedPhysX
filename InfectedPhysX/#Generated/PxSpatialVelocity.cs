// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 32)]
public unsafe partial struct PxSpatialVelocity
{
    [FieldOffset(0)] public PxVec3 linear;

    [FieldOffset(12)] public float pad0;

    [FieldOffset(16)] public PxVec3 angular;

    [FieldOffset(28)] public float pad1;
}