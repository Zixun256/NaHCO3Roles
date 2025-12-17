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
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
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
            ReactorCredits.Register(PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION, false, null);
            NaHCO3.Logger.Info("碳酸氢钠的职业附加加载成功!", "NaHCO3Roles");
        }
    }
    public static class PluginInfo
    {
        public const string PLUGIN_GUID = "NaHCO3Roles";
        public const string PLUGIN_NAME = "NaHCO3Roles";
        public const string PLUGIN_VERSION = "v1.1.2";
    }
}
