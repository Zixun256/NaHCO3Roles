using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using NaHCO3Roles.Roles;

namespace NaHCO3Roles.Options.Roles
{
    public class BerserkerOptions : AbstractOptionGroup<Berserker>
    {
        public override string GroupName => "红温者设置";
        [ModdedNumberOption("红温冷却", 5, 40, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float BerserkCooldown { get; set; } = 10;
        [ModdedNumberOption("红温持续时间", 20, 150, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float BerserkDuration { get; set; } = 20;
    }
}
