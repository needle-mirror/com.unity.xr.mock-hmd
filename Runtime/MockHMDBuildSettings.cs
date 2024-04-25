using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

namespace Unity.XR.MockHMD
{
    /// <summary>
    /// Build-time settings for MockHMD provider.
    /// </summary>
    [XRConfigurationData("MockHMD", MockHMDBuildSettings.BuildSettingsKey)]
    public class MockHMDBuildSettings : ScriptableObject
    {
        /// <summary>
        /// Key that build settings are indexed by in EditorBuildSettings.
        /// </summary>
        public const string BuildSettingsKey = "xr.sdk.mock-hmd.settings";

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
        /// Foveation Gaze Simulation Mode.
        /// </summary>
        public enum FoveationGazeSimulationMode
        {
            /// <summary>
            /// Gaze at the center of the view
            /// </summary>
            Disabled = 0,
            
            /// <summary>
            /// Gaze at the center of the view
            /// </summary>
            StaticCenter,

            /// <summary>
            /// Gaze look left and right (both eyes use same direction)
            /// </summary>
            MovementLeftRight,

            /// <summary>
            /// Gaze with independent movement for both eyes (Left eyemove up/down and right eye moves left/right)
            /// </summary>
            MovementEyeIndependent,
        };

        /// <summary>
        /// Stereo rendering mode.
        /// </summary>
        public RenderMode renderMode;

        [Header("Foveated Rendering")]
        /// <summary>
        /// Enable foveated rendering mode.
        /// </summary>
#if !UNITY_2022_3 && !UNITY_2023_3_OR_NEWER
        [System.NonSerialized]
#endif
        public bool foveationEnabled = false;

        /// <summary>
        /// Foveation Gaze simulation mode to use
        /// </summary>
        [Tooltip("Select how the gaze directions should be generated.  \nNote: Some GPUs/API don't support having different data for both eyes when rendering using SinglePass, having different patterns in both eyes won't work for them.")]
#if !UNITY_2022_3 && !UNITY_2023_3_OR_NEWER
        [System.NonSerialized]
#endif
        public FoveationGazeSimulationMode gazeSimulationMode = FoveationGazeSimulationMode.Disabled;

        /// <summary>
        /// Runtime access to build settings.
        /// </summary>
        public static MockHMDBuildSettings Instance
        {
            get
            {
                MockHMDBuildSettings settings = null;
#if UNITY_EDITOR
                UnityEngine.Object obj = null;
                UnityEditor.EditorBuildSettings.TryGetConfigObject(BuildSettingsKey, out obj);
                if (obj == null || !(obj is MockHMDBuildSettings))
                    return null;
                settings = (MockHMDBuildSettings) obj;
#else
                settings = s_RuntimeInstance;
                if (settings == null)
                    settings = new MockHMDBuildSettings();
#endif
                return settings;
            }
        }

#if !UNITY_EDITOR
        /// <summary>Static instance that will hold the runtime asset instance we created in our build process.</summary>
        public static MockHMDBuildSettings s_RuntimeInstance = null;

        void OnEnable()
        {
            s_RuntimeInstance = this;
        }
#endif
    }
}