using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES4_LVL_MVVM.MVVM.Model
{

    public enum Birthsigns
    {
        Apprentice, 
        Atronach,
        Lady,
        Lord,
        Lover,
        Mage,
        Ritual,
        Serpent,
        Shadow,
        Steed,
        Thief,
        Tower,
        Warrior
    }



    public class Birthsign
    {
        private Birthsigns _birthsign;
        private string _display_name;
        private int[] _attribute_bonus;

        public Birthsigns Birthsign_ { get { return _birthsign; } set { _birthsign = value; } }
        public string Display_Name { get { return _display_name; } set { _display_name = value; } }
        public int[] Attribute_Bonus { get { return _attribute_bonus; } set { _attribute_bonus = value; } }

        public Birthsign(Birthsigns birthsign)
        {
            Birthsign_ = birthsign;
            switch (birthsign)
            {                                                                               //                  Str End Spe Agi Per Int Wil Luc
                case Birthsigns.Apprentice:     Display_Name = "Apprentice";    Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 } ; break;
                case Birthsigns.Atronach:       Display_Name = "Atronach";      Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Lady:           Display_Name = "Lady";          Attribute_Bonus = new int[8] {  0, 10,  0,  0,  0,  0, 10,  0 }; break;
                case Birthsigns.Lord:           Display_Name = "Lord";          Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Lover:          Display_Name = "Lover";         Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Mage:           Display_Name = "Mage";          Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Ritual:         Display_Name = "Ritual";        Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Serpent:        Display_Name = "Serpent";       Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Shadow:         Display_Name = "Shadow";        Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Steed:          Display_Name = "Steed";         Attribute_Bonus = new int[8] {  0,  0, 20,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Thief:          Display_Name = "Thief";         Attribute_Bonus = new int[8] {  0,  0, 10, 10,  0,  0,  0, 10 }; break;
                case Birthsigns.Tower:          Display_Name = "Tower";         Attribute_Bonus = new int[8] {  0,  0,  0,  0,  0,  0,  0,  0 }; break;
                case Birthsigns.Warrior:        Display_Name = "Warrior";       Attribute_Bonus = new int[8] { 10, 10,  0,  0,  0,  0,  0,  0 }; break;

            }
        }



    }
}