namespace ES4_LVL_F

open ES4_LVL_F.Races
open ES4_LVL_F.Birthsigns
open ES4_LVL_F.Classes
open ES4_LVL_F.Levels

type Character =
    { 
    Name                : string 
    Race                : Race
    Gender              : Gender
    Specialization      : Specialization 
    Birthsign           : Birthsign
    StandardClass       : Class

    Base_Armorer        : int
    Base_Athletics      : int
    Base_Blade          : int
    Base_Block          : int
    Base_Blunt          : int
    Base_Hand_to_Hand   : int
    Base_Heavy_Armor    : int
    Base_Alchemy        : int
    Base_Alteration     : int
    Base_Conjuration    : int
    Base_Destruction    : int
    Base_Illusion       : int
    Base_Mysticism      : int
    Base_Restoration    : int
    Base_Acrobatics     : int
    Base_Light_Armor    : int
    Base_Marksman       : int
    Base_Mercantile     : int
    Base_Security       : int
    Base_Sneak          : int
    Base_Speechcraft    : int

    Base_Strength       : int
    Base_Intelligence   : int
    Base_Willpower      : int
    Base_Agility        : int
    Base_Speed          : int
    Base_Endurance      : int
    Base_Personality    : int
    Base_Luck           : int

    OverallLevel        : int

   
    }

    module Characters =
        let New_Character (name, race, gender, specialisation, birthsign, standardClass) = 
            {
                Name                = name;
                Race                = race;
                Gender              = gender;
                Specialization      = specialisation;
                Birthsign           = birthsign;
                StandardClass       = standardClass;

                Base_Armorer        = 5 + Race_Starting_Skill_Bonus(race)[0] + Class_Major_Skill_Bonus(standardClass)[0]
                Base_Athletics      = 5 + Race_Starting_Skill_Bonus(race)[1] + Class_Major_Skill_Bonus(standardClass)[1]
                Base_Blade          = 5 + Race_Starting_Skill_Bonus(race)[2] + Class_Major_Skill_Bonus(standardClass)[2]
                Base_Block          = 5 + Race_Starting_Skill_Bonus(race)[3] + Class_Major_Skill_Bonus(standardClass)[3]
                Base_Blunt          = 5 + Race_Starting_Skill_Bonus(race)[4] + Class_Major_Skill_Bonus(standardClass)[4]
                Base_Hand_to_Hand   = 5 + Race_Starting_Skill_Bonus(race)[5] + Class_Major_Skill_Bonus(standardClass)[5]
                Base_Heavy_Armor    = 5 + Race_Starting_Skill_Bonus(race)[6] + Class_Major_Skill_Bonus(standardClass)[6]
                Base_Alchemy        = 5 + Race_Starting_Skill_Bonus(race)[7] + Class_Major_Skill_Bonus(standardClass)[7]
                Base_Alteration     = 5 + Race_Starting_Skill_Bonus(race)[8] + Class_Major_Skill_Bonus(standardClass)[8]
                Base_Conjuration    = 5 + Race_Starting_Skill_Bonus(race)[9] + Class_Major_Skill_Bonus(standardClass)[9]
                Base_Destruction    = 5 + Race_Starting_Skill_Bonus(race)[10] + Class_Major_Skill_Bonus(standardClass)[10]
                Base_Illusion       = 5 + Race_Starting_Skill_Bonus(race)[11] + Class_Major_Skill_Bonus(standardClass)[11]
                Base_Mysticism      = 5 + Race_Starting_Skill_Bonus(race)[12] + Class_Major_Skill_Bonus(standardClass)[12]
                Base_Restoration    = 5 + Race_Starting_Skill_Bonus(race)[13] + Class_Major_Skill_Bonus(standardClass)[13]
                Base_Acrobatics     = 5 + Race_Starting_Skill_Bonus(race)[14] + Class_Major_Skill_Bonus(standardClass)[14]
                Base_Light_Armor    = 5 + Race_Starting_Skill_Bonus(race)[15] + Class_Major_Skill_Bonus(standardClass)[15]
                Base_Marksman       = 5 + Race_Starting_Skill_Bonus(race)[16] + Class_Major_Skill_Bonus(standardClass)[16]
                Base_Mercantile     = 5 + Race_Starting_Skill_Bonus(race)[17] + Class_Major_Skill_Bonus(standardClass)[17]
                Base_Security       = 5 + Race_Starting_Skill_Bonus(race)[18] + Class_Major_Skill_Bonus(standardClass)[18]
                Base_Sneak          = 5 + Race_Starting_Skill_Bonus(race)[19] + Class_Major_Skill_Bonus(standardClass)[19]
                Base_Speechcraft    = 5 + Race_Starting_Skill_Bonus(race)[20] + Class_Major_Skill_Bonus(standardClass)[20]

                Base_Strength       = Race_Starting_Attributes(race,gender)[0] + Birthsign_Attribute_Bonus(birthsign)[0] + Class_Attribute_Bonus(standardClass)[0]
                Base_Intelligence   = Race_Starting_Attributes(race,gender)[1] + Birthsign_Attribute_Bonus(birthsign)[1] + Class_Attribute_Bonus(standardClass)[1]
                Base_Willpower      = Race_Starting_Attributes(race,gender)[2] + Birthsign_Attribute_Bonus(birthsign)[2] + Class_Attribute_Bonus(standardClass)[2]
                Base_Agility        = Race_Starting_Attributes(race,gender)[3] + Birthsign_Attribute_Bonus(birthsign)[3] + Class_Attribute_Bonus(standardClass)[3]
                Base_Speed          = Race_Starting_Attributes(race,gender)[4] + Birthsign_Attribute_Bonus(birthsign)[4] + Class_Attribute_Bonus(standardClass)[4]
                Base_Endurance      = Race_Starting_Attributes(race,gender)[5] + Birthsign_Attribute_Bonus(birthsign)[5] + Class_Attribute_Bonus(standardClass)[5] 
                Base_Personality    = Race_Starting_Attributes(race,gender)[6] + Birthsign_Attribute_Bonus(birthsign)[6] + Class_Attribute_Bonus(standardClass)[6]
                Base_Luck           = Race_Starting_Attributes(race,gender)[7] + Birthsign_Attribute_Bonus(birthsign)[7] + Class_Attribute_Bonus(standardClass)[7]

                OverallLevel        = 0
            }

    
        

