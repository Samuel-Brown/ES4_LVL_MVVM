using ES4_LVL_MVVM.Contracts.Services;
using Microsoft.Maui.Networking;
using System.Collections.ObjectModel;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly IDataService _dataService;
        readonly INavigationService _navigationService;

        public ObservableCollection<Character> MyCharacters { get; set; }

        public Command NavigateToNewCharacterPageCommand
            => new Command(async () => await _navigationService.NavigateToNewCharacterPage());

        public Command NavigateToShellPageCommand
            => new Command(async () => await _navigationService.NavigateToShellPage(_dataService.GetCharacters()[0]));

        public MainPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;

            Character[] TempCharacterArray = new Character[20];
            TempCharacterArray[0] = dataService.GetCharacters()[0]; 

            MyCharacters = new ObservableCollection<Character>() { TempCharacterArray[0] };

            

            //MyCharacters.Add(TempCharacterArray[0]);


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
