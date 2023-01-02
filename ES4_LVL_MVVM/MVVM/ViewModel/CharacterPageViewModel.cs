using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class CharacterPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        readonly IDataService _dataService;

        private Character _character;

        public Character Character
        {
            get => App.DataService.GetCurrentCharacter();
            set
            {
                if (value != App.DataService.GetCurrentCharacter())
                {
                    App.DataService.SetCurrentCharacter(value);
                    RaisePropertyChanged(property: nameof(Character));
                }
            }
        }


        private Image _placeholder;

        public Image Placeholder
        {
            get => _placeholder;
            set
            {
                if (value != _placeholder)
                {
                    _placeholder = value;
                    RaisePropertyChanged(property: nameof(Character));
                }
            }
        }


        public CharacterPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            
            _character = _dataService.GetCurrentCharacter();
    }



        public override Task OnNavigatedFrom(bool isForwardNavigation)
        {
            Console.WriteLine($"On {(isForwardNavigation ? "forward" : "backward")} navigated from Character");
            return base.OnNavigatedFrom(isForwardNavigation);
        }

        public override Task OnNavigatingTo(object parameter)
        {
            Console.WriteLine($"On navigating to Character with parameter {parameter}");
            Character = (Character)parameter;
            return base.OnNavigatingTo(parameter);
        }

        public override Task OnNavigatedTo()
        {
            Console.WriteLine("On navigated to Character");
            return base.OnNavigatedTo();
        }


    }
}
