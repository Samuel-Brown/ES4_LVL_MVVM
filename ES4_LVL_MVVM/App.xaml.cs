using ES4_LVL_MVVM.Contracts.Services;
using ES4_LVL_MVVM.MVVM.View;
using ES4_LVL_MVVM;
using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM;

public partial class App : Application
{

    public static CharacterSelectionPageViewModel CharacterSelectionPageView;
    public static CharacterPageViewModel CharacterPageView;
    public static LevelUpPageViewModel LevelUpPageView;
    public static SkillsPageViewModel SkillsPageView;
    public static AttributesPageViewModel AttributesPageView;

    public static IDataService DataService { get; set; }
    


    public App(INavigationService navigationService , IDataService dataService)
    {

        InitializeComponent();

        MainPage = new NavigationPage();

        CharacterSelectionPageView = new CharacterSelectionPageViewModel(dataService, navigationService);
        CharacterPageView = new CharacterPageViewModel(dataService, navigationService);
        LevelUpPageView = new LevelUpPageViewModel(dataService, navigationService);
        SkillsPageView = new SkillsPageViewModel(dataService, navigationService);
        AttributesPageView = new AttributesPageViewModel(dataService, navigationService);

        DataService = dataService;




        //MainPage = new ShellPage();
        navigationService.NavigateToMainPage();
    }

}
