using MiraAPI.Roles;
using UnityEngine;

namespace NaHCO3Roles.Roles
{
    public class Jackal : ImpostorRole, ICustomRole
    {
        public string RoleName => "豺狼";

        public string RoleDescription => "歼灭所有玩家";

        public string RoleLongDescription => "豺狼杀死其他所有玩家则狼狗获得胜利。<br>跟班存在的场合，豺狼死亡则跟班可以晋升为豺狼。";

        public Color RoleColor => new(8, 190, 245);

        public ModdedRoleTeams Team => ModdedRoleTeams.Custom;

        public CustomRoleConfiguration Configuration => new(this)
        { 
            CanUseVent = true,
            CanUseSabotage = false,
            DefaultChance = 50,
            MaxRoleCount = 1,
            UseVanillaKillButton = true
        };
    }
}
