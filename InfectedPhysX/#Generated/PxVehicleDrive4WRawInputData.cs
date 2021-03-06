// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using PhysX.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct PxVehicleDrive4WRawInputData
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDrive4WRawInputData@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setDigitalAccel@PxVehicleDrive4WRawInputData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setDigitalAccel_PInvoke(PxVehicleDrive4WRawInputData* @this, [MarshalAs(UnmanagedType.I1)] bool accelKeyPressed);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setDigitalAccel(bool accelKeyPressed)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setDigitalAccel_PInvoke(@this, accelKeyPressed); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setDigitalBrake@PxVehicleDrive4WRawInputData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setDigitalBrake_PInvoke(PxVehicleDrive4WRawInputData* @this, [MarshalAs(UnmanagedType.I1)] bool brakeKeyPressed);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setDigitalBrake(bool brakeKeyPressed)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setDigitalBrake_PInvoke(@this, brakeKeyPressed); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setDigitalHandbrake@PxVehicleDrive4WRawInputData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setDigitalHandbrake_PInvoke(PxVehicleDrive4WRawInputData* @this, [MarshalAs(UnmanagedType.I1)] bool handbrakeKeyPressed);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setDigitalHandbrake(bool handbrakeKeyPressed)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setDigitalHandbrake_PInvoke(@this, handbrakeKeyPressed); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setDigitalSteerLeft@PxVehicleDrive4WRawInputData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setDigitalSteerLeft_PInvoke(PxVehicleDrive4WRawInputData* @this, [MarshalAs(UnmanagedType.I1)] bool steerLeftKeyPressed);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setDigitalSteerLeft(bool steerLeftKeyPressed)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setDigitalSteerLeft_PInvoke(@this, steerLeftKeyPressed); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setDigitalSteerRight@PxVehicleDrive4WRawInputData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setDigitalSteerRight_PInvoke(PxVehicleDrive4WRawInputData* @this, [MarshalAs(UnmanagedType.I1)] bool steerRightKeyPressed);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setDigitalSteerRight(bool steerRightKeyPressed)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setDigitalSteerRight_PInvoke(@this, steerRightKeyPressed); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getDigitalAccel@PxVehicleDrive4WRawInputData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getDigitalAccel_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getDigitalAccel()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getDigitalAccel_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getDigitalBrake@PxVehicleDrive4WRawInputData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getDigitalBrake_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getDigitalBrake()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getDigitalBrake_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getDigitalHandbrake@PxVehicleDrive4WRawInputData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getDigitalHandbrake_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getDigitalHandbrake()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getDigitalHandbrake_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getDigitalSteerLeft@PxVehicleDrive4WRawInputData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getDigitalSteerLeft_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getDigitalSteerLeft()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getDigitalSteerLeft_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getDigitalSteerRight@PxVehicleDrive4WRawInputData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getDigitalSteerRight_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getDigitalSteerRight()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getDigitalSteerRight_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setAnalogAccel@PxVehicleDrive4WRawInputData@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void setAnalogAccel_PInvoke(PxVehicleDrive4WRawInputData* @this, float accel);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setAnalogAccel(float accel)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setAnalogAccel_PInvoke(@this, accel); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setAnalogBrake@PxVehicleDrive4WRawInputData@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void setAnalogBrake_PInvoke(PxVehicleDrive4WRawInputData* @this, float brake);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setAnalogBrake(float brake)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setAnalogBrake_PInvoke(@this, brake); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setAnalogHandbrake@PxVehicleDrive4WRawInputData@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void setAnalogHandbrake_PInvoke(PxVehicleDrive4WRawInputData* @this, float handbrake);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setAnalogHandbrake(float handbrake)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setAnalogHandbrake_PInvoke(@this, handbrake); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setAnalogSteer@PxVehicleDrive4WRawInputData@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void setAnalogSteer_PInvoke(PxVehicleDrive4WRawInputData* @this, float steer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setAnalogSteer(float steer)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setAnalogSteer_PInvoke(@this, steer); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAnalogAccel@PxVehicleDrive4WRawInputData@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float getAnalogAccel_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getAnalogAccel()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getAnalogAccel_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAnalogBrake@PxVehicleDrive4WRawInputData@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float getAnalogBrake_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getAnalogBrake()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getAnalogBrake_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAnalogHandbrake@PxVehicleDrive4WRawInputData@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float getAnalogHandbrake_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getAnalogHandbrake()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getAnalogHandbrake_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAnalogSteer@PxVehicleDrive4WRawInputData@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float getAnalogSteer_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getAnalogSteer()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getAnalogSteer_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setGearUp@PxVehicleDrive4WRawInputData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setGearUp_PInvoke(PxVehicleDrive4WRawInputData* @this, [MarshalAs(UnmanagedType.I1)] bool gearUpKeyPressed);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setGearUp(bool gearUpKeyPressed)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setGearUp_PInvoke(@this, gearUpKeyPressed); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setGearDown@PxVehicleDrive4WRawInputData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setGearDown_PInvoke(PxVehicleDrive4WRawInputData* @this, [MarshalAs(UnmanagedType.I1)] bool gearDownKeyPressed);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setGearDown(bool gearDownKeyPressed)
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { setGearDown_PInvoke(@this, gearDownKeyPressed); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getGearUp@PxVehicleDrive4WRawInputData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getGearUp_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getGearUp()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getGearUp_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getGearDown@PxVehicleDrive4WRawInputData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getGearDown_PInvoke(PxVehicleDrive4WRawInputData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool getGearDown()
        {
            fixed (PxVehicleDrive4WRawInputData* @this = &this)
            { return getGearDown_PInvoke(@this); }
        }

        [FieldOffset(8)] public ConstantArray_bool_5 mRawDigitalInputs;

        [FieldOffset(16)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_5 mRawAnalogInputs;

        [FieldOffset(36)] [MarshalAs(UnmanagedType.I1)] public bool mGearUp;

        [FieldOffset(37)] [MarshalAs(UnmanagedType.I1)] public bool mGearDown;

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `~PxVehicleDrive4WRawInputData`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleDrive4WRawInputData*, void> __DeletingDestructorPointer;
        }
    }
}
