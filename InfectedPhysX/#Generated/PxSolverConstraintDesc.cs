// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 48)]
public unsafe partial struct PxSolverConstraintDesc
{
    public static readonly ushort* NO_LINK = (ushort*)NativeLibrary.GetExport(NativeLibrary.Load("TODO.dll"), "?NO_LINK@PxSolverConstraintDesc@physx@@2GB");
    public enum ConstraintType
    {
        eCONTACT_CONSTRAINT,
        eJOINT_CONSTRAINT
    }

    [FieldOffset(0)] public PxSolverBody* bodyA;

    [FieldOffset(0)] public PxTGSSolverBodyVel* tgsBodyA;

    [FieldOffset(0)] public ArticulationV* articulationA;

    [FieldOffset(8)] public PxSolverBody* bodyB;

    [FieldOffset(8)] public PxTGSSolverBodyVel* tgsBodyB;

    [FieldOffset(8)] public ArticulationV* articulationB;

    [FieldOffset(16)] public ushort linkIndexA;

    [FieldOffset(18)] public ushort linkIndexB;

    [FieldOffset(20)] public uint bodyADataIndex;

    [FieldOffset(24)] public uint bodyBDataIndex;

    [FieldOffset(28)] public ushort writeBackLengthOver4;

    [FieldOffset(30)] public ushort constraintLengthOver16;

    [FieldOffset(32)] public byte* constraint;

    [FieldOffset(40)] public void* writeBack;
}
