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
    public class MainPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        readonly IDataService _dataService;

        private Character _character;
        private Character[] _characterList;

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

        public Character[] CharacterList
        {
            get => _characterList;
            set
            {
                if (value != _characterList)
                {
                    _characterList = value;
                    RaisePropertyChanged(property: nameof(CharacterList));
                }
            }
        }

        public MainPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;

            _character = _dataService.GetCurrentCharacter();
            _characterList = _dataService.GetCharacters();
            //_character = _characterList[0];//Will need to change this down the line








            DataManager.Instance.Forms1 = new Dictionary<string, string>();
            DataManager.Instance.Forms1.Add("xxx", "xxx");



            var Form1 = DataManager.Instance.Forms1;






        }




        //Receiver

        //MessagingCenter.Subscribe<MainPage> (this, "Hi", (sender) => {
        // do something whenever the "Hi" message is sent
        //});


        public override Task OnNavigatedFrom(bool isForwardNavigation)
        {
            Console.WriteLine($"On {(isForwardNavigation ? "forward" : "backward")} navigated from Character");
            return base.OnNavigatedFrom(isForwardNavigation);
        }

        public override Task OnNavigatingTo(object parameter)
        {
            Console.WriteLine($"On navigating to Character with parameter {parameter}");
            return base.OnNavigatingTo(parameter);
        }

        public override Task OnNavigatedTo()
        {
            Console.WriteLine("On navigated to Character");
            return base.OnNavigatedTo();
        }


    }

}
