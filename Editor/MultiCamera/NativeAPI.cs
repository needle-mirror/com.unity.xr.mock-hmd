using System;
using System.Runtime.InteropServices;

using UnityEngine;

namespace MockHMD.Editor.MultiCamera
{
    /// <summary>
    /// Native API interface for interacting with the mock HMD cameras.
    /// </summary>
    public static class NativeApi
    {
        /// <summary>
        /// Represents a 3D vector with float components.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct float3
        {
            /// <summary>
            /// The X component of the vector.
            /// </summary>
            public float x;

            /// <summary>
            /// The Y component of the vector.
            /// </summary>
            public float y;

            /// <summary>
            /// The Z component of the vector.
            /// </summary>
            public float z;
        }

        /// <summary>
        /// Represents a 4D vector with float components.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct float4
        {
            /// <summary>
            /// The X component of the vector.
            /// </summary>
            public float x;

            /// <summary>
            /// The Y component of the vector.
            /// </summary>
            public float y;

            /// <summary>
            /// The Z component of the vector.
            /// </summary>
            public float z;

            /// <summary>
            /// The W component of the vector.
            /// </summary>
            public float w;
        }

        /// <summary>
        /// Structure representing the properties of a mock camera.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MockCameraProperties
        {
            /// <summary>
            /// Position of the mock camera.
            /// </summary>
            public float3 position;

            /// <summary>
            /// Rotation of the mock camera.
            /// </summary>
            public float4 rotation;

            /// <summary>
            /// Field of view of the mock camera.
            /// </summary>
            public float fov;

            /// <summary>
            /// Near clipping plane distance of the mock camera.
            /// </summary>
            public float near;

            /// <summary>
            /// Far clipping plane distance of the mock camera.
            /// </summary>
            public float far;

            /// <summary>
            /// Texture width of the mock camera.
            /// </summary>
            public int textureWidth;

            /// <summary>
            /// Texture height of the mock camera.
            /// </summary>
            public int textureHeight;

            /// <summary>
            /// Rendering mode of the mock camera.
            /// </summary>
            public int renderingMode;

            /// <summary>
            /// Eye separation distance for stereo rendering.
            /// </summary>
            public float eyeSeparation;

            /// <summary>
            /// Left lens chromatic aberration correction.
            /// </summary>
            public float3 leftAbberation;

            /// <summary>
            /// Right lens chromatic aberration correction.
            /// </summary>
            public float3 rightAbberation;

            /// <summary>
            /// Enable left occlusion.
            /// </summary>
            public int enableLeftOcclusion;

            /// <summary>
            /// Enable right occlusion.
            /// </summary>
            public int enableRightOcclusion;
        }

        /// <summary>
        /// Checks if a camera with the specified ID exists.
        /// </summary>
        /// <param name="id">The ID of the camera to check.</param>
        /// <returns>True if the camera exists, false otherwise.</returns>
        [DllImport("Packages/com.unity.xr.mock-hmd/Runtime/Windows/x64/UnityMockHMD.dll", CharSet = CharSet.Auto)]
        public static extern bool HasCameraWithId(int id);

        /// <summary>
        /// Adds a camera with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the camera to add.</param>
        /// <returns>True if the camera was added successfully, false otherwise.</returns>
        [DllImport("Packages/com.unity.xr.mock-hmd/Runtime/Windows/x64/UnityMockHMD.dll", CharSet = CharSet.Auto)]
        public static extern bool AddCameraWithId(int id);

        /// <summary>
        /// Updates the properties of a camera with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the camera to update.</param>
        /// <param name="properties">The new properties for the camera.</param>
        /// <returns>True if the camera was updated successfully, false otherwise.</returns>
        [DllImport("Packages/com.unity.xr.mock-hmd/Runtime/Windows/x64/UnityMockHMD.dll", CharSet = CharSet.Auto)]
        public static extern bool UpdateCameraWithId(int id, MockCameraProperties properties);

        /// <summary>
        /// Removes a camera with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the camera to remove.</param>
        /// <returns>True if the camera was removed successfully, false otherwise.</returns>
        [DllImport("Packages/com.unity.xr.mock-hmd/Runtime/Windows/x64/UnityMockHMD.dll", CharSet = CharSet.Auto)]
        public static extern bool RemoveCameraWithId(int id);

    }
}
