using ES4_LVL_MVVM.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES4_LVL_MVVM.Data
{
    public class DataManager
    {
        private static DataManager instance;

        private Character _selectedCharacter;

        public Character SelectedCharacter
        {
            get => _selectedCharacter;
            set
            {
                if (value != _selectedCharacter)
                {
                    _selectedCharacter = value;
                }
            }
        }











        // save data of three forms，or you could define them as any other type 
        public Dictionary<string, string> Forms1 { get; set; }
        public Dictionary<string, string> Forms2 { get; set; }
        public Dictionary<string, string> Forms3 { get; set; }



        private DataManager() { }

        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataManager();


                }
                return instance;
            }
        }



    }
}
