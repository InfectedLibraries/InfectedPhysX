// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

public unsafe static partial class PxSimpleFactory
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCreateDynamic@physx@@YAPEAVPxRigidDynamic@1@AEAVPxPhysics@1@AEBVPxTransform@1@AEBVPxGeometry@1@AEAVPxMaterial@1@M1@Z", ExactSpelling = true)]
    public static extern PxRigidDynamic* PxCreateDynamic(PxPhysics* sdk, PxTransform* transform, PxGeometry* geometry, PxMaterial* material, float density, PxTransform* shapeOffset);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCreateDynamic@physx@@YAPEAVPxRigidDynamic@1@AEAVPxPhysics@1@AEBVPxTransform@1@AEAVPxShape@1@M@Z", ExactSpelling = true)]
    public static extern PxRigidDynamic* PxCreateDynamic(PxPhysics* sdk, PxTransform* transform, PxShape* shape, float density);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCreateKinematic@physx@@YAPEAVPxRigidDynamic@1@AEAVPxPhysics@1@AEBVPxTransform@1@AEBVPxGeometry@1@AEAVPxMaterial@1@M1@Z", ExactSpelling = true)]
    public static extern PxRigidDynamic* PxCreateKinematic(PxPhysics* sdk, PxTransform* transform, PxGeometry* geometry, PxMaterial* material, float density, PxTransform* shapeOffset);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCreateKinematic@physx@@YAPEAVPxRigidDynamic@1@AEAVPxPhysics@1@AEBVPxTransform@1@AEAVPxShape@1@M@Z", ExactSpelling = true)]
    public static extern PxRigidDynamic* PxCreateKinematic(PxPhysics* sdk, PxTransform* transform, PxShape* shape, float density);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCreateStatic@physx@@YAPEAVPxRigidStatic@1@AEAVPxPhysics@1@AEBVPxTransform@1@AEBVPxGeometry@1@AEAVPxMaterial@1@1@Z", ExactSpelling = true)]
    public static extern PxRigidStatic* PxCreateStatic(PxPhysics* sdk, PxTransform* transform, PxGeometry* geometry, PxMaterial* material, PxTransform* shapeOffset);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCreateStatic@physx@@YAPEAVPxRigidStatic@1@AEAVPxPhysics@1@AEBVPxTransform@1@AEAVPxShape@1@@Z", ExactSpelling = true)]
    public static extern PxRigidStatic* PxCreateStatic(PxPhysics* sdk, PxTransform* transform, PxShape* shape);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCloneShape@physx@@YAPEAVPxShape@1@AEAVPxPhysics@1@AEBV21@_N@Z", ExactSpelling = true)]
    public static extern PxShape* PxCloneShape(PxPhysics* physicsSDK, PxShape* shape, bool isExclusive);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCloneStatic@physx@@YAPEAVPxRigidStatic@1@AEAVPxPhysics@1@AEBVPxTransform@1@AEBVPxRigidActor@1@@Z", ExactSpelling = true)]
    public static extern PxRigidStatic* PxCloneStatic(PxPhysics* physicsSDK, PxTransform* transform, PxRigidActor* actor);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCloneDynamic@physx@@YAPEAVPxRigidDynamic@1@AEAVPxPhysics@1@AEBVPxTransform@1@AEBV21@@Z", ExactSpelling = true)]
    public static extern PxRigidDynamic* PxCloneDynamic(PxPhysics* physicsSDK, PxTransform* transform, PxRigidDynamic* body);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxCreatePlane@physx@@YAPEAVPxRigidStatic@1@AEAVPxPhysics@1@AEBVPxPlane@1@AEAVPxMaterial@1@@Z", ExactSpelling = true)]
    public static extern PxRigidStatic* PxCreatePlane(PxPhysics* sdk, PxPlane* plane, PxMaterial* material);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxScaleRigidActor@physx@@YAXAEAVPxRigidActor@1@M_N@Z", ExactSpelling = true)]
    public static extern void PxScaleRigidActor(PxRigidActor* actor, float scale, bool scaleMassProps = true);
}