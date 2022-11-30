using ES4_LVL_MVVM.Contracts.Services;
using ES4_LVL_MVVM.MVVM.View;
using ES4_LVL_MVVM;
using ES4_LVL_MVVM.MVVM.ViewModels;
using ES4_LVL_MVVM.Data;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM;

public partial class App : Application
{

    public static CharacterSelectionPageViewModel CharacterSelectionPageView;
    public static CharacterPageViewModel CharacterPageView;
    public static LevelUpPageViewModel LevelUpPageView;
    public static SkillsPageViewModel SkillsPageView;
    public static AttributesPageViewModel AttributesPageView;
    public static MainPageViewModel MainPageView;

    public static IDataService DataService { get; set; }

    private Character[] _characterArray;
    private Character _selectedCharacter;

    public Character[] MyCharacters { get { return _characterArray; } set { _characterArray = value; } }
    public Character SelectedCharacter { get { return _selectedCharacter; } set { _selectedCharacter = value; } }


    public App(INavigationService navigationService , IDataService dataService)
    {

        InitializeComponent();



        _characterArray = new Character[] {
                new Character("Bob", new Race(true, Races.Argonian), "Magic", new Birthsign(Birthsigns.Atronach), new GameClass(Character_CLasses.Scout)),
                new Character("Harry", new Race(true, Races.Dunmer), "Combat", new Birthsign(Birthsigns.Lover), new GameClass(Character_CLasses.Barbarian)),
                new Character("Rupert", new Race(true, Races.Breton), "Stealth", new Birthsign(Birthsigns.Thief), new GameClass(Character_CLasses.Agent)),
                new Character("Philip", new Race(true, Races.Nord), "Combat", new Birthsign(Birthsigns.Lord), new GameClass(Character_CLasses.Warrior)),
                new Character("Dog", new Race(true, Races.Khajiit), "Magic", new Birthsign(Birthsigns.Lady), new GameClass(Character_CLasses.Mage))
            };

        _selectedCharacter = _characterArray[0];







        DataManager.Instance.Forms1 = new Dictionary<string, string>();
        DataManager.Instance.Forms1.Add("xxx", "xxx");
        DataManager.Instance.SelectedCharacter = _characterArray[4];


        CharacterSelectionPageView = new CharacterSelectionPageViewModel(dataService, navigationService );
        CharacterPageView = new CharacterPageViewModel(dataService, navigationService);
        LevelUpPageView = new LevelUpPageViewModel(dataService, navigationService);
        SkillsPageView = new SkillsPageViewModel(dataService, navigationService);
        AttributesPageView = new AttributesPageViewModel(dataService, navigationService);
        MainPageView = new MainPageViewModel(dataService, navigationService);

        DataService = dataService;

        MainPage = new NavigationPage();



        //MainPage = new ShellPage();
        navigationService.NavigateToMainPage();
    }

}
