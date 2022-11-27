//using AndroidX.Annotations;
using ES4_LVL_MVVM.MVVM.Model;
using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class SkillsPageViewModel : ViewModelBase
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

        public SkillsPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
        }


    }
}
