using ES4_LVL_MVVM.MVVM.View;
using ES4_LVL_MVVM.Contracts.Services;
using ES4_LVL_MVVM.Services;
using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<NewCharacterPage>();
        builder.Services.AddTransient<NewCharacterPageViewModel>();

        builder.Services.AddSingleton<IDataService, DataService>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();


        return builder.Build();
	}
}
