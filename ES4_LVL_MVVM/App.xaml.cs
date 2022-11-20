using ES4_LVL_MVVM.Contracts.Services;
using ES4_LVL_MVVM.MVVM.View;
using ES4_LVL_MVVM;
using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM;

public partial class App : Application
{

    public static CharacterSelectionPageViewModel CharacterSelectionPageView;


    public App(INavigationService navigationService , IDataService dataService)
    {

        InitializeComponent();

        MainPage = new NavigationPage();

        CharacterSelectionPageView = new CharacterSelectionPageViewModel(dataService, navigationService);










        //MainPage = new ShellPage();
        navigationService.NavigateToMainPage();
    }

}
