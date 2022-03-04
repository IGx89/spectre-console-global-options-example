using GlobalOptionsExample.Settings;
using Spectre.Console.Cli;

namespace GlobalOptionsExample.Infrastructure;

public class GlobalSettingsInterceptor : ICommandInterceptor
{
    public void Intercept(CommandContext context, CommandSettings settings)
    {
        if (settings is GlobalSettings globalSettings)
        {
            Console.WriteLine($"Verbosity: {globalSettings.Verbosity}");
        }
    }
}
