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
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct PxHeightField
    {
        [FieldOffset(0)] public PxBase Base;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void release()
        {
            fixed (PxHeightField* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint saveCells(void* destBuffer, uint destBufferSize)
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->saveCells(@this, destBuffer, destBufferSize); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool modifySamples(int startCol, int startRow, PxHeightFieldDesc* subfieldDesc, bool shrinkBounds = false)
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->modifySamples(@this, startCol, startRow, subfieldDesc, shrinkBounds); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getNbRows()
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getNbRows(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getNbColumns()
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getNbColumns(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxHeightFieldFormat getFormat()
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getFormat(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getSampleStride()
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getSampleStride(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getConvexEdgeThreshold()
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getConvexEdgeThreshold(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxHeightFieldFlags getFlags()
        {
            fixed (PxHeightField* @this = &this)
            {
                PxHeightFieldFlags __returnBuffer;
                VirtualMethodTablePointer->getFlags(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float getHeight(float x, float z)
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getHeight(@this, x, z); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getReferenceCount()
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getReferenceCount(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void acquireReference()
        {
            fixed (PxHeightField* @this = &this)
            { VirtualMethodTablePointer->acquireReference(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ushort getTriangleMaterialIndex(uint triangleIndex)
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getTriangleMaterialIndex(@this, triangleIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxVec3 getTriangleNormal(uint triangleIndex)
        {
            fixed (PxHeightField* @this = &this)
            {
                PxVec3 __returnBuffer;
                VirtualMethodTablePointer->getTriangleNormal(@this, &__returnBuffer, triangleIndex);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PxHeightFieldSample* getSample(uint row, uint column)
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getSample(@this, row, column); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getTimestamp()
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getTimestamp(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* getConcreteTypeName()
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxHeightField@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxHeightField* @this, ushort concreteType, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
        {
            fixed (PxHeightField* @this = &this)
            { Constructor_PInvoke(@this, concreteType, baseFlags); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxHeightField@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxHeightField* @this, PxBaseFlags baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(PxBaseFlags baseFlags)
        {
            fixed (PxHeightField* @this = &this)
            { Constructor_PInvoke(@this, baseFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxHeightField* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isKindOf(byte* name)
        {
            fixed (PxHeightField* @this = &this)
            { return VirtualMethodTablePointer->isKindOf(@this, name); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxBase*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxHeightField`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, byte*, NativeBoolean> isKindOf;
            /// <summary>Virtual method pointer for `saveCells`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, void*, uint, uint> saveCells;
            /// <summary>Virtual method pointer for `modifySamples`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, int, int, PxHeightFieldDesc*, NativeBoolean, NativeBoolean> modifySamples;
            /// <summary>Virtual method pointer for `getNbRows`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, uint> getNbRows;
            /// <summary>Virtual method pointer for `getNbColumns`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, uint> getNbColumns;
            /// <summary>Virtual method pointer for `getFormat`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, PxHeightFieldFormat> getFormat;
            /// <summary>Virtual method pointer for `getSampleStride`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, uint> getSampleStride;
            /// <summary>Virtual method pointer for `getConvexEdgeThreshold`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, float> getConvexEdgeThreshold;
            /// <summary>Virtual method pointer for `getFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, PxHeightFieldFlags*, PxHeightFieldFlags*> getFlags;
            /// <summary>Virtual method pointer for `getHeight`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, float, float, float> getHeight;
            /// <summary>Virtual method pointer for `getReferenceCount`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, uint> getReferenceCount;
            /// <summary>Virtual method pointer for `acquireReference`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, void> acquireReference;
            /// <summary>Virtual method pointer for `getTriangleMaterialIndex`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, uint, ushort> getTriangleMaterialIndex;
            /// <summary>Virtual method pointer for `getTriangleNormal`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, PxVec3*, uint, PxVec3*> getTriangleNormal;
            /// <summary>Virtual method pointer for `getSample`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, uint, uint, PxHeightFieldSample*> getSample;
            /// <summary>Virtual method pointer for `getTimestamp`</summary>
            public delegate* unmanaged[Cdecl]<PxHeightField*, uint> getTimestamp;
        }
    }
}
