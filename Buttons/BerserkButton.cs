using HarmonyLib;
using MiraAPI.Hud;
using MiraAPI.Keybinds;
using MiraAPI.Utilities.Assets;
using NaHCO3.Modules;
using NaHCO3Roles.Roles;
using UnityEngine;

namespace NaHCO3Roles.Buttons
{
    public class BerserkButton : CustomActionButton
    {
        public override string Name => "红温";
        public override float Cooldown => 20f;
        public override float EffectDuration => 60f;
        public override BaseKeybind Keybind => MiraGlobalKeybinds.PrimaryAbility;
        public override LoadableAsset<Sprite> Sprite => NAssets.BerserkButton;
        public override bool Enabled(RoleBehaviour role)
        {
            return role is Berserker;
        }

        protected override void OnClick()
        {
            RPC.BerserkerRpc.RpcBerserk(PlayerControl.LocalPlayer);
        }
        public override void OnEffectEnd()
        {
            RPC.BerserkerRpc.RpcCalmdown(PlayerControl.LocalPlayer);
        }
    }
}
