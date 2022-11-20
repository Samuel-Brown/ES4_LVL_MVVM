//using AndroidX.Annotations;
using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_MVVM.MVVM.Model;
using __XamlGeneratedCode__;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class ShellPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        readonly IDataService _dataService;



        private Character _character;
        private Character[] _characters;

        public Character[] Characters
        {
            get => _characters;
            set
            {
                if (value != _characters)
                {
                    _characters = value;
                    RaisePropertyChanged(property: nameof(Characters));
                }
            }
        }


        public Character Character
        {
            get => _character;
            set
            {
                if (value != _character)
                {
                    _character = value;
                    RaisePropertyChanged(property: nameof(Character));
                }
            }
        }












        public ShellPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            Characters = dataService.GetCharacters();
        }



        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character animal = e.CurrentSelection.FirstOrDefault() as Character;
            var navigationParameter = new Dictionary<string, object>
            {
        { "Bear", animal }
            };
            await Shell.Current.GoToAsync($"LevelUpPage", navigationParameter);
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
