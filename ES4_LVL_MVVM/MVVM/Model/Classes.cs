using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES4_LVL_MVVM.MVVM.Model
{
    internal class Classes
    {
        private string _name;
        private string _display_name;
        private int[] _major_skill_bonuses;
        private int[] _attribute_bonuses;

        public string Name { get { return _name; } set { _name = value; } }
        public string Display_Name { get { return _display_name; } set { _display_name = value; } }
        public int[] Major_Skill_Bonuses { get { return _major_skill_bonuses; } set { _major_skill_bonuses = value; } }
        public int[] Attribute_Bonuses { get { return _attribute_bonuses; } set { _attribute_bonuses = value; } }




    }
}
