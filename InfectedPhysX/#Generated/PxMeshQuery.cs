// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 1)]
public unsafe partial struct PxMeshQuery
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getTriangle@PxMeshQuery@physx@@SAXAEBVPxTriangleMeshGeometry@2@AEBVPxTransform@2@IAEAVPxTriangle@2@PEAI3@Z", ExactSpelling = true)]
    public static extern void getTriangle(PxTriangleMeshGeometry* triGeom, PxTransform* transform, uint triangleIndex, PxTriangle* triangle, uint* vertexIndices = null, uint* adjacencyIndices = null);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getTriangle@PxMeshQuery@physx@@SAXAEBVPxHeightFieldGeometry@2@AEBVPxTransform@2@IAEAVPxTriangle@2@PEAI3@Z", ExactSpelling = true)]
    public static extern void getTriangle(PxHeightFieldGeometry* hfGeom, PxTransform* transform, uint triangleIndex, PxTriangle* triangle, uint* vertexIndices = null, uint* adjacencyIndices = null);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?findOverlapTriangleMesh@PxMeshQuery@physx@@SAIAEBVPxGeometry@2@AEBVPxTransform@2@AEBVPxTriangleMeshGeometry@2@1PEAIIIAEA_N@Z", ExactSpelling = true)]
    public static extern uint findOverlapTriangleMesh(PxGeometry* geom, PxTransform* geomPose, PxTriangleMeshGeometry* meshGeom, PxTransform* meshPose, uint* results, uint maxResults, uint startIndex, bool* overflow);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?findOverlapHeightField@PxMeshQuery@physx@@SAIAEBVPxGeometry@2@AEBVPxTransform@2@AEBVPxHeightFieldGeometry@2@1PEAIIIAEA_N@Z", ExactSpelling = true)]
    public static extern uint findOverlapHeightField(PxGeometry* geom, PxTransform* geomPose, PxHeightFieldGeometry* hfGeom, PxTransform* hfPose, uint* results, uint maxResults, uint startIndex, bool* overflow);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?sweep@PxMeshQuery@physx@@SA_NAEBVPxVec3@2@MAEBVPxGeometry@2@AEBVPxTransform@2@IPEBVPxTriangle@2@AEAUPxSweepHit@2@V?$PxFlags@W4Enum@PxHitFlag@physx@@G@2@PEBIM_N@Z", ExactSpelling = true)]
    public static extern bool sweep(PxVec3* unitDir, float distance, PxGeometry* geom, PxTransform* pose, uint triangleCount, PxTriangle* triangles, PxSweepHit* sweepHit, PxHitFlags hitFlags, uint* cachedIndex = null, float inflation = 0f, bool doubleSided = false);
}
