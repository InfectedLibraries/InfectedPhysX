// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

public unsafe static partial class PxWindowsDelayLoadHook
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void PxSetPhysXDelayLoadHook(PxDelayLoadHook* hook);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void PxSetPhysXCookingDelayLoadHook(PxDelayLoadHook* hook);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void PxSetPhysXCommonDelayLoadHook(PxDelayLoadHook* hook);
}
