using System.Collections.ObjectModel;
using System.Net.Http;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.Contracts.Services
{
    public interface IDataService
    {
        public Character[] GetCharacters();
        public void SetCurrentCharacter(Character c);
        public Character GetCurrentCharacter();
    }
}

