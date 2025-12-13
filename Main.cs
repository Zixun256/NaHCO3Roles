using BepInEx;
using BepInEx.Unity.IL2CPP;
using NaHCO3;

namespace NaHCO3Roles
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInDependency(NaHCO3.Main.PLUGIN_GUID)]
    public class Main : BasePlugin
    {
        public override void Load()
        {
            Logger.Info("碳酸氢钠的职业附加加载成功!", "NaHCO3Roles");
        }
    }
}
