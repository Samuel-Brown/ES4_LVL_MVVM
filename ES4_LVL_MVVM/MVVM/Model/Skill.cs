using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES4_LVL_MVVM.MVVM.Model
{

    public enum Skills
    {
        Blade,
        Blunt,
        Hand_to_Hand,
        Armorer,
        Block,
        Heavy_Armor,
        Athletics,
        Acrobatics,
        Light_Armor,
        Security,
        Sneak,
        Marksman,
        Mercantile,
        Speechcraft,
        Illusion,
        Alchemy,
        Conjuration,
        Mysticism,
        Alteration,
        Destruction,
        Restoration
    }





    public class Skill
    {

        private Skills _name;
        private string _display_name;
        private int[] _levels;
        private string _image;
        private bool _is_major;
        private string _associated_attribute;

        public Skills Name { get { return _name; } set { _name = value; } }
        public string Display_Name { get { return _display_name; } set { _display_name = value; } }
        public int[] Levels { get { return _levels; } set { _levels = value; } }
        public string Image { get { return _image; } set { _image = value; } }
        public bool Is_Major { get { return _is_major; } set { _is_major = value; } }
        public string Associated_Attribute { get { return _associated_attribute; } set { _associated_attribute = value; } }

        public Skill(Skills name, int[] levels, bool is_major)
        {
            Name = name;
            Levels = levels;
            Is_Major = is_major;

            switch (name)
            {     //BLA BLU H2H ARM BLO HVA ATH ACR LTA SEC SNK MRK MER SPE ILU ALC CON MYS ALT DES RES 
                case Skills.Blade:           Display_Name = "Blade";         Image = "blade.gif" ;         Associated_Attribute = "Strength";      break;
                case Skills.Blunt:           Display_Name = "Blunt";         Image = "blunt.gif" ;         Associated_Attribute = "Strength";      break;
                case Skills.Hand_to_Hand:    Display_Name = "Hand to Hand";  Image = "hand_to_hand.gif" ;  Associated_Attribute = "Strength";      break;
                case Skills.Armorer:         Display_Name = "Armorer";       Image = "armorer.gif" ;       Associated_Attribute = "Endurance";     break;
                case Skills.Block:           Display_Name = "Block";         Image = "block.gif" ;         Associated_Attribute = "Endurance";     break;
                case Skills.Heavy_Armor:     Display_Name = "Heavy Armor";   Image = "heavy_armor.gif" ;   Associated_Attribute = "Endurance";     break;
                case Skills.Athletics:       Display_Name = "Athletics";     Image = "athletics.gif" ;     Associated_Attribute = "Speed";         break;
                case Skills.Acrobatics:      Display_Name = "Acrobatics";    Image = "acrobatics.gif" ;    Associated_Attribute = "Speed";         break;
                case Skills.Light_Armor:     Display_Name = "Light Armor";   Image = "light_armor.gif" ;   Associated_Attribute = "Speed";         break;
                case Skills.Security:        Display_Name = "Security";      Image = "security.gif" ;      Associated_Attribute = "Agility";       break;
                case Skills.Sneak:           Display_Name = "Sneak";         Image = "sneak.gif" ;         Associated_Attribute = "Agility";       break;
                case Skills.Marksman:        Display_Name = "Marksman";      Image = "marksman.gif" ;      Associated_Attribute = "Agility";       break;
                case Skills.Mercantile:      Display_Name = "Mercantile";    Image = "mercantile.gif" ;    Associated_Attribute = "Personality";   break;
                case Skills.Speechcraft:     Display_Name = "Speechcraft";   Image = "speechcraft.gif" ;   Associated_Attribute = "Personality";   break;
                case Skills.Illusion:        Display_Name = "Illusion";      Image = "illusion.gif" ;      Associated_Attribute = "Personality";   break;
                case Skills.Alchemy:         Display_Name = "Alchemy";       Image = "alchemy.gif" ;       Associated_Attribute = "Intelligence";  break;
                case Skills.Conjuration:     Display_Name = "Conjuration";   Image = "conjuration.gif" ;   Associated_Attribute = "Intelligence";  break;
                case Skills.Mysticism:       Display_Name = "Mysticism";     Image = "mysticism.gif" ;     Associated_Attribute = "Intelligence";  break;
                case Skills.Alteration:      Display_Name = "Alteration";    Image = "alteration.gif" ;    Associated_Attribute = "Willpower";     break;
                case Skills.Destruction:     Display_Name = "Destruction";   Image = "destruction.gif" ;   Associated_Attribute = "Willpower";     break;
                case Skills.Restoration:     Display_Name = "Restoration";   Image = "restoration.gif" ;   Associated_Attribute = "Willpower";     break;
            }

        }

    }
}