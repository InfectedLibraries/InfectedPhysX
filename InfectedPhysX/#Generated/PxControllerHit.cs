// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 64)]
public unsafe partial struct PxControllerHit
{
    [FieldOffset(0)] public PxController* controller;

    [FieldOffset(8)] public PxExtendedVec3 worldPos;

    [FieldOffset(32)] public PxVec3 worldNormal;

    [FieldOffset(44)] public PxVec3 dir;

    [FieldOffset(56)] public float length;
}
