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
        builder.Services.AddTransient<CharacterPage>();
        builder.Services.AddTransient<CharacterPageViewModel>();

        builder.Services.AddTransient<AttributesPage>();
        builder.Services.AddTransient<AttributesPageViewModel>();

        builder.Services.AddTransient<SkillsPage>();
        builder.Services.AddTransient<SkillsPageViewModel>();

        builder.Services.AddTransient<LevelUpPage>();
        builder.Services.AddTransient<LevelUpPageViewModel>();

        builder.Services.AddTransient<ShellPage>();
        builder.Services.AddTransient<ShellPageViewModel>();
        //AttributesPage

        builder.Services.AddSingleton<IDataService, DataService>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();


        return builder.Build();
	}
}
