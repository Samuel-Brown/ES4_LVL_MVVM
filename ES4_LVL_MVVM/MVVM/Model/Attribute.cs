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
        private int[] _level;
        private Image _image;

        public Attributes Name { get { return _name; } set { _name = value; } }
        public string Display_Name { get { return _display_name; } set { _display_name = value; } }
        public int[] Level { get { return _level; } set { _level = value; } }
        public Image Image { get { return _image; } set { _image = value; } }


        public Attribute(Attributes name, int[] level)
        {
            Name = name;
            Level = level;

            switch (name)
            {
                case Attributes.Strength:        Display_Name = "Strength";      Image = new Image { Source = "strength.gif" };      break;
                case Attributes.Endurance:       Display_Name = "Endurance";     Image = new Image { Source = "endurance.gif" };     break;
                case Attributes.Speed:           Display_Name = "Speed";         Image = new Image { Source = "speed.gif" };         break;
                case Attributes.Agility:         Display_Name = "Agility";       Image = new Image { Source = "agility.gif" };       break;
                case Attributes.Personality:     Display_Name = "Personality";   Image = new Image { Source = "personality.gif" };   break;
                case Attributes.Intelligence:    Display_Name = "Intelligence";  Image = new Image { Source = "intelligence.gif" };  break;
                case Attributes.Willpower:       Display_Name = "Willpower";     Image = new Image { Source = "willpower.gif" };     break;
                case Attributes.Luck:            Display_Name = "Luck";          Image = new Image { Source = "luck.gif" };          break;
            }


        }

    }
}
