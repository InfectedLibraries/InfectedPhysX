// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 544)]
    public unsafe partial struct PxVehicleDriveSimDataNW
    {
        [FieldOffset(0)] public PxVehicleDriveSimData Base;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDriveSimDataNW@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDriveSimDataNW* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxVehicleDriveSimDataNW* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getDiffData@PxVehicleDriveSimDataNW@physx@@QEBAAEBVPxVehicleDifferentialNWData@2@XZ", ExactSpelling = true)]
        private static extern PxVehicleDifferentialNWData* getDiffData_PInvoke(PxVehicleDriveSimDataNW* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVehicleDifferentialNWData* getDiffData()
        {
            fixed (PxVehicleDriveSimDataNW* @this = &this)
            { return getDiffData_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setDiffData@PxVehicleDriveSimDataNW@physx@@QEAAXAEBVPxVehicleDifferentialNWData@2@@Z", ExactSpelling = true)]
        private static extern void setDiffData_PInvoke(PxVehicleDriveSimDataNW* @this, PxVehicleDifferentialNWData* diff);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setDiffData(PxVehicleDifferentialNWData* diff)
        {
            fixed (PxVehicleDriveSimDataNW* @this = &this)
            { setDiffData_PInvoke(@this, diff); }
        }

        [FieldOffset(528)] public PxVehicleDifferentialNWData mDiff;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxVehicleDriveSimDataNW@physx@@AEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxVehicleDriveSimDataNW* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxVehicleDriveSimDataNW* @this = &this)
            { return isValid_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDriveSimDataNW@physx@@QEAA@W4PxEMPTY@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDriveSimDataNW* @this, PxEMPTY arg0);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxEMPTY arg0)
        {
            fixed (PxVehicleDriveSimDataNW* @this = &this)
            { Constructor_PInvoke(@this, arg0); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBinaryMetaData@PxVehicleDriveSimDataNW@physx@@SAXAEAVPxOutputStream@2@@Z", ExactSpelling = true)]
        public static extern void getBinaryMetaData(PxOutputStream* stream);
    }
}
