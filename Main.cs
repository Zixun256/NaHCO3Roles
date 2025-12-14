using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using MiraAPI.PluginLoading;
using MiraAPI;
using Reactor;
using Reactor.Networking.Attributes;
using Reactor.Utilities;

namespace NaHCO3Roles
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(NaHCO3.Main.PLUGIN_GUID)]
    [BepInDependency(MiraApiPlugin.Id)]
    [BepInDependency(ReactorPlugin.Id)]
    [ReactorModFlags(Reactor.Networking.ModFlags.RequireOnAllClients)]
    public class Main : BasePlugin, IMiraPlugin
    {
        public string OptionsTitleText => "NaHCO3Roles";
        public ConfigFile GetConfigFile() => Config;
        public override void Load()
        {
            ReactorCredits.Register(MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION, false, null);
            NaHCO3.Logger.Info("碳酸氢钠的职业附加加载成功!", "NaHCO3Roles");
        }
    }
}
