// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxConstraintBatchHeader
    {
        [FieldOffset(0)] public uint startIndex;

        [FieldOffset(4)] public ushort stride;

        [FieldOffset(6)] public ushort constraintType;
    }
}
