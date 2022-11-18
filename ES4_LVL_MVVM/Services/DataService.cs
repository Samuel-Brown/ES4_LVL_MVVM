using ES4_LVL_MVVM.Contracts.Services;
using System.Collections.ObjectModel;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.Services
{
    public class DataService : IDataService
    {

        private Character[] _characterArray;

        public Character[] MyCharacters { get { return _characterArray; } set { _characterArray = value; } }

        public DataService()
        {
            Character TempLoadCharacter = new Character("Bob", new Race(true, Races.Argonian), "Test", new Birthsign(Birthsigns.Atronach), new GameClass(Character_CLasses.Scout));

            _characterArray = new Character[] { TempLoadCharacter };
        }


        public Character[] GetCharacters()
        {
            return _characterArray;
        }


    }
}
