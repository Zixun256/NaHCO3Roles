using MiraAPI.Roles;
using UnityEngine;

namespace NaHCO3Roles.Roles;

public class TeleporterRole : CrewmateRole, ICustomRole
{
    public string RoleName => "传送师";
    public string RoleLongDescription => "缩小视角并在地图上瞬移！";
    public string RoleDescription => RoleLongDescription;
    public Color RoleColor => new Color32(221, 176, 152, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        CanModifyChance = true,
        DefaultChance = 50,
        DefaultRoleCount = 1,
    };

    public bool CanLocalPlayerSeeRole(PlayerControl player)
    {
        return true;
    }
}