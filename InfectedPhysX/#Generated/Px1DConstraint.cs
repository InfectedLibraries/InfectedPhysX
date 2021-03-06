// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct Px1DConstraint
    {
        [FieldOffset(0)] public PxVec3 linear0;

        [FieldOffset(12)] public float geometricError;

        [FieldOffset(16)] public PxVec3 angular0;

        [FieldOffset(28)] public float velocityTarget;

        [FieldOffset(32)] public PxVec3 linear1;

        [FieldOffset(44)] public float minImpulse;

        [FieldOffset(48)] public PxVec3 angular1;

        [FieldOffset(60)] public float maxImpulse;

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __UNICODE_003C____UNICODE_003E__UnnamedTranslatedRecord
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public unsafe partial struct SpringModifiers
            {
                [FieldOffset(0)] public float stiffness;

                [FieldOffset(4)] public float damping;
            }

            [FieldOffset(0)] public SpringModifiers spring;

            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public unsafe partial struct RestitutionModifiers
            {
                [FieldOffset(0)] public float restitution;

                [FieldOffset(4)] public float velocityThreshold;
            }

            [FieldOffset(0)] public RestitutionModifiers bounce;
        }

        [FieldOffset(64)] public __UNICODE_003C____UNICODE_003E__UnnamedTranslatedRecord mods;

        [FieldOffset(72)] public float forInternalUse;

        [FieldOffset(76)] public ushort flags;

        [FieldOffset(78)] public ushort solveHint;
    }
}
