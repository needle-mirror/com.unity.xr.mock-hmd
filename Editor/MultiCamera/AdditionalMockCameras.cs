using System;
using System.Collections.Generic;

using UnityEngine;

namespace MockHMD.Editor.MultiCamera
{
    /// <summary>
    /// Enumeration of mock rendering modes for the additional cameras.
    /// </summary>
    public enum MockRenderingMode
    {
        /// <summary>
        /// No stereo rendering.
        /// </summary>
        None,

        /// <summary>
        /// Multi-pass stereo rendering.
        /// </summary>
        MultiPass,

        /// <summary>
        /// Single-pass instance stereo rendering.
        /// </summary>
        SinglePassInstance,
    }

    /// <summary>
    /// Represents a mock camera with configurable properties.
    /// </summary>
    [System.Serializable]
    public class MockCamera
    {
        /// <summary>
        /// Unique identifier for the mock camera.
        /// </summary>
        [SerializeField]
        public int id;

        /// <summary>
        /// Position of the mock camera in 3D space.
        /// </summary>
        [SerializeField]
        public Vector3 position;

        /// <summary>
        /// Rotation of the mock camera as a quaternion.
        /// </summary>
        [SerializeField]
        public Quaternion rotation;

        /// <summary>
        /// Field of view of the mock camera.
        /// </summary>
        [SerializeField]
        public float fov = 60.0f;

        /// <summary>
        /// Near clipping plane distance of the mock camera.
        /// </summary>
        [SerializeField]
        public float near = 0.3f;

        /// <summary>
        /// Far clipping plane distance of the mock camera.
        /// </summary>
        [SerializeField]
        public float far = 1000.0f;

        /// <summary>
        /// Texture width of the mock camera.
        /// </summary>
        [SerializeField]
        public int textureWidth = 100;

        /// <summary>
        /// Texture height of the mock camera.
        /// </summary>
        [SerializeField]
        public int textureHeight = 100;

        /// <summary>
        /// Stereo rendering mode of the mock camera.
        /// </summary>
        [SerializeField]
        public MockRenderingMode stereoRenderingMode = MockRenderingMode.None;

        /// <summary>
        /// Eye separation distance for stereo rendering.
        /// </summary>
        [SerializeField]
        public float eyeSeparation = 0.2f;

        /// <summary>
        /// Left eye chromatic aberration correction.
        /// </summary>
        [SerializeField]
        public Vector2 leftAbberation;

        /// <summary>
        /// Right eye chromatic aberration correction.
        /// </summary>
        [SerializeField]
        public Vector2 rightAbberation;

        /// <summary>
        /// Enable occlusion for the left eye.
        /// </summary>
        [SerializeField]
        public bool enableLeftOcclusion;

        /// <summary>
        /// Enable occlusion for the right eye.
        /// </summary>
        [SerializeField]
        public bool enableRightOcclusion;

        /// <summary>
        /// Whether the mock camera is active.
        /// </summary>
        [SerializeField]
        public bool isActive;

    }

    /// <summary>
    /// Container for a list of additional mock cameras.
    /// </summary>
    [System.Serializable]
    public class AdditionalMockCameras
    {
        /// <summary>
        /// List of additional mock cameras.
        /// </summary>
        [SerializeField]
        public List<MockCamera> extraCameras = new List<MockCamera>();
    }
}
