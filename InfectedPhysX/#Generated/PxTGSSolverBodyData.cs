// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct PxTGSSolverBodyData
    {
        [FieldOffset(0)] public PxVec3 originalLinearVelocity;

        [FieldOffset(12)] public float maxContactImpulse;

        [FieldOffset(16)] public PxVec3 originalAngularVelocity;

        [FieldOffset(28)] public float penBiasClamp;

        [FieldOffset(32)] public float invMass;

        [FieldOffset(36)] public uint nodeIndex;

        [FieldOffset(40)] public float reportThreshold;

        [FieldOffset(44)] public uint pad;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?projectVelocity@PxTGSSolverBodyData@physx@@QEBAMAEBVPxVec3@2@0@Z", ExactSpelling = true)]
        private static extern float projectVelocity_PInvoke(PxTGSSolverBodyData* @this, PxVec3* linear, PxVec3* angular);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float projectVelocity(PxVec3* linear, PxVec3* angular)
        {
            fixed (PxTGSSolverBodyData* @this = &this)
            { return projectVelocity_PInvoke(@this, linear, angular); }
        }
    }
}
