using ES4_LVL_MVVM.Contracts.Services;
using ES4_LVL_MVVM.MVVM.View;
using ES4_LVL_MVVM;

namespace ES4_LVL_MVVM;

public partial class App : Application
{
    public App(INavigationService navigationService , IDataService dataService)
    {

        InitializeComponent();

        MainPage = new NavigationPage();
        
        //MainPage = new ShellPage();
        navigationService.NavigateToMainPage();
    }

}
