// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct PxArticulationDrive
{
    [FieldOffset(0)] public float stiffness;

    [FieldOffset(4)] public float damping;

    [FieldOffset(8)] public float maxForce;

    [FieldOffset(12)] public PxArticulationDriveType driveType;
}