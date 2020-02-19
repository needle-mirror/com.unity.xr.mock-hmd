using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

namespace Unity.XR.MockHMD
{
    /// <summary>
    /// Build-time settings for MockHMD provider.
    /// </summary>
    [XRConfigurationData("MockHMD", "xr.sdk.mock-hmd.settings")]
    public class MockHMDBuildSettings : ScriptableObject
    {
        /// <summary>
        /// Stereo rendering mode.
        /// </summary>
        public enum RenderMode
        {
            /// <summary>
            /// Submit separate draw calls for each eye.
            /// </summary>
            MultiPass,

            /// <summary>
            /// Submit one draw call for both eyes.
            /// </summary>
            SinglePassInstanced,
        };

        /// <summary>
        /// Stereo rendering mode.
        /// </summary>
        public RenderMode renderMode;

        /// <summary>
        /// Runtime access to build settings. 
        /// </summary>
        public static MockHMDBuildSettings Instance;

        void OnEnable()
        {
            Instance = this;
        }
    }
}