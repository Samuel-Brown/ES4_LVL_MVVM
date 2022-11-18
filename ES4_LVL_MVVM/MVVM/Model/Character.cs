using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.MVVM.Model
{
    public class Character
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
        public Attribute[] Char_Attributes { get { return _attributes; } set { _attributes = value; } }
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


        public Character (string name, Race race, string specialization, Birthsign birthsign, GameClass gameClass)
        {
            Skill[] Temp_Skills = new Skill[21];
            Attribute[] Temp_Attributes = new Attribute[8];
            int Temp_Level = 0;


            for (int i = 0; i < 21; i++)
            {
                bool Temp_Is_Major;

                if (gameClass.Major_Skill_Bonuses[i] > 0) { Temp_Is_Major = true; } else { Temp_Is_Major = false; }

                switch (i)
                {     //BLA BLU H2H ARM BLO HVA ATH ACR LTA SEC SNK MRK MER SPE ILU ALC CON MYS ALT DES RES 
                    case 0:     Temp_Skills[i] = new Skill(Skills.Blade,        new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 1:     Temp_Skills[i] = new Skill(Skills.Blunt,        new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 2:     Temp_Skills[i] = new Skill(Skills.Hand_to_Hand, new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 3:     Temp_Skills[i] = new Skill(Skills.Armorer,      new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 4:     Temp_Skills[i] = new Skill(Skills.Block,        new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 5:     Temp_Skills[i] = new Skill(Skills.Heavy_Armor,  new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 6:     Temp_Skills[i] = new Skill(Skills.Athletics,    new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 7:     Temp_Skills[i] = new Skill(Skills.Acrobatics,   new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 8:     Temp_Skills[i] = new Skill(Skills.Light_Armor,  new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 9:     Temp_Skills[i] = new Skill(Skills.Security,     new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 10:    Temp_Skills[i] = new Skill(Skills.Sneak,        new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 11:    Temp_Skills[i] = new Skill(Skills.Marksman,     new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 12:    Temp_Skills[i] = new Skill(Skills.Mercantile,   new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 13:    Temp_Skills[i] = new Skill(Skills.Speechcraft,  new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 14:    Temp_Skills[i] = new Skill(Skills.Illusion,     new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 15:    Temp_Skills[i] = new Skill(Skills.Alchemy,      new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 16:    Temp_Skills[i] = new Skill(Skills.Conjuration,  new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 17:    Temp_Skills[i] = new Skill(Skills.Mysticism,    new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 18:    Temp_Skills[i] = new Skill(Skills.Alteration,   new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 19:    Temp_Skills[i] = new Skill(Skills.Destruction,  new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                    case 20:    Temp_Skills[i] = new Skill(Skills.Restoration,  new int[] { 5 + race.Race_skill_bonus[i] + gameClass.Major_Skill_Bonuses[i] }, Temp_Is_Major); break;
                }

            }

            for (int i = 0; i < 8; i++)
            {

                switch (i) 
                { 
                    case 0: Temp_Attributes[i] = new Attribute(Attributes.Strength,     new int[] { race.Gender_Race_Attribute_Base[i] + gameClass.Attribute_Bonuses[i] + birthsign.Attribute_Bonus[i] });   break;
                    case 1: Temp_Attributes[i] = new Attribute(Attributes.Endurance,    new int[] { race.Gender_Race_Attribute_Base[i] + gameClass.Attribute_Bonuses[i] + birthsign.Attribute_Bonus[i] });   break;
                    case 2: Temp_Attributes[i] = new Attribute(Attributes.Speed,        new int[] { race.Gender_Race_Attribute_Base[i] + gameClass.Attribute_Bonuses[i] + birthsign.Attribute_Bonus[i] });   break;
                    case 3: Temp_Attributes[i] = new Attribute(Attributes.Agility,      new int[] { race.Gender_Race_Attribute_Base[i] + gameClass.Attribute_Bonuses[i] + birthsign.Attribute_Bonus[i] });   break;
                    case 4: Temp_Attributes[i] = new Attribute(Attributes.Personality,  new int[] { race.Gender_Race_Attribute_Base[i] + gameClass.Attribute_Bonuses[i] + birthsign.Attribute_Bonus[i] });   break;
                    case 5: Temp_Attributes[i] = new Attribute(Attributes.Intelligence, new int[] { race.Gender_Race_Attribute_Base[i] + gameClass.Attribute_Bonuses[i] + birthsign.Attribute_Bonus[i] });   break;
                    case 6: Temp_Attributes[i] = new Attribute(Attributes.Willpower,    new int[] { race.Gender_Race_Attribute_Base[i] + gameClass.Attribute_Bonuses[i] + birthsign.Attribute_Bonus[i] });   break;
                    case 7: Temp_Attributes[i] = new Attribute(Attributes.Luck,         new int[] { race.Gender_Race_Attribute_Base[i] + gameClass.Attribute_Bonuses[i] + birthsign.Attribute_Bonus[i] });   break;
                }
            }





                //Character Temp_Character = new Character(Temp_Skills, Temp_Attributes, Temp_Level, name, race, specialization, birthsign, gameClass);


            _skills = Temp_Skills;
            _attributes = Temp_Attributes;
            _level = Temp_Level;
            _name = name;
            _race = race;
            _specialization = specialization;
            _birthsign = birthsign;
            _gameClass = gameClass;



        }


    }
}
