using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_MVVM.MVVM.Model;
using ES4_LVL_MVVM.MVVM.View;

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
            get => _selectedCharacter;
            set
            {
                if (value != _selectedCharacter)
                {
                    _selectedCharacter = value;
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
        }



        //public Task SelectedCharacterChangedCommand(object e, EventArgs args) => SelectedCharacterChanged();




        ////This works fine (so why do I bother with mvvm?)
        //public void OnSelectionChanged(Object sender, SelectionChangedEventArgs e)
        //{
        //    Console.WriteLine("Selection changed click");
        //    Character c = e.CurrentSelection[0] as Character;
        //    Console.WriteLine(c.Name);
        //}






        //Can't get this to work, though it will register the click
        public ICommand SelectionChangedCommand => new Command(SelectionChangedControl);
        public void SelectionChangedControl()
        {
            Console.WriteLine("selection made");
            _dataService.SetCurrentCharacter(SelectedCharacter);

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
