// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxErrorCallback
{
    public unsafe void Destructor()
    {
        fixed (PxErrorCallback* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }

    public unsafe void reportError(PxErrorCode code, byte* message, byte* file, int line)
    {
        fixed (PxErrorCallback* @this = &this)
        { VirtualMethodTablePointer->reportError(@this, code, message, file, line); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `~PxErrorCallback`</summary>
        public delegate* unmanaged[Cdecl]<PxErrorCallback*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `reportError`</summary>
        public delegate* unmanaged[Cdecl]<PxErrorCallback*, PxErrorCode, byte*, byte*, int, void> reportError;
    }
}
