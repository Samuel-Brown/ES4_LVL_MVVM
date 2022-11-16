﻿using ES4_LVL_MVVM.Contracts.Services;

namespace ES4_LVL_MVVM;

public partial class App : Application
{
    public App(INavigationService navigationService , IDataService dataService)
    {
        InitializeComponent();
        MainPage = new NavigationPage();
        navigationService.NavigateToMainPage();
    }
}
