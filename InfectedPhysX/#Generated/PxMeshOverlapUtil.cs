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
    [StructLayout(LayoutKind.Explicit, Size = 1040)]
    public unsafe partial struct PxMeshOverlapUtil
    {
        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxMeshOverlapUtil@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxMeshOverlapUtil* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (PxMeshOverlapUtil* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??1PxMeshOverlapUtil@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(PxMeshOverlapUtil* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxMeshOverlapUtil* @this = &this)
            { Destructor_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?findOverlap@PxMeshOverlapUtil@physx@@QEAAIAEBVPxGeometry@2@AEBVPxTransform@2@AEBVPxTriangleMeshGeometry@2@1@Z", ExactSpelling = true)]
        private static extern uint findOverlap_PInvoke(PxMeshOverlapUtil* @this, PxGeometry* geom, PxTransform* geomPose, PxTriangleMeshGeometry* meshGeom, PxTransform* meshPose);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint findOverlap(PxGeometry* geom, PxTransform* geomPose, PxTriangleMeshGeometry* meshGeom, PxTransform* meshPose)
        {
            fixed (PxMeshOverlapUtil* @this = &this)
            { return findOverlap_PInvoke(@this, geom, geomPose, meshGeom, meshPose); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?findOverlap@PxMeshOverlapUtil@physx@@QEAAIAEBVPxGeometry@2@AEBVPxTransform@2@AEBVPxHeightFieldGeometry@2@1@Z", ExactSpelling = true)]
        private static extern uint findOverlap_PInvoke(PxMeshOverlapUtil* @this, PxGeometry* geom, PxTransform* geomPose, PxHeightFieldGeometry* hfGeom, PxTransform* hfPose);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint findOverlap(PxGeometry* geom, PxTransform* geomPose, PxHeightFieldGeometry* hfGeom, PxTransform* hfPose)
        {
            fixed (PxMeshOverlapUtil* @this = &this)
            { return findOverlap_PInvoke(@this, geom, geomPose, hfGeom, hfPose); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getResults@PxMeshOverlapUtil@physx@@QEBAPEBIXZ", ExactSpelling = true)]
        private static extern uint* getResults_PInvoke(PxMeshOverlapUtil* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint* getResults()
        {
            fixed (PxMeshOverlapUtil* @this = &this)
            { return getResults_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getNbResults@PxMeshOverlapUtil@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getNbResults_PInvoke(PxMeshOverlapUtil* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getNbResults()
        {
            fixed (PxMeshOverlapUtil* @this = &this)
            { return getNbResults_PInvoke(@this); }
        }

        [FieldOffset(0)] public uint* mResultsMemory;

        [FieldOffset(8)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32_256 mResults;

        [FieldOffset(1032)] public uint mNbResults;

        [FieldOffset(1036)] public uint mMaxNbResults;
    }
}
