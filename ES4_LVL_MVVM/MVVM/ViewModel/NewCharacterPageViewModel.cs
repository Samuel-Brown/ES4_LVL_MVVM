using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class NewCharacterPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;


        private string _txt;
        public string txt 
        { 
            get => _txt;
            set => _txt = value;
        }


        public ICommand txtCommand { get; set; }
        public ICommand txtTest { get; set; }

        public NewCharacterPageViewModel(INavigationService navigationService)
        {
            //_dataService = dataService;
            _navigationService = navigationService;
            txtCommand = new Command(() => txtFunction());
            txtTest = new Command(() => txtTestCommand());
        }

        private string txtTestCommand()
        {
            return "Hello world";
        }


        private void txtFunction()
        {
            txt = "testing";
        }

    }
}
