// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct PxControllerState
    {
        [FieldOffset(0)] public PxVec3 deltaXP;

        [FieldOffset(16)] public PxShape* touchedShape;

        [FieldOffset(24)] public PxRigidActor* touchedActor;

        [FieldOffset(32)] public uint touchedObstacleHandle;

        [FieldOffset(36)] public uint collisionFlags;

        [FieldOffset(40)] [MarshalAs(UnmanagedType.I1)] public bool standOnAnotherCCT;

        [FieldOffset(41)] [MarshalAs(UnmanagedType.I1)] public bool standOnObstacle;

        [FieldOffset(42)] [MarshalAs(UnmanagedType.I1)] public bool isMovingUp;
    }
}
