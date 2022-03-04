using Spectre.Console.Cli;

namespace GlobalOptionsExample.Settings;

public class GlobalSettings : CommandSettings
{
    [CommandOption("-v|--verbosity")]
    public int Verbosity { get; set; }
}
