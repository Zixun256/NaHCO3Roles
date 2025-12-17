using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace NaHCO3Roles
{
    public static class NAssets
    {
        public class VanillaAudioClip
        {
            public static T FindAsset<T>(string name) where T : Il2CppObjectBase
            {
                foreach (var asset in UnityEngine.Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<T>()))
                {
                    if (asset.name == name) return asset.Cast<T>();
                }
                return null;
            }
            private string name;
            private AudioClip clip = null;
            public AudioClip Clip
            {
                get
                {
                    if (clip) return clip;
                    clip = FindAsset<AudioClip>(name);
                    return clip!;
                }
            }

            public VanillaAudioClip(string name)
            {
                this.name = name;
            }
        }
        public static LoadableResourceAsset BerserkButton { get; } = new("NaHCO3Roles.Resources.BerserkButton.png");
        static public VanillaAudioClip HnSTransformClip { get; private set; } = new("HnS_ImpostorScream");
    }
}
