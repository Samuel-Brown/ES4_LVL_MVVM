//using AndroidX.Annotations;
using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_F;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class NewCharacterPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        private string _name;

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

        public NewCharacterPageViewModel(INavigationService navigationService)
        {
            //_dataService = dataService;
            _navigationService = navigationService;
            txtCommand = new Command(() => txtFunction());
            Name = "Hello  World";
            Input = "";
            ClassList = Classes.List_Classes;
            //character = Characters.New_Character("Male", Race.Imperial, Gender.M, Specialization.Combat, Birthsign.Serpent, Class.Acrobat);

        }






        private void txtFunction()
        {
            Name = "Hello" + Input;
        }

    }
}
