using MiraAPI.Roles;
using UnityEngine;

namespace NaHCO3Roles.Roles
{
    public class Berserker : ImpostorRole, ICustomRole
    {
        public string RoleName => "红温者";

        public string RoleDescription => "我饿啦!!!";

        public string RoleLongDescription => "红温者是一个简单直白的职业。<br>进入暴怒状态后，攻击冷却和移动速度会更快，但所有人都会知晓你的身份。";

        public Color RoleColor => Color.red;

        public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
        public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
        {
            CanModifyChance = true,
            DefaultChance = 50,
            DefaultRoleCount = 1
        };

    }
}
