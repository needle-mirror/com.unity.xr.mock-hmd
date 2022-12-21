using Unity.XR.MockHMD;
using UnityEditor.XR.Management;

public class MockHMDBuildProcessor : XRBuildHelper<MockHMDBuildSettings>
{
    /// <inheritdoc />
    public override string BuildSettingsKey => "xr.sdk.mock-hmd.settings";
}
