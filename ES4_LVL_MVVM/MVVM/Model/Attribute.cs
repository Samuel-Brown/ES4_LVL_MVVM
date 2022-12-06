using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ES4_LVL_MVVM.MVVM.Model
{

    public enum Attributes
    {
        Strength,
        Endurance,
        Speed,
        Agility,
        Personality,
        Intelligence,
        Willpower,
        Luck
    }



    public class Attribute
    {
        private Attributes _name;
        private string _display_name;
        private int[] _levels;
        private string _image;

        public Attributes Name { get { return _name; } set { _name = value; } }
        public string Display_Name { get { return _display_name; } set { _display_name = value; } }
        public int[] Levels { get { return _levels; } set { _levels = value; } }
        public string Image { get { return _image; } set { _image = value; } }

        public int CurrentLevel { get { return _levels.LastOrDefault(); } }
        public Attribute(Attributes name, int[] levels)
        {
            Name = name;
            Levels = levels;

            switch (name)
            {
                case Attributes.Strength:        Display_Name = "Strength";      Image =  "strength.gif" ;      break;
                case Attributes.Endurance:       Display_Name = "Endurance";     Image =  "endurance.gif" ;     break;
                case Attributes.Speed:           Display_Name = "Speed";         Image =  "speed.gif" ;         break;
                case Attributes.Agility:         Display_Name = "Agility";       Image =  "agility.gif" ;       break;
                case Attributes.Personality:     Display_Name = "Personality";   Image =  "personality.gif" ;   break;
                case Attributes.Intelligence:    Display_Name = "Intelligence";  Image =  "intelligence.gif" ;  break;
                case Attributes.Willpower:       Display_Name = "Willpower";     Image =  "willpower.gif" ;     break;
                case Attributes.Luck:            Display_Name = "Luck";          Image =  "luck.gif" ;          break;
            }


        }

    }
}
