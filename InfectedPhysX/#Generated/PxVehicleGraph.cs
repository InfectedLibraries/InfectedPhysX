// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 15840)]
public unsafe partial struct PxVehicleGraph
{
    public const int eMAX_NB_SAMPLES = 256;

    public const int eMAX_NB_TITLE_CHARS = 256;

    public const int eMAX_NB_CHANNELS = 12;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setup@PxVehicleGraph@physx@@QEAAXAEBVPxVehicleGraphDesc@2@W4Enum@PxVehicleGraphType@2@@Z", ExactSpelling = true)]
    private static extern void setup_PInvoke(PxVehicleGraph* @this, PxVehicleGraphDesc* desc, PxVehicleGraphType graphType);

    public unsafe void setup(PxVehicleGraphDesc* desc, PxVehicleGraphType graphType)
    {
        fixed (PxVehicleGraph* @this = &this)
        { setup_PInvoke(@this, desc, graphType); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?clearRecordedChannelData@PxVehicleGraph@physx@@QEAAXXZ", ExactSpelling = true)]
    private static extern void clearRecordedChannelData_PInvoke(PxVehicleGraph* @this);

    public unsafe void clearRecordedChannelData()
    {
        fixed (PxVehicleGraph* @this = &this)
        { clearRecordedChannelData_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBackgroundColor@PxVehicleGraph@physx@@QEBAAEBVPxVec3@2@XZ", ExactSpelling = true)]
    private static extern PxVec3* getBackgroundColor_PInvoke(PxVehicleGraph* @this);

    public unsafe PxVec3* getBackgroundColor()
    {
        fixed (PxVehicleGraph* @this = &this)
        { return getBackgroundColor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBackgroundAlpha@PxVehicleGraph@physx@@QEBAMXZ", ExactSpelling = true)]
    private static extern float getBackgroundAlpha_PInvoke(PxVehicleGraph* @this);

    public unsafe float getBackgroundAlpha()
    {
        fixed (PxVehicleGraph* @this = &this)
        { return getBackgroundAlpha_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBackgroundCoords@PxVehicleGraph@physx@@QEBAXAEAM000@Z", ExactSpelling = true)]
    private static extern void getBackgroundCoords_PInvoke(PxVehicleGraph* @this, float* xMin, float* yMin, float* xMax, float* yMax);

    public unsafe void getBackgroundCoords(float* xMin, float* yMin, float* xMax, float* yMax)
    {
        fixed (PxVehicleGraph* @this = &this)
        { getBackgroundCoords_PInvoke(@this, xMin, yMin, xMax, yMax); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?computeGraphChannel@PxVehicleGraph@physx@@QEBAXIPEAMPEAVPxVec3@2@PEAD@Z", ExactSpelling = true)]
    private static extern void computeGraphChannel_PInvoke(PxVehicleGraph* @this, uint channel, float* xy, PxVec3* colors, byte* title);

    public unsafe void computeGraphChannel(uint channel, float* xy, PxVec3* colors, byte* title)
    {
        fixed (PxVehicleGraph* @this = &this)
        { computeGraphChannel_PInvoke(@this, channel, xy, colors, title); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getLatestValue@PxVehicleGraph@physx@@QEBAMI@Z", ExactSpelling = true)]
    private static extern float getLatestValue_PInvoke(PxVehicleGraph* @this, uint channel);

    public unsafe float getLatestValue(uint channel)
    {
        fixed (PxVehicleGraph* @this = &this)
        { return getLatestValue_PInvoke(@this, channel); }
    }

    [FieldOffset(0)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_12 mChannelMinY;

    [FieldOffset(48)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_12 mChannelMaxY;

    [FieldOffset(96)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_12 mChannelMidY;

    [FieldOffset(144)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxVec3_12 mChannelColorLow;

    [FieldOffset(288)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxVec3_12 mChannelColorHigh;

    [FieldOffset(432)] public ConstantArray_char__UNICODE_0020____UNICODE_005B__256__UNICODE_005D___12 mChannelTitle;

    [FieldOffset(3504)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal__UNICODE_0020____UNICODE_005B__256__UNICODE_005D___12 mChannelSamples;

    [FieldOffset(15792)] public PxVec3 mBackgroundColor;

    [FieldOffset(15804)] public float mBackgroundAlpha;

    [FieldOffset(15808)] public float mBackgroundMinX;

    [FieldOffset(15812)] public float mBackgroundMaxX;

    [FieldOffset(15816)] public float mBackgroundMinY;

    [FieldOffset(15820)] public float mBackgroundMaxY;

    [FieldOffset(15824)] public uint mSampleTide;

    [FieldOffset(15828)] public uint mNbChannels;

    [FieldOffset(15832)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32_2 mPad;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setup@PxVehicleGraph@physx@@AEAAXMMMMQEBM0AEBVPxVec3@2@11@Z", ExactSpelling = true)]
    private static extern void setup_PInvoke(PxVehicleGraph* @this, float graphSizeX, float graphSizeY, float engineGraphPosX, float engineGraphPosY, float* wheelGraphPosX, float* wheelGraphPosY, PxVec3* backgroundColor, PxVec3* lineColorHigh, PxVec3* lineColorLow);

    public unsafe void setup(float graphSizeX, float graphSizeY, float engineGraphPosX, float engineGraphPosY, float* wheelGraphPosX, float* wheelGraphPosY, PxVec3* backgroundColor, PxVec3* lineColorHigh, PxVec3* lineColorLow)
    {
        fixed (PxVehicleGraph* @this = &this)
        { setup_PInvoke(@this, graphSizeX, graphSizeY, engineGraphPosX, engineGraphPosY, wheelGraphPosX, wheelGraphPosY, backgroundColor, lineColorHigh, lineColorLow); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?updateTimeSlice@PxVehicleGraph@physx@@AEAAXQEBM@Z", ExactSpelling = true)]
    private static extern void updateTimeSlice_PInvoke(PxVehicleGraph* @this, float* samples);

    public unsafe void updateTimeSlice(float* samples)
    {
        fixed (PxVehicleGraph* @this = &this)
        { updateTimeSlice_PInvoke(@this, samples); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setChannel@PxVehicleGraph@physx@@AEAAXAEAUPxVehicleGraphChannelDesc@2@I@Z", ExactSpelling = true)]
    private static extern void setChannel_PInvoke(PxVehicleGraph* @this, PxVehicleGraphChannelDesc* desc, uint channel);

    public unsafe void setChannel(PxVehicleGraphChannelDesc* desc, uint channel)
    {
        fixed (PxVehicleGraph* @this = &this)
        { setChannel_PInvoke(@this, desc, channel); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setupEngineGraph@PxVehicleGraph@physx@@AEAAXMMMMAEBVPxVec3@2@00@Z", ExactSpelling = true)]
    private static extern void setupEngineGraph_PInvoke(PxVehicleGraph* @this, float sizeX, float sizeY, float posX, float posY, PxVec3* backgoundColor, PxVec3* lineColorHigh, PxVec3* lineColorLow);

    public unsafe void setupEngineGraph(float sizeX, float sizeY, float posX, float posY, PxVec3* backgoundColor, PxVec3* lineColorHigh, PxVec3* lineColorLow)
    {
        fixed (PxVehicleGraph* @this = &this)
        { setupEngineGraph_PInvoke(@this, sizeX, sizeY, posX, posY, backgoundColor, lineColorHigh, lineColorLow); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setupWheelGraph@PxVehicleGraph@physx@@AEAAXMMMMAEBVPxVec3@2@00@Z", ExactSpelling = true)]
    private static extern void setupWheelGraph_PInvoke(PxVehicleGraph* @this, float sizeX, float sizeY, float posX, float posY, PxVec3* backgoundColor, PxVec3* lineColorHigh, PxVec3* lineColorLow);

    public unsafe void setupWheelGraph(float sizeX, float sizeY, float posX, float posY, PxVec3* backgoundColor, PxVec3* lineColorHigh, PxVec3* lineColorLow)
    {
        fixed (PxVehicleGraph* @this = &this)
        { setupWheelGraph_PInvoke(@this, sizeX, sizeY, posX, posY, backgoundColor, lineColorHigh, lineColorLow); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleGraph@physx@@AEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxVehicleGraph* @this);

    public unsafe void Constructor()
    {
        fixed (PxVehicleGraph* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??_DPxVehicleGraph@physx@@AEAAXXZ", ExactSpelling = true)]
    private static extern void Destructor_PInvoke(PxVehicleGraph* @this);

    public unsafe void Destructor()
    {
        fixed (PxVehicleGraph* @this = &this)
        { Destructor_PInvoke(@this); }
    }
}