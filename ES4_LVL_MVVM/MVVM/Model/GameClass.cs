using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES4_LVL_MVVM.MVVM.Model
{

    public enum Character_CLasses
    {
        Acrobat,
        Agent,
        Archer,
        Assassin,
        Barbarian,
        Bard,
        Battlemage,
        Crusader,
        Healer,
        Knight,
        Mage,
        Monk,
        Nightblade,
        Pilgrim,
        Rogue,
        Scout,
        Sorcerer,
        Spellsword,
        Thief,
        Warrior,
        Witchhunter,
        Custom
    }

    public class GameClass
    {
        private Character_CLasses _character_class;
        private string _display_name;
        private int[] _major_skill_bonuses;
        private int[] _attribute_bonuses;

        public Character_CLasses Char_Class { get { return _character_class; } set { _character_class = value; } }
        public string Display_Name { get { return _display_name; } set { _display_name = value; } }
        public int[] Major_Skill_Bonuses { get { return _major_skill_bonuses; } set { _major_skill_bonuses = value; } }
        public int[] Attribute_Bonuses { get { return _attribute_bonuses; } set { _attribute_bonuses = value; } }


        public GameClass(Character_CLasses character_cLasses)
        {
            _character_class = character_cLasses;

            switch (character_cLasses)
            {     //BLA BLU H2H ARM BLO HVA ATH ACR LTA SEC SNK MRK MER SPE ILU ALC CON MYS ALT DES RES 
                case Character_CLasses.Acrobat:     Display_Name = "Acrobat";       _major_skill_bonuses = new int[21] { 20, 0, 0, 0, 20, 0, 0, 0, 0, 20, 20, 20, 0, 20, 0, 0, 0, 0, 0, 0, 0 };      _attribute_bonuses = new int[8] { 0, 5, 0, 5, 0, 0, 0, 0 }; break;
                case Character_CLasses.Agent:       Display_Name = "Agent";         _major_skill_bonuses = new int[21] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 20, 0, 0, 0, 0, 0, 0 };      _attribute_bonuses = new int[8] { 0, 0, 0, 5, 5, 0, 0, 0 }; break;
                case Character_CLasses.Archer:      Display_Name = "Archer";        _major_skill_bonuses = new int[21] { 20, 20, 20, 20, 0, 0, 0, 0, 20, 0, 20, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0 };     _attribute_bonuses = new int[8] { 5, 0, 0, 5, 0, 0, 0, 0 }; break;
                case Character_CLasses.Assassin:    Display_Name = "Assassin";      _major_skill_bonuses = new int[21] { 20, 0, 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 0, 0, 0, 20, 0, 0, 0, 0, 0 };     _attribute_bonuses = new int[8] { 0, 0, 5, 0, 0, 5, 0, 0 }; break;
                case Character_CLasses.Barbarian:   Display_Name = "Barbarian";     _major_skill_bonuses = new int[21] { 20, 20, 20, 20, 20, 0, 20, 0, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };     _attribute_bonuses = new int[8] { 5, 0, 5, 0, 0, 0, 0, 0 }; break;
                case Character_CLasses.Bard:        Display_Name = "Bard";          _major_skill_bonuses = new int[21] { 20, 0, 0, 0, 20, 0, 0, 20, 20, 0, 0, 0, 20, 20, 20, 20, 0, 0, 0, 0, 0 };    _attribute_bonuses = new int[8] { 0, 0, 0, 0, 5, 5, 0, 0 }; break;
                case Character_CLasses.Battlemage:  Display_Name = "Battlemage";    _major_skill_bonuses = new int[21] { 20, 20, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 0 };    _attribute_bonuses = new int[8] { 5, 0, 0, 0, 0, 5, 0, 0 }; break;
                case Character_CLasses.Crusader:    Display_Name = "Crusader";      _major_skill_bonuses = new int[21] { 20, 20, 20, 0, 0, 20, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 20 };     _attribute_bonuses = new int[8] { 5, 0, 0, 0, 0, 0, 5, 0 }; break;
                case Character_CLasses.Healer:      Display_Name = "Healer";        _major_skill_bonuses = new int[21] { 0, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 20, 20, 20, 20, 0, 0, 20, 20, 20 };    _attribute_bonuses = new int[8] { 0, 0, 0, 0, 5, 0, 5, 0 }; break;
                case Character_CLasses.Knight:      Display_Name = "Knight";        _major_skill_bonuses = new int[21] { 20, 20, 20, 0, 20, 20, 0, 0, 0, 0, 0, 0, 0, 20, 20, 0, 0, 0, 0, 0, 0 };     _attribute_bonuses = new int[8] { 5, 0, 0, 0, 5, 0, 0, 0 }; break;
                case Character_CLasses.Mage:        Display_Name = "Mage";          _major_skill_bonuses = new int[21] { 0, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 20, 20 };    _attribute_bonuses = new int[8] { 0, 0, 0, 0, 0, 5, 5, 0 }; break;
                case Character_CLasses.Monk:        Display_Name = "Monk";          _major_skill_bonuses = new int[21] { 0, 0, 20, 0, 0, 0, 20, 0, 0, 20, 20, 20, 0, 0, 0, 0, 0, 0, 20, 0, 0 };      _attribute_bonuses = new int[8] { 0, 0, 0, 5, 0, 0, 5, 0 }; break;
                case Character_CLasses.Nightblade:  Display_Name = "Nightblade";    _major_skill_bonuses = new int[21] { 20, 0, 0, 0, 0, 0, 20, 0, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 20, 20 };      _attribute_bonuses = new int[8] { 0, 0, 5, 0, 0, 0, 5, 0 }; break;
                case Character_CLasses.Pilgrim:     Display_Name = "Pilgrim";       _major_skill_bonuses = new int[21] { 0, 20, 0, 20, 20, 0, 0, 0, 20, 20, 0, 0, 20, 20, 0, 0, 0, 0, 0, 0, 0 };     _attribute_bonuses = new int[8] { 0, 5, 0, 0, 5, 0, 0, 0 }; break;
                case Character_CLasses.Rogue:       Display_Name = "Rogue";         _major_skill_bonuses = new int[21] { 20, 0, 0, 0, 20, 0, 20, 20, 20, 0, 0, 0, 20, 0, 20, 20, 0, 0, 0, 0, 0 };    _attribute_bonuses = new int[8] { 0, 0, 5, 0, 5, 0, 0, 0 }; break;
                case Character_CLasses.Scout:       Display_Name = "Scout";         _major_skill_bonuses = new int[21] { 20, 0, 0, 20, 20, 0, 20, 20, 20, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0 };     _attribute_bonuses = new int[8] { 0, 5, 5, 0, 0, 0, 0, 0 }; break;
                case Character_CLasses.Sorcerer:    Display_Name = "Sorcerer";      _major_skill_bonuses = new int[21] { 0, 0, 0, 0, 0, 20, 0, 20, 0, 0, 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 20 };    _attribute_bonuses = new int[8] { 0, 5, 0, 0, 0, 5, 0, 0 }; break;
                case Character_CLasses.Spellsword:  Display_Name = "Spellsword";    _major_skill_bonuses = new int[21] { 20, 0, 0, 0, 20, 20, 0, 0, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 20, 20, 20 };     _attribute_bonuses = new int[8] { 0, 5, 0, 0, 0, 0, 5, 0 }; break;
                case Character_CLasses.Thief:       Display_Name = "Thief";         _major_skill_bonuses = new int[21] { 0, 0, 0, 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 20, 0, 0, 0, 0, 0, 0, 0 };      _attribute_bonuses = new int[8] { 0, 0, 5, 5, 0, 0, 0, 0 }; break;
                case Character_CLasses.Warrior:     Display_Name = "Warrior";       _major_skill_bonuses = new int[21] { 20, 20, 20, 20, 20, 20, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };     _attribute_bonuses = new int[8] { 5, 5, 0, 0, 0, 0, 0, 0 }; break;
                case Character_CLasses.Witchhunter: Display_Name = "Witchhunter";   _major_skill_bonuses = new int[21] { 0, 0, 0, 0, 0, 0, 20, 20, 0, 20, 0, 20, 0, 0, 0, 20, 20, 20, 0, 20, 0 };    _attribute_bonuses = new int[8] { 0, 0, 0, 5, 0, 5, 0, 0 }; break;
                case Character_CLasses.Custom:      Display_Name = "Custom";        _major_skill_bonuses = new int[21] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };            _attribute_bonuses = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 }; break;
            }
        }



        public GameClass(string display_name, int[] major_skill_bonuses, int[] attribute_bonuses)
        {
            _display_name = display_name;
            _major_skill_bonuses = major_skill_bonuses;
            _attribute_bonuses = attribute_bonuses;
            _character_class = Character_CLasses.Custom;

        }

    }
}



/*


"Strength":      "Endurance":     "Speed":         "Agility":       "Personality":   "Intelligence":  "Willpower":     "Luck":   
0; 5; 0; 5; 0; 0; 0; 0  
0; 0; 0; 5; 5; 0; 0; 0  
5; 0; 0; 5; 0; 0; 0; 0  
0; 0; 5; 0; 0; 5; 0; 0  
5; 0; 5; 0; 0; 0; 0; 0  
0; 0; 0; 0; 5; 5; 0; 0  
5; 0; 0; 0; 0; 5; 0; 0  
5; 0; 0; 0; 0; 0; 5; 0  
0; 0; 0; 0; 5; 0; 5; 0  
5; 0; 0; 0; 5; 0; 0; 0  
0; 0; 0; 0; 0; 5; 5; 0  
0; 0; 0; 5; 0; 0; 5; 0  
0; 0; 5; 0; 0; 0; 5; 0  
0; 5; 0; 0; 5; 0; 0; 0  
0; 0; 5; 0; 5; 0; 0; 0  
0; 5; 5; 0; 0; 0; 0; 0  
0; 5; 0; 0; 0; 5; 0; 0  
0; 5; 0; 0; 0; 0; 5; 0  
0; 0; 5; 5; 0; 0; 0; 0  
5; 5; 0; 0; 0; 0; 0; 0  
0; 0; 0; 5; 0; 5; 0; 0  
0; 0; 0; 0; 0; 0; 0; 0  


BLA BLU H2H ARM BLO HVA ATH ALC LTA SEC SNK MRK MER SPE ILU ALC CON MYS ALT DES RES 
20, 0,  0,  0,  20, 0,  0,  0,  0,  20, 20, 20, 0,  20, 0,  0,  0,  0,  0,  0,  0,  
0,  0,  0,  0,  0,  0,  0,  0,  0,  20, 20, 20, 20, 20, 20, 0,  0,  0,  0,  0,  0,  
20, 20, 20, 20, 0,  0,  0,  0,  20, 0,  20, 20, 0,  0,  0,  0,  0,  0,  0,  0,  0,  
20, 0,  0,  0,  0,  0,  0,  20, 20, 20, 20, 20, 0,  0,  0,  20, 0,  0,  0,  0,  0,  
20, 20, 20, 20, 20, 0,  20, 0,  20, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  
20, 0,  0,  0,  20, 0,  0,  20, 20, 0,  0,  0,  20, 20, 20, 20, 0,  0,  0,  0,  0,  
20, 20, 0,  0,  0,  0,  0,  20, 0,  0,  0,  0,  0,  0,  0,  20, 20, 20, 20, 20, 0,  
20, 20, 20, 0,   0, 20, 20, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  20, 20, 
0,  0,  0,  0,  0,  0,  0,  20, 0,  0,  0,  0,  20, 20, 20, 20, 0,  0,  20, 20, 20, 
20, 20, 20, 0,  20, 20, 0,  0,  0,  0,  0,  0,  0,  20, 20, 0,  0,  0,  0,  0,  0,  
0,  0,  0,  0,  0,  0,  0,  20, 0,  0,  0,  0,  0,  0,  20, 20, 20, 20, 20, 20, 20, 
0,  0,  20, 0,  0,  0,  20, 0,  0,  20, 20, 20, 0,  0,  0,  0,  0,  0,  20, 0,  0,  
20, 0,  0,  0,  0,  0,  20, 0,  20, 0,  0,  0,  0,  0,  0,  0,  0,  0,  20, 20, 20, 
0,  20, 0,  20, 20, 0,  0,  0,  20, 20, 0,  0,  20, 20, 0,  0,  0,  0,  0,  0,  0,  
20, 0,  0,  0,  20, 0,  20, 20, 20, 0,  0,  0,  20, 0,  20, 20, 0,  0,  0,  0,  0,  
20, 0,  0,  20, 20, 0,  20, 20, 20, 0,  0,  0,  0,  0,  0,  20, 0,  0,  0,  0,  0,  
0,  0,  0,  0,  0,  20, 0,  20, 0,  0,  0,  0,  0,  0,  0,  20, 20, 20, 20, 20, 20, 
20, 0,  0,  0,  20, 20, 0,  0,  0,  0,  0,  0,  0,  0,  20, 0,  0,  0,  20, 20, 20, 
0,  0,  0,  0,  0,  0,  0,  0,  20, 20, 20, 20, 20, 20, 0,  0,  0,  0,  0,  0,  0,  
20, 20, 20, 20, 20, 20, 20, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  
0,  0,  0,  0,  0,  0,  20, 20, 0,  20, 0,  20, 0,  0,  0,  20, 20, 20, 0,  20, 0,  
0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  
0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  

 */