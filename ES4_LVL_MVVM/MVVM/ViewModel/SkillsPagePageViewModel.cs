﻿//using AndroidX.Annotations;
using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_F;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class SkillsPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        public SkillsPageViewModel(INavigationService navigationService)
        {
            //_dataService = dataService;
            _navigationService = navigationService;

        }


    }
}