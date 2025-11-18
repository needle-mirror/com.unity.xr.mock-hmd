using Unity.XR.MockHMD;
using UnityEditor.XR.Management;

/// <summary>
/// Build processor for Mock HMD XR Plugin
/// </summary>
public class MockHMDBuildProcessor : XRBuildHelper<MockHMDBuildSettings>
{
    /// <inheritdoc />
    public override string BuildSettingsKey => "xr.sdk.mock-hmd.settings";
}
