using GlobalOptionsExample.Commands;
using GlobalOptionsExample.Infrastructure;
using GlobalOptionsExample.Settings;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(config =>
{
    config.SetInterceptor(new GlobalSettingsInterceptor());

    config.AddBranch<ListSettings>("list", wasp =>
    {
        wasp.AddCommand<ListPackageCommand>("package");
    });
});

return await app.RunAsync(args);