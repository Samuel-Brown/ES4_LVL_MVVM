﻿//using AndroidX.Annotations;
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

        public AttributesPageViewModel(INavigationService navigationService)
        {
            //_dataService = dataService;
            _navigationService = navigationService;

        }


    }
}