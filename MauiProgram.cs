//using CommunityToolkit.Maui;
//using CommunityToolkit.Maui.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using todomaui.Common;
using todomaui.ViewModels;
using todomaui.Views;

namespace todomaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			//.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("opensan_regular", "OpenSansRegular");
				fonts.AddFont("opensan_semibold", "OpenSansSemibold");
				fonts.AddFont("f6fs9.otf", "f6");
			});

		registerViewAndVM(builder.Services);
		RegisterEssentials(builder.Services);

#if DEBUG
        builder.Logging.AddDebug();
#endif

		var z = builder.Build();
		ServiceLocater.Init(z.Services);
		return z;
	}

	private static void registerViewAndVM(in IServiceCollection services)
	{
		services.AddTransient<TodoListPage>().AddTransient<TodoListPageVM>();
        //services.AddTransient<TodoListPage, TodoListPageVM>();
	}

    static void RegisterEssentials(in IServiceCollection services)
    {
        services.AddSingleton<IDeviceInfo>(DeviceInfo.Current);
        services.AddSingleton<IDeviceDisplay>(DeviceDisplay.Current);
        //services.AddSingleton<IFileSaver>(FileSaver.Default);
        //services.AddSingleton<IFolderPicker>(FolderPicker.Default);
    }
}
