using System;
using System.Diagnostics.CodeAnalysis;
using CommandSystem;
using InventorySystem.Configs;
using LabApi.Features.Wrappers;

namespace test.Commands;

[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class Inf : ICommand
{
    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, [UnscopedRef] out string response)
    {
        ServerConfigSynchronizer.Singleton.AmmoLimitsSync.Clear();
        ServerConfigSynchronizer.Singleton.AmmoLimitsSync.Add(new()
            { AmmoType = ItemType.Ammo9x19, Limit = ushort.MaxValue });
        ServerConfigSynchronizer.Singleton.AmmoLimitsSync.Add(new()
            { AmmoType = ItemType.Ammo762x39, Limit = ushort.MaxValue });
        ServerConfigSynchronizer.Singleton.AmmoLimitsSync.Add(new()
            { AmmoType = ItemType.Ammo44cal, Limit = ushort.MaxValue });
        ServerConfigSynchronizer.Singleton.AmmoLimitsSync.Add(new()
            { AmmoType = ItemType.Ammo12gauge, Limit = ushort.MaxValue });
        ServerConfigSynchronizer.Singleton.AmmoLimitsSync.Add(new()
            { AmmoType = ItemType.Ammo556x45, Limit = ushort.MaxValue });
        response = "ok";
        return true;
    }

    public string Command { get; } = "AmmoLimitDisable";
    public string[] Aliases { get; } = [];
    public string Description { get; } = "Unlimit Ammo has disable";
}