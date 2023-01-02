//using AndroidX.Annotations;
using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class NewCharacterPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        readonly IDataService _dataService;

        private string _name;

        private string[] _classList;

        public string[] ClassList
        {
            get => _classList;
            set
            {
                if (value != _classList)
                {
                    _classList = value;
                    RaisePropertyChanged(property: nameof(ClassList));
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value != _name)
                {
                    _name = value;
                    RaisePropertyChanged(property: nameof(Name));
                }
            }
        }

        private string _input;

        public string Input
        {
            get => _input;
            set
            {
                if (value != _input)
                {
                    _input = value;
                    RaisePropertyChanged(property: nameof(Input));
                }
            }
        }


        public ICommand txtCommand { get; set; }
        public ICommand txtTest { get; set; }
        public ICommand listClassesCommand { get; set; }

        public NewCharacterPageViewModel(INavigationService navigationService, IDataService dataService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            txtCommand = new Command(() => txtFunction());
            Name = "Hello  World";
            Input = "";


            //ClassList = Character_CLasses.;

        }






        private void txtFunction()
        {
            Name = "Hello" + Input;
        }

    }
}
