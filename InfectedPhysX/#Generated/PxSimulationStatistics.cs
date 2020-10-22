// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 900)]
public unsafe partial struct PxSimulationStatistics
{
    public enum RbPairStatsType
    {
        eDISCRETE_CONTACT_PAIRS,
        eCCD_PAIRS,
        eMODIFIED_CONTACT_PAIRS,
        eTRIGGER_PAIRS
    }

    [FieldOffset(0)] public uint nbActiveConstraints;

    [FieldOffset(4)] public uint nbActiveDynamicBodies;

    [FieldOffset(8)] public uint nbActiveKinematicBodies;

    [FieldOffset(12)] public uint nbStaticBodies;

    [FieldOffset(16)] public uint nbDynamicBodies;

    [FieldOffset(20)] public uint nbKinematicBodies;

    [FieldOffset(24)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32_7 nbShapes;

    [FieldOffset(52)] public uint nbAggregates;

    [FieldOffset(56)] public uint nbArticulations;

    [FieldOffset(60)] public uint nbAxisSolverConstraints;

    [FieldOffset(64)] public uint compressedContactSize;

    [FieldOffset(68)] public uint requiredContactConstraintMemory;

    [FieldOffset(72)] public uint peakConstraintMemory;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getNbBroadPhaseAdds@PxSimulationStatistics@physx@@QEBAIXZ", ExactSpelling = true)]
    private static extern uint getNbBroadPhaseAdds_PInvoke(PxSimulationStatistics* @this);

    public unsafe uint getNbBroadPhaseAdds()
    {
        fixed (PxSimulationStatistics* @this = &this)
        { return getNbBroadPhaseAdds_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getNbBroadPhaseRemoves@PxSimulationStatistics@physx@@QEBAIXZ", ExactSpelling = true)]
    private static extern uint getNbBroadPhaseRemoves_PInvoke(PxSimulationStatistics* @this);

    public unsafe uint getNbBroadPhaseRemoves()
    {
        fixed (PxSimulationStatistics* @this = &this)
        { return getNbBroadPhaseRemoves_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getRbPairStats@PxSimulationStatistics@physx@@QEBAIW4RbPairStatsType@12@W4Enum@PxGeometryType@2@1@Z", ExactSpelling = true)]
    private static extern uint getRbPairStats_PInvoke(PxSimulationStatistics* @this, RbPairStatsType pairType, PxGeometryType g0, PxGeometryType g1);

    public unsafe uint getRbPairStats(RbPairStatsType pairType, PxGeometryType g0, PxGeometryType g1)
    {
        fixed (PxSimulationStatistics* @this = &this)
        { return getRbPairStats_PInvoke(@this, pairType, g0, g1); }
    }

    [FieldOffset(76)] public uint nbDiscreteContactPairsTotal;

    [FieldOffset(80)] public uint nbDiscreteContactPairsWithCacheHits;

    [FieldOffset(84)] public uint nbDiscreteContactPairsWithContacts;

    [FieldOffset(88)] public uint nbNewPairs;

    [FieldOffset(92)] public uint nbLostPairs;

    [FieldOffset(96)] public uint nbNewTouches;

    [FieldOffset(100)] public uint nbLostTouches;

    [FieldOffset(104)] public uint nbPartitions;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxSimulationStatistics@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxSimulationStatistics* @this);

    public unsafe void Constructor()
    {
        fixed (PxSimulationStatistics* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [FieldOffset(108)] public uint nbBroadPhaseAdds;

    [FieldOffset(112)] public uint nbBroadPhaseRemoves;

    [FieldOffset(116)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32__UNICODE_0020____UNICODE_005B__7__UNICODE_005D___7 nbDiscreteContactPairs;

    [FieldOffset(312)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32__UNICODE_0020____UNICODE_005B__7__UNICODE_005D___7 nbCCDPairs;

    [FieldOffset(508)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32__UNICODE_0020____UNICODE_005B__7__UNICODE_005D___7 nbModifiedContactPairs;

    [FieldOffset(704)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32__UNICODE_0020____UNICODE_005B__7__UNICODE_005D___7 nbTriggerPairs;
}
