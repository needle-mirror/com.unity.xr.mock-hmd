using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.XR;
using UnityEngine.XR.Management;

namespace Unity.XR.MockHMD
{
    /// <summary>
    /// Loader for Mock HMD.
    /// </summary>
    public class MockHMDLoader : XRLoaderHelper
    {
        private static List<XRDisplaySubsystemDescriptor> s_DisplaySubsystemDescriptors =
            new List<XRDisplaySubsystemDescriptor>();
        private static List<XRInputSubsystemDescriptor> s_InputSubsystemDescriptors =
            new List<XRInputSubsystemDescriptor>();

        /// <inheritdoc />
        public override bool Initialize()
        {
            CreateSubsystem<XRDisplaySubsystemDescriptor, XRDisplaySubsystem>(s_DisplaySubsystemDescriptors, "MockHMD Display");
            CreateSubsystem<XRInputSubsystemDescriptor, XRInputSubsystem>(s_InputSubsystemDescriptors, "MockHMD Head Tracking");

            var buildSettings = MockHMDBuildSettings.Instance;
            if (buildSettings != null)
            {
                MockHMD.SetRenderMode(buildSettings.renderMode);
                MockHMD.SetFoveationMode(buildSettings.foveationEnabled, 
                                         (uint)buildSettings.gazeSimulationMode);
            }

            return true;
        }

        /// <inheritdoc />
        public override bool Start()
        {
            StartSubsystem<XRDisplaySubsystem>();
            StartSubsystem<XRInputSubsystem>();
            return true;
        }

        /// <inheritdoc />
        public override bool Stop()
        {
            StopSubsystem<XRInputSubsystem>();
            StopSubsystem<XRDisplaySubsystem>();
            return true;
        }

        /// <inheritdoc />
        public override bool Deinitialize()
        {
            DestroySubsystem<XRInputSubsystem>();
            DestroySubsystem<XRDisplaySubsystem>();
            return true;
        }
    }
}
