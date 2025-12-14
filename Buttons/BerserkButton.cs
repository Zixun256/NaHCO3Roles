using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using NaHCO3Roles.Roles;
using UnityEngine;

namespace NaHCO3Roles.Buttons
{
    public class BerserkButton : CustomActionButton
    {
        private readonly PlayerControl player = PlayerControl.LocalPlayer;
        public override string Name => "红温";
        public override float Cooldown => 20f;
        public override LoadableAsset<Sprite> Sprite => NAssets.BerserkButton;
        public override bool Enabled(RoleBehaviour role)
        {
            return role is Berserker;
        }

        protected override void OnClick()
        {
            player.NetTransform.Halt();
            player.MyPhysics.SetBodyType(PlayerBodyTypes.Seeker);
            player.AnimateCustom(HudManager.Instance.IntroPrefab.HnSSeekerSpawnAnim);
            Berserker.IsBerserk = true;
            player.MyPhysics.Animations.Animator.SetTime(7.4f);
            player.cosmetics.SetBodyCosmeticsVisible(false);
        }
        public override void OnEffectEnd()
        {
            player.NetTransform.Halt();
            player.MyPhysics.SetBodyType(PlayerBodyTypes.Seeker);
            Berserker.IsBerserk = false;
            player.cosmetics.SetBodyCosmeticsVisible(true);
        }
    }
}
