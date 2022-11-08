using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_F;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class CharacterPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        private Character _character;

        public Character character
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


        private Image _placeholder;

        public Image Placeholder
        {
            get => _placeholder;
            set
            {
                if (value != _placeholder)
                {
                    Placeholder = value;
                    RaisePropertyChanged(property: nameof(Character));
                }
            }
        }


        public CharacterPageViewModel(INavigationService navigationService)
        {
            //_dataService = dataService;
            _navigationService = navigationService;
            character = Characters.New_Character("Frederick", Race.Imperial, Gender.M, Specialization.Combat, Birthsign.Serpent, Class.Acrobat);
        }


    }
}
