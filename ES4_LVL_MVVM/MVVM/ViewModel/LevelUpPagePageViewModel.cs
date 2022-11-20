//using AndroidX.Annotations;
using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class LevelUpPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        readonly IDataService _dataService;

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

        //private int _strengthIncrease;
        //private int _intelligenceIncrease;
        //private int _willpowerIncrease;
        //private int _agilityIncrease;
        //private int _enduranceIncrease;
        //private int _personalityIncrease;
        //private int _luckIncrease;

        //public int StrengthIncrease
        //{
        //    get => _strengthIncrease;
        //    set
        //    {
        //        if (value != _strengthIncrease)
        //        {
        //            _strengthIncrease = value;
        //            RaisePropertyChanged(property: nameof(StrengthIncrease));
        //        }
        //    }
        //}

        //public int IntelligenceIncrease
        //{
        //    get => _intelligenceIncrease;
        //    set
        //    {
        //        if (value != _intelligenceIncrease)
        //        {
        //            _intelligenceIncrease = value;
        //            RaisePropertyChanged(property: nameof(IntelligenceIncrease));
        //        }
        //    }
        //}

        //public int WillpowerIncrease
        //{
        //    get => _willpowerIncrease;
        //    set
        //    {
        //        if (value != _willpowerIncrease)
        //        {
        //            _willpowerIncrease = value;
        //            RaisePropertyChanged(property: nameof(WillpowerIncrease));
        //        }
        //    }
        //}

        //public int AgilityIncrease
        //{
        //    get => _agilityIncrease;
        //    set
        //    {
        //        if (value != _agilityIncrease)
        //        {
        //            _agilityIncrease = value;
        //            RaisePropertyChanged(property: nameof(AgilityIncrease));
        //        }
        //    }
        //}

        //public int EnduranceIncrease
        //{
        //    get => _enduranceIncrease;
        //    set
        //    {
        //        if (value != _enduranceIncrease)
        //        {
        //            _enduranceIncrease = value;
        //            RaisePropertyChanged(property: nameof(EnduranceIncrease));
        //        }
        //    }
        //}

        //public int PersonalityIncrease
        //{
        //    get => _personalityIncrease;
        //    set
        //    {
        //        if (value != _personalityIncrease)
        //        {
        //            _personalityIncrease = value;
        //            RaisePropertyChanged(property: nameof(PersonalityIncrease));
        //        }
        //    }
        //}

        //public int LuckIncrease
        //{
        //    get => _luckIncrease;
        //    set
        //    {
        //        if (value != _luckIncrease)
        //        {
        //            _luckIncrease = value;
        //            RaisePropertyChanged(property: nameof(LuckIncrease));
        //        }
        //    }
        //}




        public LevelUpPageViewModel(INavigationService navigationService, IDataService dataService)
        {
            _dataService = dataService;
            _navigationService = navigationService;

            //StrengthIncrease =      Levels.Strength_Increases(Character.CharacterLevels[Character.CharacterLevels.Length-1]);
            //IntelligenceIncrease =  Levels.Intelligence_Increases(Character.CharacterLevels[Character.CharacterLevels.Length - 1]);
            //WillpowerIncrease =     Levels.Willpower_Increases(Character.CharacterLevels[Character.CharacterLevels.Length - 1]);
            //AgilityIncrease =       Levels.Agility_Increases(Character.CharacterLevels[Character.CharacterLevels.Length - 1]);
            //EnduranceIncrease =     Levels.Endurance_Increases(Character.CharacterLevels[Character.CharacterLevels.Length - 1]);
            //PersonalityIncrease =   Levels.Personality_Increases(Character.CharacterLevels[Character.CharacterLevels.Length - 1]);
            //LuckIncrease =          Levels.Luck_Increases(Character.CharacterLevels[Character.CharacterLevels.Length - 1]);

        }

        public override Task OnNavigatedFrom(bool isForwardNavigation)
        {
            Console.WriteLine($"On {(isForwardNavigation ? "forward" : "backward")} navigated from Character");
            return base.OnNavigatedFrom(isForwardNavigation);
        }

        public override Task OnNavigatingTo(object parameter)
        {
            Console.WriteLine($"On navigating to Character with parameter {parameter}");
            Character = (Character)parameter;
            return base.OnNavigatingTo(parameter);
        }

        public override Task OnNavigatedTo()
        {
            Console.WriteLine("On navigated to Character");
            return base.OnNavigatedTo();
        }




    }
}
