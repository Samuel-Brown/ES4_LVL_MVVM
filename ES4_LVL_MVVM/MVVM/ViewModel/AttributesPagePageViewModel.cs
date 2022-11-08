//using AndroidX.Annotations;
using ES4_LVL_F;
using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class AttributesPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;


        private Character _character;

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








        public AttributesPageViewModel(INavigationService navigationService)
        {
            //_dataService = dataService;
            _navigationService = navigationService;
            Level TestLevel1 = ES4_LVL_F.Levels.New_Level(0, 5, 4, 0, 4, 0, 0, 10, 0, 1, 4, 0, 1, 0, 5, 0, 0, 0, 3, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0);
            Level[] TestLevels = new Level[] { TestLevel1 };
            Character = Characters.New_Character("Frederick", Race.Imperial, Gender.M, Specialization.Combat, Birthsign.Serpent, Class.Acrobat, TestLevels);
        }


    }
}
