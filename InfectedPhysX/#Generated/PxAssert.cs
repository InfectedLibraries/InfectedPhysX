// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

public unsafe static partial class PxAssert
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxGetAssertHandler@physx@@YAAEAVPxAssertHandler@1@XZ", ExactSpelling = true)]
    public static extern PxAssertHandler* PxGetAssertHandler();

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxSetAssertHandler@physx@@YAXAEAVPxAssertHandler@1@@Z", ExactSpelling = true)]
    public static extern void PxSetAssertHandler(PxAssertHandler* handler);
}
