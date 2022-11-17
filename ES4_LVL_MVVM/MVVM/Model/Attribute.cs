using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ES4_LVL_MVVM.MVVM.Model
{
    internal class Attribute
    {
        private string _name;
        private string _display_name;
        private int[] _level;
        private Image _image;

        public string Name { get { return _name; } set { _name = value; } }
        public string Display_Name { get { return _display_name; } set { _display_name = value; } }
        public int[] Level { get { return _level; } set { _level = value; } }
        public Image Image { get { return _image; } set { _image = value; } }


        public Attribute(string name, int[] level)
        {
            Name = name;
            Level = level;

            switch (name)
            {
                case "Strength":        Display_Name = "Strength";      Image = new Image { Source = "strength.gif" };      break;
                case "Endurance":       Display_Name = "Endurance";     Image = new Image { Source = "endurance.gif" };     break;
                case "Speed":           Display_Name = "Speed";         Image = new Image { Source = "speed.gif" };         break;
                case "Agility":         Display_Name = "Agility";       Image = new Image { Source = "agility.gif" };       break;
                case "Personality":     Display_Name = "Personality";   Image = new Image { Source = "personality.gif" };   break;
                case "Intelligence":    Display_Name = "Intelligence";  Image = new Image { Source = "intelligence.gif" };  break;
                case "Willpower":       Display_Name = "Willpower";     Image = new Image { Source = "willpower.gif" };     break;
                case "Luck":            Display_Name = "Luck";          Image = new Image { Source = "luck.gif" };          break;
            }


        }

    }
}
