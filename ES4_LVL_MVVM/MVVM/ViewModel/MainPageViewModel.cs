using ES4_LVL_MVVM.Contracts.Services;
using Microsoft.Maui.Networking;
using System.Collections.ObjectModel;
using ES4_LVL_MVVM.MVVM.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly IDataService _dataService;
        readonly INavigationService _navigationService;

        private Character _selectedCharacter;

        public ObservableCollection<Character> MyCharacters { get; set; }

        public Command NavigateToNewCharacterPageCommand
            => new Command(async () => await _navigationService.NavigateToNewCharacterPage());

        public Command NavigateToCharacterPageCommand => new Command(async () => await _navigationService.NavigateToCharacterPage(MyCharacters[3]));

        public Command SetCharacterIndex => new Command(async () => await _dataService.SetCharacterIndex(2));


        public Command NavigateToShellPageCommand
            => new Command(async () => await _navigationService.NavigateToShellPage(_selectedCharacter));

        public MainPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;

            Character[] TempCharacterArray = new Character[dataService.GetCharacters().Length];
            TempCharacterArray = dataService.GetCharacters(); 

            MyCharacters = new ObservableCollection<Character>();

            foreach(Character character in TempCharacterArray)
            {
                MyCharacters.Add(character);
            }


        }


        public void CharacterSelected(int i)
        {

            _dataService.SetCharacterIndex(i);
            //_selectedCharacter = selectedCharacter;
            //NavigateToShellPageCommand.Execute(selectedCharacter);
        }





        public override Task OnNavigatedFrom(bool isForwardNavigation)
        {
            Console.WriteLine($"On {(isForwardNavigation ? "forward" : "backward")} navigated from MainPage");
            return base.OnNavigatedFrom(isForwardNavigation);
        }

        public override Task OnNavigatingTo(object parameter)
        {
            Console.WriteLine($"On navigating to MainPage with parameter {parameter}");
            return base.OnNavigatingTo(parameter);
        }

        public override Task OnNavigatedTo()
        {
            
            Console.WriteLine("On navigated to MainPage");
            return base.OnNavigatedTo();
        }
    }
}
