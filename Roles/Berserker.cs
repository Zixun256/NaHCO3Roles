using MiraAPI.Roles;
using UnityEngine;

namespace NaHCO3Roles.Roles
{
    public class Berserker : ImpostorRole, ICustomRole
    {
        public string RoleName => "红温者";

        public string RoleDescription => "我饿啦!!!";

        public string RoleLongDescription => "作为红温者，当点击红温按钮时，你的击杀冷却会变得极短，移速也会加快";

        public Color RoleColor => Color.red;

        public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

        public static bool IsBerserk = false;
        public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
        {
            CanModifyChance = true,
            DefaultChance = 50,
            DefaultRoleCount = 1
        };
    }
}
