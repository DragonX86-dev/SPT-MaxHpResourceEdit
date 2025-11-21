using SPTarkov.Server.Core.Models.Spt.Mod;
using Range = SemanticVersioning.Range;
using Version = SemanticVersioning.Version;

namespace MaxHpResourceEdit;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.dragonx86.max-hp-resource-edit";
    public override string Name { get; init; } = "MaxHpResourceEdit";
    public override string Author { get; init; } = "DragonX86-dev";
    public override List<string>? Contributors { get; init; }
    public override Version Version { get; init; } = new("1.0.0");
    public override Range SptVersion { get; init; } = new("~4.0.0");
    public override List<string>? Incompatibilities { get; init; }
    public override Dictionary<string, Range>? ModDependencies { get; init; }
    public override string? Url { get; init; } = "https://github.com/DragonX86-dev/SPT-MaxHpResourceEdit";
    public override bool? IsBundleMod { get; init; }
    public override string License { get; init; } = "MIT";
}