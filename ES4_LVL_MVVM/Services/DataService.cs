using ES4_LVL_MVVM.Contracts.Services;
using System.Collections.ObjectModel;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.Services
{
    public class DataService : IDataService
    {

        private Character[] _characterArray;
        private Character _selectedCharacter;

        public Character[] MyCharacters { get { return _characterArray; } set { _characterArray = value; } }
        public Character SelectedCharacter { get { return _selectedCharacter; } set { _selectedCharacter = value; } }



        public DataService()
        {
            //Character TempLoadCharacter = new Character("Bob", new Race(true, Races.Argonian), "Test", new Birthsign(Birthsigns.Atronach), new GameClass(Character_CLasses.Scout));

            _characterArray = new Character[] { 
                new Character("Bob", new Race(true, Races.Argonian), "Magic", new Birthsign(Birthsigns.Atronach), new GameClass(Character_CLasses.Scout)),
                new Character("Harry", new Race(true, Races.Dunmer), "Combat", new Birthsign(Birthsigns.Lover), new GameClass(Character_CLasses.Barbarian)),
                new Character("Rupert", new Race(true, Races.Breton), "Stealth", new Birthsign(Birthsigns.Thief), new GameClass(Character_CLasses.Agent)),
                new Character("Philip", new Race(true, Races.Nord), "Combat", new Birthsign(Birthsigns.Lord), new GameClass(Character_CLasses.Warrior)),
                new Character("Dog", new Race(true, Races.Khajiit), "Magic", new Birthsign(Birthsigns.Lady), new GameClass(Character_CLasses.Mage))
            };

            _selectedCharacter = _characterArray[0];
        }


        public void SetCurrentCharacter(Character c)
        {
            SelectedCharacter = c;
        }

        public Character[] GetCharacters()
        {
            return _characterArray;
        }

        public Character GetCurrentCharacter()
        {
            return _selectedCharacter;
        }


    }
}
