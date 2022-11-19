using ES4_LVL_F;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES4_LVL_MVVM.MVVM.Model
{

    public enum Races
    {
        Altmer,
        Argonian,
        Bosmer,
        Breton,
        Dunmer,
        Imperial,
        Khajiit,
        Nord,
        Orc,
        Redguard
    }



    public class Race
    {
        private bool _gender;
        private Races _race;
        private string _display_name;
        private int[] _gender_race_attribute_base;
        private int[] _race_skill_bonus;
        private string _image;

        public bool Gender { get { return _gender; } set { _gender = value; } }
        public Races Race_ { get { return _race; } set { _race = value; } }
        public string Display_Name { get { return _display_name; } set { _display_name = value; } }
        public int[] Gender_Race_Attribute_Base { get { return _gender_race_attribute_base; } set { _gender_race_attribute_base = value; } }
        public int[] Race_skill_bonus { get { return _race_skill_bonus; } set { _race_skill_bonus = value; } }
        public string Image { get { return _image; } set { _image = value; } }

        public Race(bool gender, Races race)
        {
            _race = race;
            _gender = gender;

            switch (race)
            {                                
                case Races.Altmer:
                    _image =  "altmer.png";
                    _display_name = "High Elf";  Race_skill_bonus = new int[21] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 10, 10, 10, 0 }; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 30, 40, 30, 40, 40, 50, 40, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 30, 30, 40, 40, 40, 50, 40, 50 }; } 
                    break;
                case Races.Argonian:
                    _image =  "argonian.png";
                    _display_name = "Argonian";  Race_skill_bonus = new int[21] { 5,  0,  5,  0,  0,  0,  10, 0,  0,  10, 0,  0,  0,  0,  5,  5,  0,  5,  0,  0,  0}; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 40, 30, 50, 50, 30, 40, 30, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 40, 30, 40, 40, 30, 50, 40, 50 }; } 
                    break;
                case Races.Bosmer:
                    _image =  "bosmer.png";
                    _display_name = "Wood Elf";  Race_skill_bonus = new int[21] { 0,  0,  0,  0,  0,  0,  0,  5,  5,  0,  10, 10, 0,  0,  0,  10, 0,  0,  5,  0,  0}; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 30, 40, 50, 50, 30, 40, 30, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 30, 30, 50, 50, 40, 40, 30, 50 }; } 
                    break;
                case Races.Breton:
                    _image =  "breton.png";
                    _display_name = "Breton";    Race_skill_bonus = new int[21] { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  5,  5,  10, 10, 5,  0,  10}; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 40, 30, 30, 30, 40, 50, 50, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 30, 30, 40, 30, 40, 50, 50, 50 }; } 
                    break;
                case Races.Dunmer:
                    _image =  "dunmer.png";
                    _display_name = "Dark Elf";  Race_skill_bonus = new int[21] { 10, 5,  0,  0,  0,  0,  5,  0,  5,  0,  0,  5,  0,  0,  0,  0,  0,  5,  0,  10, 0 }; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 40, 40, 50, 40, 30, 40, 30, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 40, 30, 50, 40, 40, 40, 30, 50 }; } 
                    break;
                case Races.Imperial:
                    _image =  "imperial.png";
                    _display_name = "Imperial";  Race_skill_bonus = new int[21] { 5,  5,  5,  0,  0,  10, 0,  0,  0,  0,  0,  0,  10, 10, 0,  0,  0,  0,  0,  0,  0 }; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 40, 40, 40, 30, 50, 40, 30, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 40, 40, 30, 30, 50, 40, 40, 50 }; } 
                    break;
                case Races.Khajiit:
                    _image =  "khajiit.png";
                    _display_name = "Khajiit";   Race_skill_bonus = new int[21] { 5,  0,  10, 0,  0,  0,  5,  10, 5,  5,  5,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 }; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 40, 30, 40, 50, 40, 40, 30, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 30, 40, 40, 50, 40, 40, 30, 50 }; } 
                    break;
                case Races.Nord:
                    _image =  "nord.png";
                    _display_name = "Nord";      Race_skill_bonus = new int[21] { 10, 10, 0,  5,  5,  10, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  5 }; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 50, 50, 40, 40, 30, 30, 30, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 50, 40, 40, 40, 30, 30, 40, 50 }; } 
                    break;
                case Races.Orc:
                    _image =  "orsimer.png";
                    _display_name = "Orc";       Race_skill_bonus = new int[21] { 0,  10, 5,  10, 10, 10, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 }; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 45, 50, 30, 35, 30, 30, 50, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 45, 50, 30, 35, 25, 40, 45, 50 }; } 
                    break;
                case Races.Redguard:
                    _image = "redguard.png";
                    _display_name = "Redguard";  Race_skill_bonus = new int[21] { 10, 10, 0,  0,  0,  5,  10, 0,  5,  0,  0,  0,  5,  0,  0,  0,  0,  0,  0,  0,  0 }; 
                    if (gender)     { Gender_Race_Attribute_Base = new int[8] { 50, 50, 40, 40, 30, 30, 30, 50 }; } 
                    else            { Gender_Race_Attribute_Base = new int[8] { 40, 50, 40, 40, 40, 30, 30, 50 }; } 
                    break;
                                                                                         
            }



        }

    }
}




/*
30, 40, 30, 40, 40, 50, 40, 50
40, 30, 50, 50, 30, 40, 30, 50
30, 40, 50, 50, 30, 40, 30, 50
40, 30, 30, 30, 40, 50, 50, 50 
40, 40, 50, 40, 30, 40, 30, 50
40, 40, 40, 30, 50, 40, 30, 50
40, 30, 40, 50, 40, 40, 30, 50
50, 50, 40, 40, 30, 30, 30, 50 
45, 50, 30, 35, 30, 30, 50, 50
50, 50, 40, 40, 30, 30, 30, 50

30, 30, 40, 40, 40, 50, 40, 50
40, 30, 40, 40, 30, 50, 40, 50
30, 30, 50, 50, 40, 40, 30, 50
30, 30, 40, 30, 40, 50, 50, 50
40, 30, 50, 40, 40, 40, 30, 50
40, 40, 30, 30, 50, 40, 40, 50
30, 40, 40, 50, 40, 40, 30, 50
50, 40, 40, 40, 30, 30, 40, 50
45, 50, 30, 35, 25, 40, 45, 50
40, 50, 40, 40, 40, 30, 30, 50

BLA BLU H2H ARM BLO HVA ATH ACR LTA SEC SNK MRK MER SPE ILU ALC CON MYS ALT DES RES 
0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  5,  5,  5,  10, 10, 10, 0 
5,  0,  5,  0,  0,  0,  10, 0,  0,  10, 0,  0,  0,  0,  5,  5,  0,  5,  0,  0,  0
0,  0,  0,  0,  0,  0,  0,  5,  5,  0,  10, 10, 0,  0,  0,  10, 0,  0,  5,  0,  0
0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  5,  5,  10, 10, 5,  0,  10
10, 5,  0,  0,  0,  0,  5,  0,  5,  0,  0,  5,  0,  0,  0,  0,  0,  5,  0,  10, 0 
5,  5,  5,  0,  0,  10, 0,  0,  0,  0,  0,  0,  10, 10, 0,  0,  0,  0,  0,  0,  0 
5,  0,  10, 0,  0,  0,  5,  10, 5,  5,  5,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 
10, 10, 0,  5,  5,  10, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  5 
0,  10, 5,  10, 10, 10, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 
10, 10, 0,  0,  0,  5,  10, 0,  5,  0,  0,  0,  5,  0,  0,  0,  0,  0,  0,  0,  0 

*/