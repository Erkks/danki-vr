using UnityEngine;
using UnityEditor;

public class OptimizePerformance : MonoBehaviour {
    void Start()
        {
            // "We sync in the TimeWarp, so we don't want unity syncing elsewhere." - OVRMoonlightLoader.cs
            QualitySettings.vSyncCount                                    = 0;
            Debug.Log("helllloooo");

            // "For CPU performance, please don't use render scale over 1.5." - OVRLint.cs
            UnityEngine.XR.XRSettings.eyeTextureResolutionScale            = 2f;

            // Avoid throttling the CPU or GPU at all, 2 is the maximum setting, 0 is the
            // minimum (providing longest battery life).
            #if !UNITY_EDITOR
            //OVRPlugin.cpuLevel                                        = 2;
            //OVRPlugin.gpuLevel                                        = 2;
            #endif

            // Multi Sampled Anti Aliasing
            #if UNITY_EDITOR
            QualitySettings.antiAliasing                                = 8;    // Make things look smooth in the editor
            #else
            QualitySettings.antiAliasing                                = 8;    // 2x MSAA    
            #endif

            // "Anisotropic filtering is recommended for optimal quality and performance" - OVRLint.cs
            QualitySettings.anisotropicFiltering                        = AnisotropicFiltering.Enable;

            // "For GPU performance, please use ASTC" - OVRLint.cs, however for
            // maxium cardboard compatibility use ETC2
            #if UNITY_EDITOR
            EditorUserBuildSettings.androidBuildSubtarget                = MobileTextureSubtarget.ETC2;
            #endif
        }
}