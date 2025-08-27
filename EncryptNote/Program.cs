using Avalonia;
using System;
using EncryptNote.ViewModels;

using Microsoft.Extensions.DependencyInjection;

namespace EncryptNote;

public static class Program
{
    public static IServiceProvider? Services { get; private set; }
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        Services = services.BuildServiceProvider();
        
        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
    }
    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<NoteHomePageViewModel>();
        services.AddTransient<NoteCheckPageViewModel>();

    }
    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}