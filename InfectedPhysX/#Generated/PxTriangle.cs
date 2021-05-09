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
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public unsafe partial struct PxTriangle
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxTriangle@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxTriangle* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxTriangle* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxTriangle@physx@@QEAA@AEBVPxVec3@1@00@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxTriangle* @this, PxVec3* p0, PxVec3* p1, PxVec3* p2);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxVec3* p0, PxVec3* p1, PxVec3* p2)
        {
            fixed (PxTriangle* @this = &this)
            { Constructor_PInvoke(@this, p0, p1, p2); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxTriangle@physx@@QEAA@AEBV01@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxTriangle* @this, PxTriangle* triangle);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxTriangle* triangle)
        {
            fixed (PxTriangle* @this = &this)
            { Constructor_PInvoke(@this, triangle); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??1PxTriangle@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(PxTriangle* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxTriangle* @this = &this)
            { Destructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??4PxTriangle@physx@@QEAAXAEBV01@@Z", ExactSpelling = true)]
        private static extern void operator_Equal_PInvoke(PxTriangle* @this, PxTriangle* triangle);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void operator_Equal(PxTriangle* triangle)
        {
            fixed (PxTriangle* @this = &this)
            { operator_Equal_PInvoke(@this, triangle); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?normal@PxTriangle@physx@@QEBAXAEAVPxVec3@2@@Z", ExactSpelling = true)]
        private static extern void normal_PInvoke(PxTriangle* @this, PxVec3* _normal);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void normal(PxVec3* _normal)
        {
            fixed (PxTriangle* @this = &this)
            { normal_PInvoke(@this, _normal); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?denormalizedNormal@PxTriangle@physx@@QEBAXAEAVPxVec3@2@@Z", ExactSpelling = true)]
        private static extern void denormalizedNormal_PInvoke(PxTriangle* @this, PxVec3* _normal);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void denormalizedNormal(PxVec3* _normal)
        {
            fixed (PxTriangle* @this = &this)
            { denormalizedNormal_PInvoke(@this, _normal); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?area@PxTriangle@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float area_PInvoke(PxTriangle* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float area()
        {
            fixed (PxTriangle* @this = &this)
            { return area_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?pointFromUV@PxTriangle@physx@@QEBA?AVPxVec3@2@MM@Z", ExactSpelling = true)]
        private static extern PxVec3* pointFromUV_PInvoke(PxTriangle* @this, out PxVec3 __returnBuffer, float u, float v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 pointFromUV(float u, float v)
        {
            fixed (PxTriangle* @this = &this)
            {
                PxVec3 __returnBuffer;
                pointFromUV_PInvoke(@this, out __returnBuffer, u, v);
                return __returnBuffer;
            }
        }

        [FieldOffset(0)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxVec3_3 verts;
    }
}
