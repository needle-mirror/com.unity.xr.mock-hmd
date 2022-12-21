using System.Runtime.InteropServices;

namespace Unity.XR.MockHMD
{
    /// <summary>
    /// Runtime scripting API for Mock HMD provider.
    /// </summary>
    public static class MockHMD
    {
#if UNITY_IOS
        private const string LibraryName = "__Internal";
#else
        private const string LibraryName = "UnityMockHMD";
#endif

        /// <summary>
        /// Set the stereo rendering mode.
        /// </summary>
        /// <param name="renderMode">rendering mode</param>
        /// <returns>true if render mode successfully set</returns>
        [DllImport(LibraryName, EntryPoint = "NativeConfig_SetRenderMode")]
        public static extern bool SetRenderMode(MockHMDBuildSettings.RenderMode renderMode);

        /// <summary>
        /// Set the resolution of the eye textures.
        /// </summary>
        /// <param name="width">width of eye texture</param>
        /// <param name="height">height of eye texture</param>
        /// <returns>true if eye texture resolution successfully set</returns>
        [DllImport(LibraryName, EntryPoint = "NativeConfig_SetEyeResolution")]
        public static extern bool SetEyeResolution(int width, int height);

        /// <summary>
        /// Set the crop value applied when rendering the mirror view.
        /// This is useful to remove the peripheral distorted part of the image.
        /// </summary>
        /// <param name="crop">the amount to remove from the image, valid range is 0.0 to 0.5</param>
        /// <returns>true if mirror view crop successfully set</returns>
        [DllImport(LibraryName, EntryPoint = "NativeConfig_SetMirrorViewCrop")]
        public static extern bool SetMirrorViewCrop(float crop);
    }
}