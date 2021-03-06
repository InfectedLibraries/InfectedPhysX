// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public unsafe partial struct PxSerialization
    {
        [StructLayout(LayoutKind.Explicit, Size = 20)]
        public unsafe partial struct PxXmlMiscParameter
        {
            [FieldOffset(0)] public PxVec3 upVector;

            [FieldOffset(12)] public PxTolerancesScale scale;

            [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxXmlMiscParameter@PxSerialization@physx@@QEAA@XZ", ExactSpelling = true)]
            private static extern void Constructor_PInvoke(PxXmlMiscParameter* @this);

            [DebuggerStepThrough, DebuggerHidden]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void Constructor()
            {
                fixed (PxXmlMiscParameter* @this = &this)
                { Constructor_PInvoke(@this); }
            }

            [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxXmlMiscParameter@PxSerialization@physx@@QEAA@AEAVPxVec3@2@VPxTolerancesScale@2@@Z", ExactSpelling = true)]
            private static extern void Constructor_PInvoke(PxXmlMiscParameter* @this, PxVec3* inUpVector, PxTolerancesScale inScale);

            [DebuggerStepThrough, DebuggerHidden]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe void Constructor(PxVec3* inUpVector, PxTolerancesScale inScale)
            {
                fixed (PxXmlMiscParameter* @this = &this)
                { Constructor_PInvoke(@this, inUpVector, inScale); }
            }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isSerializable@PxSerialization@physx@@SA_NAEAVPxCollection@2@AEAVPxSerializationRegistry@2@PEBV32@@Z", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool isSerializable(PxCollection* collection, PxSerializationRegistry* sr, PxCollection* externalReferences = null);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?complete@PxSerialization@physx@@SAXAEAVPxCollection@2@AEAVPxSerializationRegistry@2@PEBV32@_N@Z", ExactSpelling = true)]
        public static extern void complete(PxCollection* collection, PxSerializationRegistry* sr, PxCollection* exceptFor = null, [MarshalAs(UnmanagedType.I1)] bool followJoints = false);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?createSerialObjectIds@PxSerialization@physx@@SAXAEAVPxCollection@2@_K@Z", ExactSpelling = true)]
        public static extern void createSerialObjectIds(PxCollection* collection, ulong @base);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?createCollectionFromXml@PxSerialization@physx@@SAPEAVPxCollection@2@AEAVPxInputData@2@AEAVPxCooking@2@AEAVPxSerializationRegistry@2@PEBV32@PEAVPxStringTable@2@PEAUPxXmlMiscParameter@12@@Z", ExactSpelling = true)]
        public static extern PxCollection* createCollectionFromXml(PxInputData* inputData, PxCooking* cooking, PxSerializationRegistry* sr, PxCollection* externalRefs = null, PxStringTable* stringTable = null, PxXmlMiscParameter* outArgs = null);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?createCollectionFromBinary@PxSerialization@physx@@SAPEAVPxCollection@2@PEAXAEAVPxSerializationRegistry@2@PEBV32@@Z", ExactSpelling = true)]
        public static extern PxCollection* createCollectionFromBinary(void* memBlock, PxSerializationRegistry* sr, PxCollection* externalRefs = null);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?serializeCollectionToXml@PxSerialization@physx@@SA_NAEAVPxOutputStream@2@AEAVPxCollection@2@AEAVPxSerializationRegistry@2@PEAVPxCooking@2@PEBV42@PEAUPxXmlMiscParameter@12@@Z", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool serializeCollectionToXml(PxOutputStream* outputStream, PxCollection* collection, PxSerializationRegistry* sr, PxCooking* cooking = null, PxCollection* externalRefs = null, PxXmlMiscParameter* inArgs = null);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?serializeCollectionToBinary@PxSerialization@physx@@SA_NAEAVPxOutputStream@2@AEAVPxCollection@2@AEAVPxSerializationRegistry@2@PEBV42@_N@Z", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool serializeCollectionToBinary(PxOutputStream* outputStream, PxCollection* collection, PxSerializationRegistry* sr, PxCollection* externalRefs = null, [MarshalAs(UnmanagedType.I1)] bool exportNames = false);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?serializeCollectionToBinaryDeterministic@PxSerialization@physx@@SA_NAEAVPxOutputStream@2@AEAVPxCollection@2@AEAVPxSerializationRegistry@2@PEBV42@_N@Z", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool serializeCollectionToBinaryDeterministic(PxOutputStream* outputStream, PxCollection* collection, PxSerializationRegistry* sr, PxCollection* externalRefs = null, [MarshalAs(UnmanagedType.I1)] bool exportNames = false);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?dumpBinaryMetaData@PxSerialization@physx@@SAXAEAVPxOutputStream@2@AEAVPxSerializationRegistry@2@@Z", ExactSpelling = true)]
        public static extern void dumpBinaryMetaData(PxOutputStream* outputStream, PxSerializationRegistry* sr);

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?createBinaryConverter@PxSerialization@physx@@SAPEAVPxBinaryConverter@2@XZ", ExactSpelling = true)]
        public static extern PxBinaryConverter* createBinaryConverter();

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?createSerializationRegistry@PxSerialization@physx@@SAPEAVPxSerializationRegistry@2@AEAVPxPhysics@2@@Z", ExactSpelling = true)]
        public static extern PxSerializationRegistry* createSerializationRegistry(PxPhysics* physics);
    }
}
