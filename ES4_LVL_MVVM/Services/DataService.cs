using ES4_LVL_F;
using ES4_LVL_MVVM.Contracts.Services;
using System.Collections.ObjectModel;

namespace ES4_LVL_MVVM.Services
{
    public class DataService : IDataService
    {

        public ObservableCollection<Character> MyCharacters { get; } = new();


        public ObservableCollection<Character> GetCharacters()
        {
            return MyCharacters;
        }

        public DataService()
        {

            Level TestLevel1 = ES4_LVL_F.Levels.New_Level(0, 5, 4, 0, 4, 0, 0, 10, 0, 1, 4, 0, 1, 0, 5, 0, 0, 0, 3, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0);
            Level[] TestLevels = new Level[] { TestLevel1 };
            Character MyCharacter = Characters.New_Character("Frederick", Race.Imperial, Gender.M, Specialization.Combat, Birthsign.Serpent, Class.Acrobat, TestLevels);

            MyCharacters.Add(MyCharacter);

            GetCharacters();
        }

    }
}
