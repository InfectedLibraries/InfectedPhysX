// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 48)]
public unsafe partial struct PxContactPairPoint
{
    [FieldOffset(0)] public PxVec3 position;

    [FieldOffset(12)] public float separation;

    [FieldOffset(16)] public PxVec3 normal;

    [FieldOffset(28)] public uint internalFaceIndex0;

    [FieldOffset(32)] public PxVec3 impulse;

    [FieldOffset(44)] public uint internalFaceIndex1;
}
