using ES4_LVL_F;
using ES4_LVL_MVVM.Contracts.Services;
using Microsoft.Maui.Networking;
using System.Collections.ObjectModel;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly IDataService _dataService;
        readonly INavigationService _navigationService;

        public ObservableCollection<Character> MyCharacters { get; } = new();


        public Command NavigateToNewCharacterPageCommand
            => new Command(async () => await _navigationService.NavigateToNewCharacterPage());

        public Command NavigateCommand
            => new Command(async () => await _navigationService.NavigateToNewCharacterPage());

        public Command NavigateToCharacterPageCommand
            => new Command(async () => await _navigationService.NavigateToCharacterPage(MyCharacters[0]));

        public Command NavigateToShellPageCommand
            => new Command(async () => await _navigationService.NavigateToShellPage());

        public MainPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            MyCharacters = _dataService.GetCharacters();

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
