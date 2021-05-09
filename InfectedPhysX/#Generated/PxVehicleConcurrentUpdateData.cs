// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct PxVehicleConcurrentUpdateData
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleConcurrentUpdateData@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleConcurrentUpdateData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxVehicleConcurrentUpdateData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [FieldOffset(0)] public PxVehicleWheelConcurrentUpdateData* concurrentWheelUpdates;

        [FieldOffset(8)] public uint nbConcurrentWheelUpdates;

        [FieldOffset(12)] public PxVec3 linearMomentumChange;

        [FieldOffset(24)] public PxVec3 angularMomentumChange;

        [FieldOffset(36)] [MarshalAs(UnmanagedType.I1)] public bool staySleeping;

        [FieldOffset(37)] [MarshalAs(UnmanagedType.I1)] public bool wakeup;
    }
}
