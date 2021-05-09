// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public unsafe partial struct PxWheelQueryResult
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxWheelQueryResult@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxWheelQueryResult* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxWheelQueryResult* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [FieldOffset(0)] public PxVec3 suspLineStart;

        [FieldOffset(12)] public PxVec3 suspLineDir;

        [FieldOffset(24)] public float suspLineLength;

        [FieldOffset(28)] [MarshalAs(UnmanagedType.I1)] public bool isInAir;

        [FieldOffset(32)] public PxActor* tireContactActor;

        [FieldOffset(40)] public PxShape* tireContactShape;

        [FieldOffset(48)] public PxMaterial* tireSurfaceMaterial;

        [FieldOffset(56)] public uint tireSurfaceType;

        [FieldOffset(60)] public PxVec3 tireContactPoint;

        [FieldOffset(72)] public PxVec3 tireContactNormal;

        [FieldOffset(84)] public float tireFriction;

        [FieldOffset(88)] public float suspJounce;

        [FieldOffset(92)] public float suspSpringForce;

        [FieldOffset(96)] public PxVec3 tireLongitudinalDir;

        [FieldOffset(108)] public PxVec3 tireLateralDir;

        [FieldOffset(120)] public float longitudinalSlip;

        [FieldOffset(124)] public float lateralSlip;

        [FieldOffset(128)] public float steerAngle;

        [FieldOffset(132)] public PxTransform localPose;
    }
}
