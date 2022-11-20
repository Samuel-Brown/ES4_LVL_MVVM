using System.Collections.ObjectModel;
using System.Net.Http;
using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.Contracts.Services
{
    public interface IDataService
    {
        public Character[] GetCharacters();
        public void SetCharacterIndex(int i);
    }
}




//public async Task<List<Monkey>> GetMonkeys()
//{
//    if (monkeyList?.Count > 0)
//        return monkeyList;

//    // Online
//    var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
//    if (response.IsSuccessStatusCode)
//    {
//        monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
//    }
//    // Offline
//    /*using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
//    using var reader = new StreamReader(stream);
//    var contents = await reader.ReadToEndAsync();
//    monkeyList = JsonSerializer.Deserialize<List<Monkey>>(contents);
//    */
//    return monkeyList;
//}
