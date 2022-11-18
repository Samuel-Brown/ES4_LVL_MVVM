using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.MVVM.Model
{
    internal class Character
    {

        private Skill[] _skills;
        private Attribute[] _attributes;
        private int _level;
        private string _name;
        private Race _race;
        private string _specialization;
        private Birthsign _birthsign;
        private string _easter_egg;
        private GameClass _gameClass;


        public Skill[] Char_Skills { get { return _skills; } set { _skills = value; } }
        public Attribute[] Attributes { get { return _attributes; } set { _attributes = value; } }
        public int Level { get { return _level; } set { _level = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public Race Race { get { return _race; } set { _race = value; } }
        public string Specialization { get { return _specialization; } set { _specialization = value; } }
        public Birthsign Birthsign { get { return _birthsign; } set { _birthsign = value; } }
        public string Easter_Egg { get { return _easter_egg; } set { _easter_egg = value; } }
        public GameClass GameClass { get { return _gameClass; } set { _gameClass = value; } }



        public Character(Skill[] skills, Attribute[] attributes, int level, string name, Race race, string specialization, Birthsign birthsign, GameClass gameClass)
        {
            _skills = skills;
            _attributes = attributes;
            _level = level;
            _name = name;
            _race = race;
            _specialization = specialization;
            _birthsign = birthsign;
            _gameClass = gameClass;

            //Easter egg for my little brother
            _easter_egg = "jamie wos here, lol, beep boop beep hackz activated";
        }


        public Character NewCharacter(string name, Race race, string specialization, Birthsign birthsign, GameClass gameClass)
        {
            Skill[] Temp_Skills = new Skill[21];
            Attribute[] Temp_Attributes = new Attribute[] { };
            int Temp_Level = 0;





            Temp_Skills[0] = new Skill(Skills.Blade, new int[] { 5 + race.Race_skill_bonus[(int)Skills.Blade] + gameClass.Major_Skill_Bonuses[(int)Skills.Blade] }, true);
                
            

            //Character Temp_Character = new Character();

            return null;

        }


    }
}
