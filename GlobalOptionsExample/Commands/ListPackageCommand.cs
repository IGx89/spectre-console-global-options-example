using GlobalOptionsExample.Settings;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace GlobalOptionsExample.Commands;

public class ListPackageCommand : Command<ListPackageCommand.Settings>
{
    public class Settings : ListSettings
    { }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
    {
        Console.WriteLine($"Project: {settings.Project}");
        return 0;
    }
}
