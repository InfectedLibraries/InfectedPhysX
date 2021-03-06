// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct PxFileBuf
    {
        public enum EndianMode
        {
            ENDIAN_NONE = 0,
            ENDIAN_BIG = 1,
            ENDIAN_LITTLE = 2
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxFileBuf@general_PxIOStream2@physx@@QEAA@W4EndianMode@012@@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxFileBuf* @this, EndianMode mode);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(EndianMode mode = EndianMode.ENDIAN_LITTLE)
        {
            fixed (PxFileBuf* @this = &this)
            { Constructor_PInvoke(@this, mode); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (PxFileBuf* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        public static readonly uint* STREAM_SEEK_END = (uint*)NativeLibrary.GetExport(NativeLibrary.Load("TODO.dll"), "?STREAM_SEEK_END@PxFileBuf@general_PxIOStream2@physx@@2IB");

        public enum OpenMode
        {
            OPEN_FILE_NOT_FOUND,
            OPEN_READ_ONLY,
            OPEN_WRITE_ONLY,
            OPEN_READ_WRITE_NEW,
            OPEN_READ_WRITE_EXISTING
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe OpenMode getOpenMode()
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->getOpenMode(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isOpen@PxFileBuf@general_PxIOStream2@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isOpen_PInvoke(PxFileBuf* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool isOpen()
        {
            fixed (PxFileBuf* @this = &this)
            { return isOpen_PInvoke(@this); }
        }

        public enum SeekType
        {
            SEEKABLE_NO = 0,
            SEEKABLE_READ = 0x1,
            SEEKABLE_WRITE = 0x2,
            SEEKABLE_READWRITE = 0x3
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe SeekType isSeekable()
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->isSeekable(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setEndianMode@PxFileBuf@general_PxIOStream2@physx@@QEAAXW4EndianMode@123@@Z", ExactSpelling = true)]
        private static extern void setEndianMode_PInvoke(PxFileBuf* @this, EndianMode e);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void setEndianMode(EndianMode e)
        {
            fixed (PxFileBuf* @this = &this)
            { setEndianMode_PInvoke(@this, e); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getEndianMode@PxFileBuf@general_PxIOStream2@physx@@QEBA?AW4EndianMode@123@XZ", ExactSpelling = true)]
        private static extern EndianMode getEndianMode_PInvoke(PxFileBuf* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe EndianMode getEndianMode()
        {
            fixed (PxFileBuf* @this = &this)
            { return getEndianMode_PInvoke(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint getFileLength()
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->getFileLength(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint seekRead(uint loc)
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->seekRead(@this, loc); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint seekWrite(uint loc)
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->seekWrite(@this, loc); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint read(void* mem, uint len)
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->read(@this, mem, len); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint peek(void* mem, uint len)
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->peek(@this, mem, len); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint write(void* mem, uint len)
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->write(@this, mem, len); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint tellRead()
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->tellRead(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint tellWrite()
        {
            fixed (PxFileBuf* @this = &this)
            { return VirtualMethodTablePointer->tellWrite(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void flush()
        {
            fixed (PxFileBuf* @this = &this)
            { VirtualMethodTablePointer->flush(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void close()
        {
            fixed (PxFileBuf* @this = &this)
            { VirtualMethodTablePointer->close(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?release@PxFileBuf@general_PxIOStream2@physx@@QEAAXXZ", ExactSpelling = true)]
        private static extern void release_PInvoke(PxFileBuf* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void release()
        {
            fixed (PxFileBuf* @this = &this)
            { release_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isBigEndian@PxFileBuf@general_PxIOStream2@physx@@SA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool isBigEndian();

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?swap2Bytes@PxFileBuf@general_PxIOStream2@physx@@QEBAXPEAX@Z", ExactSpelling = true)]
        private static extern void swap2Bytes_PInvoke(PxFileBuf* @this, void* _data);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void swap2Bytes(void* _data)
        {
            fixed (PxFileBuf* @this = &this)
            { swap2Bytes_PInvoke(@this, _data); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?swap4Bytes@PxFileBuf@general_PxIOStream2@physx@@QEBAXPEAX@Z", ExactSpelling = true)]
        private static extern void swap4Bytes_PInvoke(PxFileBuf* @this, void* _data);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void swap4Bytes(void* _data)
        {
            fixed (PxFileBuf* @this = &this)
            { swap4Bytes_PInvoke(@this, _data); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?swap8Bytes@PxFileBuf@general_PxIOStream2@physx@@QEBAXPEAX@Z", ExactSpelling = true)]
        private static extern void swap8Bytes_PInvoke(PxFileBuf* @this, void* _data);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void swap8Bytes(void* _data)
        {
            fixed (PxFileBuf* @this = &this)
            { swap8Bytes_PInvoke(@this, _data); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?storeDword@PxFileBuf@general_PxIOStream2@physx@@QEAAXI@Z", ExactSpelling = true)]
        private static extern void storeDword_PInvoke(PxFileBuf* @this, uint v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void storeDword(uint v)
        {
            fixed (PxFileBuf* @this = &this)
            { storeDword_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?storeFloat@PxFileBuf@general_PxIOStream2@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void storeFloat_PInvoke(PxFileBuf* @this, float v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void storeFloat(float v)
        {
            fixed (PxFileBuf* @this = &this)
            { storeFloat_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?storeDouble@PxFileBuf@general_PxIOStream2@physx@@QEAAXN@Z", ExactSpelling = true)]
        private static extern void storeDouble_PInvoke(PxFileBuf* @this, double v);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void storeDouble(double v)
        {
            fixed (PxFileBuf* @this = &this)
            { storeDouble_PInvoke(@this, v); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?storeByte@PxFileBuf@general_PxIOStream2@physx@@QEAAXE@Z", ExactSpelling = true)]
        private static extern void storeByte_PInvoke(PxFileBuf* @this, byte b);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void storeByte(byte b)
        {
            fixed (PxFileBuf* @this = &this)
            { storeByte_PInvoke(@this, b); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?storeWord@PxFileBuf@general_PxIOStream2@physx@@QEAAXG@Z", ExactSpelling = true)]
        private static extern void storeWord_PInvoke(PxFileBuf* @this, ushort w);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void storeWord(ushort w)
        {
            fixed (PxFileBuf* @this = &this)
            { storeWord_PInvoke(@this, w); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?readByte@PxFileBuf@general_PxIOStream2@physx@@QEAAEXZ", ExactSpelling = true)]
        private static extern byte readByte_PInvoke(PxFileBuf* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte readByte()
        {
            fixed (PxFileBuf* @this = &this)
            { return readByte_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?readWord@PxFileBuf@general_PxIOStream2@physx@@QEAAGXZ", ExactSpelling = true)]
        private static extern ushort readWord_PInvoke(PxFileBuf* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ushort readWord()
        {
            fixed (PxFileBuf* @this = &this)
            { return readWord_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?readDword@PxFileBuf@general_PxIOStream2@physx@@QEAAIXZ", ExactSpelling = true)]
        private static extern uint readDword_PInvoke(PxFileBuf* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint readDword()
        {
            fixed (PxFileBuf* @this = &this)
            { return readDword_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?readFloat@PxFileBuf@general_PxIOStream2@physx@@QEAAMXZ", ExactSpelling = true)]
        private static extern float readFloat_PInvoke(PxFileBuf* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float readFloat()
        {
            fixed (PxFileBuf* @this = &this)
            { return readFloat_PInvoke(@this); }
        }

        [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?readDouble@PxFileBuf@general_PxIOStream2@physx@@QEAANXZ", ExactSpelling = true)]
        private static extern double readDouble_PInvoke(PxFileBuf* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe double readDouble()
        {
            fixed (PxFileBuf* @this = &this)
            { return readDouble_PInvoke(@this); }
        }

        [FieldOffset(8)] [MarshalAs(UnmanagedType.I1)] public bool mEndianSwap;

        [FieldOffset(12)] public EndianMode mEndianMode;

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `~PxFileBuf`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `getOpenMode`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, OpenMode> getOpenMode;
            /// <summary>Virtual method pointer for `isSeekable`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, SeekType> isSeekable;
            /// <summary>Virtual method pointer for `getFileLength`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, uint> getFileLength;
            /// <summary>Virtual method pointer for `seekRead`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, uint, uint> seekRead;
            /// <summary>Virtual method pointer for `seekWrite`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, uint, uint> seekWrite;
            /// <summary>Virtual method pointer for `read`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, void*, uint, uint> read;
            /// <summary>Virtual method pointer for `peek`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, void*, uint, uint> peek;
            /// <summary>Virtual method pointer for `write`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, void*, uint, uint> write;
            /// <summary>Virtual method pointer for `tellRead`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, uint> tellRead;
            /// <summary>Virtual method pointer for `tellWrite`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, uint> tellWrite;
            /// <summary>Virtual method pointer for `flush`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, void> flush;
            /// <summary>Virtual method pointer for `close`</summary>
            public delegate* unmanaged[Cdecl]<PxFileBuf*, void> close;
        }
    }
}
