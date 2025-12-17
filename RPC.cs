using Reactor.Networking.Attributes;

namespace NaHCO3Roles
{
    enum CustomRPC : uint
    {
        Berserk = 70,
        Calmdown
    }
    internal class RPC
    {
        public static class BerserkerRpc
        {
            [MethodRpc((uint) CustomRPC.Berserk)]
            public static void RpcBerserk(PlayerControl pc)
            {
                pc.NetTransform.Halt();
                pc.MyPhysics.SetBodyType(PlayerBodyTypes.Seeker);
                pc.AnimateCustom(HudManager.Instance.IntroPrefab.HnSSeekerSpawnAnim);
                pc.MyPhysics.Animations.Animator.SetTime(7.4f);
                SoundManager.Instance.PlaySound(NAssets.HnSTransformClip.Clip, false);
                pc.SetKillTimer(0);
                pc.cosmetics.SetBodyCosmeticsVisible(false);
                pc.MyPhysics.Speed *= 1.25f;
            }
            [MethodRpc((uint)CustomRPC.Calmdown)]
            public static void RpcCalmdown(PlayerControl pc)
            {
                pc.NetTransform.Halt();
                pc.MyPhysics.SetBodyType(PlayerBodyTypes.Normal);
                pc.cosmetics.SetBodyCosmeticsVisible(true);
                pc.MyPhysics.Speed /= 1.25f;
            }
        }
    }
}
