// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public unsafe partial struct PxBroadPhaseCaps
    {
        [FieldOffset(0)] public uint maxNbRegions;

        [FieldOffset(4)] public uint maxNbObjects;

        [FieldOffset(8)] [MarshalAs(UnmanagedType.I1)] public bool needsPredefinedBounds;
    }
}
