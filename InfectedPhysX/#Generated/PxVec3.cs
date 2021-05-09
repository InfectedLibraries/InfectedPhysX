// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public unsafe partial struct PxVec3
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVec3@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxVec3* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVec3@physx@@QEAA@W4PxZERO@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVec3* @this, PxZERO r);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxZERO r)
        {
            fixed (PxVec3* @this = &this)
            { Constructor_PInvoke(@this, r); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVec3@physx@@QEAA@M@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVec3* @this, float a);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(float a)
        {
            fixed (PxVec3* @this = &this)
            { Constructor_PInvoke(@this, a); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVec3@physx@@QEAA@MMM@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVec3* @this, float nx, float ny, float nz);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(float nx, float ny, float nz)
        {
            fixed (PxVec3* @this = &this)
            { Constructor_PInvoke(@this, nx, ny, nz); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVec3@physx@@QEAA@AEBV01@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVec3* @this, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            { Constructor_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??4PxVec3@physx@@QEAAAEAV01@AEBV01@@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_Equal_PInvoke(PxVec3* @this, PxVec3* p);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3* operator_Equal(PxVec3* p)
        {
            fixed (PxVec3* @this = &this)
            { return operator_Equal_PInvoke(@this, p); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??APxVec3@physx@@QEAAAEAMI@Z", ExactSpelling = true)]
        private static extern float* operator_Subscript_PInvoke(PxVec3* @this, uint index);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float* operator_Subscript(uint index)
        {
            fixed (PxVec3* @this = &this)
            { return operator_Subscript_PInvoke(@this, index); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??APxVec3@physx@@QEBAAEBMI@Z", ExactSpelling = true)]
        private static extern float* operator_Subscript_Const_PInvoke(PxVec3* @this, uint index);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float* operator_Subscript_Const(uint index)
        {
            fixed (PxVec3* @this = &this)
            { return operator_Subscript_Const_PInvoke(@this, index); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??8PxVec3@physx@@QEBA_NAEBV01@@Z", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool operator_EqualEqual_PInvoke(PxVec3* @this, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool operator_EqualEqual(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            { return operator_EqualEqual_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??9PxVec3@physx@@QEBA_NAEBV01@@Z", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool operator_ExclaimEqual_PInvoke(PxVec3* @this, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool operator_ExclaimEqual(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            { return operator_ExclaimEqual_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isZero@PxVec3@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isZero_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isZero()
        {
            fixed (PxVec3* @this = &this)
            { return isZero_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isFinite@PxVec3@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isFinite_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isFinite()
        {
            fixed (PxVec3* @this = &this)
            { return isFinite_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isNormalized@PxVec3@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isNormalized_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isNormalized()
        {
            fixed (PxVec3* @this = &this)
            { return isNormalized_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?magnitudeSquared@PxVec3@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float magnitudeSquared_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float magnitudeSquared()
        {
            fixed (PxVec3* @this = &this)
            { return magnitudeSquared_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?magnitude@PxVec3@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float magnitude_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float magnitude()
        {
            fixed (PxVec3* @this = &this)
            { return magnitude_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??GPxVec3@physx@@QEBA?AV01@XZ", ExactSpelling = true)]
        private static extern PxVec3* operator_Minus_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 operator_Minus()
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                operator_Minus_PInvoke(@this, out __returnBuffer);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??HPxVec3@physx@@QEBA?AV01@AEBV01@@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_Plus_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 operator_Plus(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                operator_Plus_PInvoke(@this, out __returnBuffer, v);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??GPxVec3@physx@@QEBA?AV01@AEBV01@@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_Minus_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 operator_Minus(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                operator_Minus_PInvoke(@this, out __returnBuffer, v);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??DPxVec3@physx@@QEBA?AV01@M@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_Star_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer, float f);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 operator_Star(float f)
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                operator_Star_PInvoke(@this, out __returnBuffer, f);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??KPxVec3@physx@@QEBA?AV01@M@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_Slash_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer, float f);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 operator_Slash(float f)
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                operator_Slash_PInvoke(@this, out __returnBuffer, f);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??YPxVec3@physx@@QEAAAEAV01@AEBV01@@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_PlusEqual_PInvoke(PxVec3* @this, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3* operator_PlusEqual(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            { return operator_PlusEqual_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??ZPxVec3@physx@@QEAAAEAV01@AEBV01@@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_MinusEqual_PInvoke(PxVec3* @this, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3* operator_MinusEqual(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            { return operator_MinusEqual_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??XPxVec3@physx@@QEAAAEAV01@M@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_StarEqual_PInvoke(PxVec3* @this, float f);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3* operator_StarEqual(float f)
        {
            fixed (PxVec3* @this = &this)
            { return operator_StarEqual_PInvoke(@this, f); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??_0PxVec3@physx@@QEAAAEAV01@M@Z", ExactSpelling = true)]
        private static extern PxVec3* operator_SlashEqual_PInvoke(PxVec3* @this, float f);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3* operator_SlashEqual(float f)
        {
            fixed (PxVec3* @this = &this)
            { return operator_SlashEqual_PInvoke(@this, f); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?dot@PxVec3@physx@@QEBAMAEBV12@@Z", ExactSpelling = true)]
        private static extern float dot_PInvoke(PxVec3* @this, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float dot(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            { return dot_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?cross@PxVec3@physx@@QEBA?AV12@AEBV12@@Z", ExactSpelling = true)]
        private static extern PxVec3* cross_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 cross(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                cross_PInvoke(@this, out __returnBuffer, v);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getNormalized@PxVec3@physx@@QEBA?AV12@XZ", ExactSpelling = true)]
        private static extern PxVec3* getNormalized_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 getNormalized()
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                getNormalized_PInvoke(@this, out __returnBuffer);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?normalize@PxVec3@physx@@QEAAMXZ", ExactSpelling = true)]
        private static extern float normalize_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float normalize()
        {
            fixed (PxVec3* @this = &this)
            { return normalize_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?normalizeSafe@PxVec3@physx@@QEAAMXZ", ExactSpelling = true)]
        private static extern float normalizeSafe_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float normalizeSafe()
        {
            fixed (PxVec3* @this = &this)
            { return normalizeSafe_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?normalizeFast@PxVec3@physx@@QEAAMXZ", ExactSpelling = true)]
        private static extern float normalizeFast_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float normalizeFast()
        {
            fixed (PxVec3* @this = &this)
            { return normalizeFast_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?multiply@PxVec3@physx@@QEBA?AV12@AEBV12@@Z", ExactSpelling = true)]
        private static extern PxVec3* multiply_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer, PxVec3* a);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 multiply(PxVec3* a)
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                multiply_PInvoke(@this, out __returnBuffer, a);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?minimum@PxVec3@physx@@QEBA?AV12@AEBV12@@Z", ExactSpelling = true)]
        private static extern PxVec3* minimum_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 minimum(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                minimum_PInvoke(@this, out __returnBuffer, v);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?minElement@PxVec3@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float minElement_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float minElement()
        {
            fixed (PxVec3* @this = &this)
            { return minElement_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?maximum@PxVec3@physx@@QEBA?AV12@AEBV12@@Z", ExactSpelling = true)]
        private static extern PxVec3* maximum_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer, PxVec3* v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 maximum(PxVec3* v)
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                maximum_PInvoke(@this, out __returnBuffer, v);
                return __returnBuffer;
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?maxElement@PxVec3@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float maxElement_PInvoke(PxVec3* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float maxElement()
        {
            fixed (PxVec3* @this = &this)
            { return maxElement_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?abs@PxVec3@physx@@QEBA?AV12@XZ", ExactSpelling = true)]
        private static extern PxVec3* abs_PInvoke(PxVec3* @this, out PxVec3 __returnBuffer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 abs()
        {
            fixed (PxVec3* @this = &this)
            {
                PxVec3 __returnBuffer;
                abs_PInvoke(@this, out __returnBuffer);
                return __returnBuffer;
            }
        }

        [FieldOffset(0)] public float x;

        [FieldOffset(4)] public float y;

        [FieldOffset(8)] public float z;
    }
}
