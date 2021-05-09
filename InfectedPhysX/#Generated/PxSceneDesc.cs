// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public unsafe partial struct PxSceneDesc
    {
        [FieldOffset(0)] public PxVec3 gravity;

        [FieldOffset(16)] public PxSimulationEventCallback* simulationEventCallback;

        [FieldOffset(24)] public PxContactModifyCallback* contactModifyCallback;

        [FieldOffset(32)] public PxCCDContactModifyCallback* ccdContactModifyCallback;

        [FieldOffset(40)] public void* filterShaderData;

        [FieldOffset(48)] public uint filterShaderDataSize;

        [FieldOffset(56)] public delegate* unmanaged[Cdecl]<uint, PxFilterData, uint, PxFilterData, PxPairFlags*, void*, uint, PxFilterFlags> filterShader;

        [FieldOffset(64)] public PxSimulationFilterCallback* filterCallback;

        [FieldOffset(72)] public PxPairFilteringMode kineKineFilteringMode;

        [FieldOffset(76)] public PxPairFilteringMode staticKineFilteringMode;

        [FieldOffset(80)] public PxBroadPhaseType broadPhaseType;

        [FieldOffset(88)] public PxBroadPhaseCallback* broadPhaseCallback;

        [FieldOffset(96)] public PxSceneLimits limits;

        [FieldOffset(128)] public PxFrictionType frictionType;

        [FieldOffset(132)] public PxSolverType solverType;

        [FieldOffset(136)] public float bounceThresholdVelocity;

        [FieldOffset(140)] public float frictionOffsetThreshold;

        [FieldOffset(144)] public float ccdMaxSeparation;

        [FieldOffset(148)] public float solverOffsetSlop;

        [FieldOffset(152)] public PxSceneFlags flags;

        [FieldOffset(160)] public PxCpuDispatcher* cpuDispatcher;

        [FieldOffset(168)] public PxCudaContextManager* cudaContextManager;

        [FieldOffset(176)] public PxPruningStructureType staticStructure;

        [FieldOffset(180)] public PxPruningStructureType dynamicStructure;

        [FieldOffset(184)] public uint dynamicTreeRebuildRateHint;

        [FieldOffset(188)] public PxSceneQueryUpdateMode sceneQueryUpdateMode;

        [FieldOffset(192)] public void* userData;

        [FieldOffset(200)] public uint solverBatchSize;

        [FieldOffset(204)] public uint solverArticulationBatchSize;

        [FieldOffset(208)] public uint nbContactDataBlocks;

        [FieldOffset(212)] public uint maxNbContactDataBlocks;

        [FieldOffset(216)] public float maxBiasCoefficient;

        [FieldOffset(220)] public uint contactReportStreamBufferSize;

        [FieldOffset(224)] public uint ccdMaxPasses;

        [FieldOffset(228)] public float ccdThreshold;

        [FieldOffset(232)] public float wakeCounterResetValue;

        [FieldOffset(236)] public PxBounds3 sanityBounds;

        [FieldOffset(260)] public PxgDynamicsMemoryConfig gpuDynamicsConfig;

        [FieldOffset(292)] public uint gpuMaxNumPartitions;

        [FieldOffset(296)] public uint gpuComputeVersion;

        [FieldOffset(300)] public PxTolerancesScale tolerancesScale;

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxSceneDesc@physx@@QEAA@AEBVPxTolerancesScale@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxSceneDesc* @this, PxTolerancesScale* scale);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxTolerancesScale* scale)
        {
            fixed (PxSceneDesc* @this = &this)
            { Constructor_PInvoke(@this, scale); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToDefault@PxSceneDesc@physx@@QEAAXAEBVPxTolerancesScale@2@@Z", ExactSpelling = true)]
        private static extern void setToDefault_PInvoke(PxSceneDesc* @this, PxTolerancesScale* scale);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setToDefault(PxTolerancesScale* scale)
        {
            fixed (PxSceneDesc* @this = &this)
            { setToDefault_PInvoke(@this, scale); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxSceneDesc@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxSceneDesc* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isValid()
        {
            fixed (PxSceneDesc* @this = &this)
            { return isValid_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getTolerancesScale@PxSceneDesc@physx@@QEBAAEBVPxTolerancesScale@2@XZ", ExactSpelling = true)]
        private static extern PxTolerancesScale* getTolerancesScale_PInvoke(PxSceneDesc* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxTolerancesScale* getTolerancesScale()
        {
            fixed (PxSceneDesc* @this = &this)
            { return getTolerancesScale_PInvoke(@this); }
        }
    }
}
