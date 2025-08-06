using System;
using System.Collections.Generic;
using LabApi.Features;
using LabApi.Features.Console;
using LabApi.Features.Wrappers;
using LabApi.Loader.Features.Plugins;

namespace test;

public class PluginEntry : Plugin
{
    public override string Name { get; } = "UnLimitAmmo";
    public override string Description { get; } = "beta";
    public override string Author { get; } = "Xalent";
    public override Version Version { get; } = new(1, 0, 0);
    public override Version RequiredApiVersion { get; } = LabApiProperties.CurrentVersion;
    public static List<Player> InfBoxOfAmmo = new();
    
    public override void Enable()
    {
        Logger.Info($"Плагин включён");
    }

    public override void Disable()
    {
        throw new NotImplementedException();
    }
}