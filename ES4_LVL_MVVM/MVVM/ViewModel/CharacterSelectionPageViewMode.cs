﻿using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class CharacterSelectionPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        readonly IDataService _dataService;

        private Character _myCharacter;

        public Character MyCharacter
        {
            get => _myCharacter;
            set
            {
                if (value != _myCharacter)
                {
                    _myCharacter = value;
                    RaisePropertyChanged(property: nameof(MyCharacter));
                }
            }
        }

        public CharacterSelectionPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;

            _myCharacter = _dataService.GetCharacters()[0];
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
