// This file was automatically generated by Biohazrd and should not be modified by hand!
using System;

[Flags]
public enum PxPairFlags : ushort
{
    eSOLVE_CONTACT = 1,
    eMODIFY_CONTACTS = 2,
    eNOTIFY_TOUCH_FOUND = 4,
    eNOTIFY_TOUCH_PERSISTS = 8,
    eNOTIFY_TOUCH_LOST = 16,
    eNOTIFY_TOUCH_CCD = 32,
    eNOTIFY_THRESHOLD_FORCE_FOUND = 64,
    eNOTIFY_THRESHOLD_FORCE_PERSISTS = 128,
    eNOTIFY_THRESHOLD_FORCE_LOST = 256,
    eNOTIFY_CONTACT_POINTS = 512,
    eDETECT_DISCRETE_CONTACT = 1024,
    eDETECT_CCD_CONTACT = 2048,
    ePRE_SOLVER_VELOCITY = 4096,
    ePOST_SOLVER_VELOCITY = 8192,
    eCONTACT_EVENT_POSE = 16384,
    eNEXT_FREE = 32768,
    eCONTACT_DEFAULT = 1025,
    eTRIGGER_DEFAULT = 1044
}
