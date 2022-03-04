using Spectre.Console.Cli;

namespace GlobalOptionsExample.Settings;

public class ListSettings : GlobalSettings
{
    [CommandArgument(0, "<PROJECT>")]
    public string Project { get; init; } = null!;
}
