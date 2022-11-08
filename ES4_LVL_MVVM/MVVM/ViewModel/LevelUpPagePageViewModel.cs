//using AndroidX.Annotations;
using ES4_LVL_MVVM.Contracts.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ES4_LVL_F;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class LevelUpPageViewModel : ViewModelBase
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

        private int _strengthIncrease;
        private int _intelligenceIncrease;
        private int _willpowerIncrease;
        private int _agilityIncrease;
        private int _enduranceIncrease;
        private int _personalityIncrease;
        private int _luckIncrease;

        public int StrengthIncrease
        {
            get => _strengthIncrease;
            set
            {
                if (value != _strengthIncrease)
                {
                    _strengthIncrease = value;
                    RaisePropertyChanged(property: nameof(StrengthIncrease));
                }
            }
        }

        public int IntelligenceIncrease
        {
            get => _intelligenceIncrease;
            set
            {
                if (value != _intelligenceIncrease)
                {
                    _intelligenceIncrease = value;
                    RaisePropertyChanged(property: nameof(IntelligenceIncrease));
                }
            }
        }

        public int WillpowerIncrease
        {
            get => _willpowerIncrease;
            set
            {
                if (value != _willpowerIncrease)
                {
                    _willpowerIncrease = value;
                    RaisePropertyChanged(property: nameof(WillpowerIncrease));
                }
            }
        }

        public int AgilityIncrease
        {
            get => _agilityIncrease;
            set
            {
                if (value != _agilityIncrease)
                {
                    _agilityIncrease = value;
                    RaisePropertyChanged(property: nameof(AgilityIncrease));
                }
            }
        }

        public int EnduranceIncrease
        {
            get => _enduranceIncrease;
            set
            {
                if (value != _enduranceIncrease)
                {
                    _enduranceIncrease = value;
                    RaisePropertyChanged(property: nameof(EnduranceIncrease));
                }
            }
        }

        public int PersonalityIncrease
        {
            get => _personalityIncrease;
            set
            {
                if (value != _personalityIncrease)
                {
                    _personalityIncrease = value;
                    RaisePropertyChanged(property: nameof(PersonalityIncrease));
                }
            }
        }

        public int LuckIncrease
        {
            get => _luckIncrease;
            set
            {
                if (value != _luckIncrease)
                {
                    _luckIncrease = value;
                    RaisePropertyChanged(property: nameof(LuckIncrease));
                }
            }
        }




        public LevelUpPageViewModel(INavigationService navigationService)
        {
            //_dataService = dataService;
            _navigationService = navigationService;
            Level TestLevel1 = ES4_LVL_F.Levels.New_Level(0, 5, 4, 0, 4, 0, 0, 10, 0, 1, 4, 0, 1, 0, 5, 0, 0, 0, 3, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0);
            Level[] TestLevels = new Level[] { TestLevel1 };
            Character = Characters.New_Character("Frederick", Race.Imperial, Gender.M, Specialization.Combat, Birthsign.Serpent, Class.Acrobat, TestLevels);

            StrengthIncrease = Levels.Strength_Increases(TestLevels[TestLevels.Length-1]);
            IntelligenceIncrease = Levels.Intelligence_Increases(TestLevels[TestLevels.Length - 1]);
            WillpowerIncrease = Levels.Willpower_Increases(TestLevels[TestLevels.Length - 1]);
            AgilityIncrease = Levels.Agility_Increases(TestLevels[TestLevels.Length - 1]);
            EnduranceIncrease = Levels.Endurance_Increases(TestLevels[TestLevels.Length - 1]);
            PersonalityIncrease = Levels.Personality_Increases(TestLevels[TestLevels.Length - 1]);
            LuckIncrease = Levels.Luck_Increases(TestLevels[TestLevels.Length - 1]);

        }


    }
}
