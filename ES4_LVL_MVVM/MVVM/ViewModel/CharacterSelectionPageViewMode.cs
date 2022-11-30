using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_MVVM.MVVM.Model;
using ES4_LVL_MVVM.MVVM.View;
using ES4_LVL_MVVM.Data;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class CharacterSelectionPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        readonly IDataService _dataService;

        private Character[] _myCharacters;
        private Character _selectedCharacter;

        public Character SelectedCharacter
        {
            get => DataManager.Instance.SelectedCharacter;
            set
            {
                if (value != DataManager.Instance.SelectedCharacter)
                {
                    DataManager.Instance.SelectedCharacter = value;
                    //_selectedCharacter = value;
                    
                    RaisePropertyChanged(property: nameof(SelectedCharacter));
                }
            }
        }

        public Character[] MyCharacters
        {
            get => _myCharacters;
            set
            {
                if (value != _myCharacters)
                {
                    _myCharacters = value;
                    RaisePropertyChanged(property: nameof(MyCharacters));
                }
            }
        }


        public CharacterSelectionPageViewModel(IDataService dataService, INavigationService navigationService)
        {



            _dataService = dataService;
            _navigationService = navigationService;

            _myCharacters = _dataService.GetCharacters();





            var Form1 = DataManager.Instance.Forms1;

        }




        public ICommand MyCommand => new Command(SelectionChangedControl);

        private static void SelectionChangedControl(object obj)
        {

            //throw new NotImplementedException();
        }


        public override Task OnNavigatedFrom(bool isForwardNavigation)
        {
            Console.WriteLine($"On {(isForwardNavigation ? "forward" : "backward")} navigated from Character");
            return base.OnNavigatedFrom(isForwardNavigation);
        }

        public override Task OnNavigatingTo(object parameter)
        {
            Console.WriteLine($"On navigating to Character with parameter {parameter}");
            //Character = (Character)parameter;
            return base.OnNavigatingTo(parameter);
        }

        public override Task OnNavigatedTo()
        {
            Console.WriteLine("On navigated to Character");
            return base.OnNavigatedTo();
        }


    }
}
