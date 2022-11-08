namespace ES4_LVL_F

open ES4_LVL_F.Races
open ES4_LVL_F.Birthsigns
open ES4_LVL_F.Classes
open ES4_LVL_F.Levels
open ES4_LVL_F.Skills

type Character =
    { 
    Name                : string 
    Race                : Race
    Gender              : Gender
    Specialization      : Specialization 
    Birthsign           : Birthsign
    StandardClass       : Class

    ClassName           : string

    Base_Armorer            : int
    Armorer                 : int
    Armorer_Is_Major        : bool

    Base_Athletics          : int
    Athletics               : int
    Athletics_Is_Major      : bool

    Base_Blade              : int
    Blade                   : int
    Blade_Is_Major          : bool


    Base_Block              : int
    Block                   : int
    Block_Is_Major          : bool


    Base_Blunt              : int
    Blunt                   : int
    Blunt_Is_Major          : bool


    Base_Hand_to_Hand       : int
    Hand_to_Hand            : int
    Hand_to_Hand_Is_Major   : bool


    Base_Heavy_Armor        : int
    Heavy_Armor             : int
    Heavy_Armor_Is_Major    : bool


    Base_Alchemy            : int
    Alchemy                 : int
    Alchemy_Is_Major        : bool


    Base_Alteration         : int
    Alteration              : int
    Alteration_Is_Major     : bool


    Base_Conjuration        : int
    Conjuration             : int
    Conjuration_Is_Major    : bool


    Base_Destruction        : int
    Destruction             : int
    Destruction_Is_Major    : bool


    Base_Illusion           : int
    Illusion                : int
    Illusion_Is_Major       : bool


    Base_Mysticism          : int
    Mysticism               : int
    Mysticism_Is_Major      : bool


    Base_Restoration        : int
    Restoration             : int
    Restoration_Is_Major    : bool


    Base_Acrobatics         : int
    Acrobatics              : int
    Acrobatics_Is_Major     : bool


    Base_Light_Armor        : int
    Light_Armor             : int
    Light_Armor_Is_Major    : bool


    Base_Marksman           : int
    Marksman                : int
    Marksman_Is_Major       : bool


    Base_Mercantile         : int
    Mercantile              : int
    Mercantile_Is_Major     : bool


    Base_Security           : int
    Security                : int
    Security_Is_Major       : bool


    Base_Sneak              : int
    Sneak                   : int
    Sneak_Is_Major          : bool


    Base_Speechcraft        : int
    Speechcraft             : int
    Speechcraft_Is_Major    : bool


    Base_Strength       : int
    Strength            : int
    Base_Intelligence   : int
    Intelligence        : int
    Base_Willpower      : int
    Willpower           : int
    Base_Agility        : int
    Agility             : int
    Base_Speed          : int
    Speed               : int
    Base_Endurance      : int
    Endurance           : int
    Base_Personality    : int
    Personality         : int
    Base_Luck           : int
    Luck                : int

    OverallLevel        : int

    CharacterLevels              : Level[]
   
    }

    module Characters =
        let positive_to_bool (i) = 
            if (i > 0) then true else false


        let Current_Attribute_Level (levels: Level[], attribute : Attribute) : int =
            let mutable temp = 0
            for i in levels do  temp <- temp + i.Strength_Add;
            let Strength           = temp
            temp <- 0
            for i in levels do  temp <- temp + i.Intelligence_Add;
            let Intelligence           = temp
            temp <- 0
            for i in levels do  temp <- temp + i.Willpower_Add;
            let Willpower           = temp
            temp <- 0
            for i in levels do  temp <- temp + i.Agility_Add;
            let Agility           = temp
            temp <- 0
            for i in levels do  temp <- temp + i.Speed_Add;
            let Speed           = temp
            temp <- 0
            for i in levels do  temp <- temp + i.Endurance_Add;
            let Endurance           = temp
            temp <- 0
            for i in levels do  temp <- temp + i.Personality_Add;
            let Personality           = temp
            temp <- 0
            for i in levels do  temp <- temp + i.Luck_Add;
            let Luck           = temp
            temp <- 0
            match attribute with 
                | Attribute.Strength        -> Strength 
                | Attribute.Intelligence    -> Intelligence 
                | Attribute.Willpower       -> Willpower 
                | Attribute.Agility         -> Agility 
                | Attribute.Speed           -> Speed 
                | Attribute.Endurance       -> Endurance 
                | Attribute.Personality     -> Personality 
                | Attribute.Luck            -> Luck 
                | _                         -> 0



        let Current_Skill_Level (levels: Level[], skill : Skill) : int = 
            let mutable temp = 0
            for i in levels do temp <- temp + i.Blade_Increased_By
            let Blade           = temp
            temp <- 0
            for i in levels do temp <- temp + i.Blunt_Increased_By
            let Blunt           = temp
            temp <- 0
            for i in levels do temp <- temp + i.Hand_to_Hand_Increased_By
            let Hand_to_Hand    = temp
            temp <- 0
            for i in levels do temp <- temp + i.Armorer_Increased_By
            let Armorer         = temp
            temp <- 0
            for i in levels do temp <- temp + i.Block_Increased_By
            let Block           = temp
            temp <- 0
            for i in levels do temp <- temp + i.Heavy_Armor_Increased_By
            let Heavy_Armor     = temp
            temp <- 0
            for i in levels do temp <- temp + i.Athletics_Increased_By
            let Athletics       = temp
            temp <- 0
            for i in levels do temp <- temp + i.Acrobatics_Increased_By
            let Acrobatics      = temp
            temp <- 0
            for i in levels do temp <- temp + i.Light_Armor_Increased_By
            let Light_Armor     = temp
            temp <- 0
            for i in levels do temp <- temp + i.Security_Increased_By
            let Security        = temp
            temp <- 0
            for i in levels do temp <- temp + i.Sneak_Increased_By
            let Sneak           = temp
            temp <- 0
            for i in levels do temp <- temp + i.Marksman_Increased_By
            let Marksman        = temp
            temp <- 0
            for i in levels do temp <- temp + i.Mercantile_Increased_By
            let Mercantile      = temp
            temp <- 0
            for i in levels do temp <- temp + i.Speechcraft_Increased_By
            let Speechcraft     = temp
            temp <- 0
            for i in levels do temp <- temp + i.Illusion_Increased_By
            let Illusion        = temp
            temp <- 0
            for i in levels do temp <- temp + i.Alchemy_Increased_By
            let Alchemy         = temp
            temp <- 0
            for i in levels do temp <- temp + i.Conjuration_Increased_By
            let Conjuration     = temp
            temp <- 0
            for i in levels do temp <- temp + i.Mysticism_Increased_By
            let Mysticism       = temp
            temp <- 0
            for i in levels do temp <- temp + i.Alteration_Increased_By
            let Alteration      = temp
            temp <- 0
            for i in levels do temp <- temp + i.Destruction_Increased_By
            let Destruction     = temp
            temp <- 0
            for i in levels do temp <- temp + i.Restoration_Increased_By
            let Restoration     = temp
            match skill with 
                | Skill.Blade             -> Blade
                | Skill.Blunt             -> Blunt
                | Skill.Hand_to_Hand      -> Hand_to_Hand
                | Skill.Armorer           -> Armorer
                | Skill.Block             -> Block
                | Skill.Heavy_Armor       -> Heavy_Armor
                | Skill.Athletics         -> Athletics
                | Skill.Acrobatics        -> Acrobatics
                | Skill.Light_Armor       -> Light_Armor
                | Skill.Security          -> Security
                | Skill.Sneak             -> Sneak
                | Skill.Marksman          -> Marksman
                | Skill.Mercantile        -> Mercantile
                | Skill.Speechcraft       -> Speechcraft
                | Skill.Illusion          -> Illusion
                | Skill.Alchemy           -> Alchemy
                | Skill.Conjuration       -> Conjuration
                | Skill.Mysticism         -> Mysticism
                | Skill.Alteration        -> Alteration
                | Skill.Destruction       -> Destruction
                | Skill.Restoration       -> Restoration
                | _                       -> 0


        let New_Character (name, race, gender, specialisation, birthsign, standardClass, levels: Level[]) = 
            {
                Name                = name;
                Race                = race;
                Gender              = gender;
                Specialization      = specialisation;
                Birthsign           = birthsign;
                StandardClass       = standardClass;

                ClassName = standardClass.ToString()

                CharacterLevels     = levels;

                

                Base_Armorer        = 5 + Race_Starting_Skill_Bonus(race)[0] + Class_Major_Skill_Bonus(standardClass)[0]
                Armorer             = 5 + Race_Starting_Skill_Bonus(race)[0] + Class_Major_Skill_Bonus(standardClass)[0] + Current_Skill_Level(levels,Skill.Armorer)
                Armorer_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[0])

                Base_Athletics      = 5 + Race_Starting_Skill_Bonus(race)[1] + Class_Major_Skill_Bonus(standardClass)[1]
                Athletics           = 5 + Race_Starting_Skill_Bonus(race)[1] + Class_Major_Skill_Bonus(standardClass)[1] + Current_Skill_Level(levels,Skill.Athletics)
                Athletics_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[1])

                Base_Blade          = 5 + Race_Starting_Skill_Bonus(race)[2] + Class_Major_Skill_Bonus(standardClass)[2]
                Blade               = 5 + Race_Starting_Skill_Bonus(race)[2] + Class_Major_Skill_Bonus(standardClass)[2] + Current_Skill_Level(levels,Skill.Blade)
                Blade_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[2])

                Base_Block          = 5 + Race_Starting_Skill_Bonus(race)[3] + Class_Major_Skill_Bonus(standardClass)[3]
                Block               = 5 + Race_Starting_Skill_Bonus(race)[3] + Class_Major_Skill_Bonus(standardClass)[3] + Current_Skill_Level(levels,Skill.Block)
                Block_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[3])

                Base_Blunt          = 5 + Race_Starting_Skill_Bonus(race)[4] + Class_Major_Skill_Bonus(standardClass)[4]
                Blunt               = 5 + Race_Starting_Skill_Bonus(race)[4] + Class_Major_Skill_Bonus(standardClass)[4] + Current_Skill_Level(levels,Skill.Blunt)
                Blunt_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[4])

                Base_Hand_to_Hand   = 5 + Race_Starting_Skill_Bonus(race)[5] + Class_Major_Skill_Bonus(standardClass)[5]
                Hand_to_Hand        = 5 + Race_Starting_Skill_Bonus(race)[5] + Class_Major_Skill_Bonus(standardClass)[5] + Current_Skill_Level(levels,Skill.Hand_to_Hand)
                Hand_to_Hand_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[5])

                Base_Heavy_Armor    = 5 + Race_Starting_Skill_Bonus(race)[6] + Class_Major_Skill_Bonus(standardClass)[6]
                Heavy_Armor         = 5 + Race_Starting_Skill_Bonus(race)[6] + Class_Major_Skill_Bonus(standardClass)[6] + Current_Skill_Level(levels,Skill.Heavy_Armor)
                Heavy_Armor_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[6])

                Base_Alchemy        = 5 + Race_Starting_Skill_Bonus(race)[7] + Class_Major_Skill_Bonus(standardClass)[7]
                Alchemy             = 5 + Race_Starting_Skill_Bonus(race)[7] + Class_Major_Skill_Bonus(standardClass)[7] + Current_Skill_Level(levels,Skill.Alchemy)
                Alchemy_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[7])

                Base_Alteration     = 5 + Race_Starting_Skill_Bonus(race)[8] + Class_Major_Skill_Bonus(standardClass)[8]
                Alteration          = 5 + Race_Starting_Skill_Bonus(race)[8] + Class_Major_Skill_Bonus(standardClass)[8] + Current_Skill_Level(levels,Skill.Alteration)
                Alteration_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[8])

                Base_Conjuration    = 5 + Race_Starting_Skill_Bonus(race)[9] + Class_Major_Skill_Bonus(standardClass)[9]
                Conjuration         = 5 + Race_Starting_Skill_Bonus(race)[9] + Class_Major_Skill_Bonus(standardClass)[9] + Current_Skill_Level(levels,Skill.Conjuration)
                Conjuration_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[9])

                Base_Destruction    = 5 + Race_Starting_Skill_Bonus(race)[10] + Class_Major_Skill_Bonus(standardClass)[10]
                Destruction         = 5 + Race_Starting_Skill_Bonus(race)[10] + Class_Major_Skill_Bonus(standardClass)[10] + Current_Skill_Level(levels,Skill.Destruction)
                Destruction_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[10])

                Base_Illusion       = 5 + Race_Starting_Skill_Bonus(race)[11] + Class_Major_Skill_Bonus(standardClass)[11]
                Illusion            = 5 + Race_Starting_Skill_Bonus(race)[11] + Class_Major_Skill_Bonus(standardClass)[11] + Current_Skill_Level(levels,Skill.Illusion)
                Illusion_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[11])

                Base_Mysticism      = 5 + Race_Starting_Skill_Bonus(race)[12] + Class_Major_Skill_Bonus(standardClass)[12]
                Mysticism           = 5 + Race_Starting_Skill_Bonus(race)[12] + Class_Major_Skill_Bonus(standardClass)[12] + Current_Skill_Level(levels,Skill.Mysticism)
                Mysticism_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[12])

                Base_Restoration    = 5 + Race_Starting_Skill_Bonus(race)[13] + Class_Major_Skill_Bonus(standardClass)[13]
                Restoration         = 5 + Race_Starting_Skill_Bonus(race)[13] + Class_Major_Skill_Bonus(standardClass)[13] + Current_Skill_Level(levels,Skill.Restoration)
                Restoration_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[13])

                Base_Acrobatics     = 5 + Race_Starting_Skill_Bonus(race)[14] + Class_Major_Skill_Bonus(standardClass)[14]
                Acrobatics          = 5 + Race_Starting_Skill_Bonus(race)[14] + Class_Major_Skill_Bonus(standardClass)[14] + Current_Skill_Level(levels,Skill.Acrobatics)
                Acrobatics_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[14])

                Base_Light_Armor    = 5 + Race_Starting_Skill_Bonus(race)[15] + Class_Major_Skill_Bonus(standardClass)[15]
                Light_Armor         = 5 + Race_Starting_Skill_Bonus(race)[15] + Class_Major_Skill_Bonus(standardClass)[15] + Current_Skill_Level(levels,Skill.Light_Armor)
                Light_Armor_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[15])

                Base_Marksman       = 5 + Race_Starting_Skill_Bonus(race)[16] + Class_Major_Skill_Bonus(standardClass)[16]
                Marksman            = 5 + Race_Starting_Skill_Bonus(race)[16] + Class_Major_Skill_Bonus(standardClass)[16] + Current_Skill_Level(levels,Skill.Marksman)
                Marksman_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[16])

                Base_Mercantile     = 5 + Race_Starting_Skill_Bonus(race)[17] + Class_Major_Skill_Bonus(standardClass)[17]
                Mercantile          = 5 + Race_Starting_Skill_Bonus(race)[17] + Class_Major_Skill_Bonus(standardClass)[17] + Current_Skill_Level(levels,Skill.Mercantile)
                Mercantile_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[17])

                Base_Security       = 5 + Race_Starting_Skill_Bonus(race)[18] + Class_Major_Skill_Bonus(standardClass)[18]
                Security            = 5 + Race_Starting_Skill_Bonus(race)[18] + Class_Major_Skill_Bonus(standardClass)[18] + Current_Skill_Level(levels,Skill.Security)
                Security_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[18])

                Base_Sneak          = 5 + Race_Starting_Skill_Bonus(race)[19] + Class_Major_Skill_Bonus(standardClass)[19]
                Sneak               = 5 + Race_Starting_Skill_Bonus(race)[19] + Class_Major_Skill_Bonus(standardClass)[19] + Current_Skill_Level(levels,Skill.Sneak)
                Sneak_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[19])

                Base_Speechcraft    = 5 + Race_Starting_Skill_Bonus(race)[20] + Class_Major_Skill_Bonus(standardClass)[20]
                Speechcraft         = 5 + Race_Starting_Skill_Bonus(race)[20] + Class_Major_Skill_Bonus(standardClass)[20] + Current_Skill_Level(levels,Skill.Speechcraft)
                Speechcraft_Is_Major = positive_to_bool(Class_Major_Skill_Bonus(standardClass)[20])

                Base_Strength       = Race_Starting_Attributes(race,gender)[0] + Birthsign_Attribute_Bonus(birthsign)[0] + Class_Attribute_Bonus(standardClass)[0]
                Strength       = Race_Starting_Attributes(race,gender)[0] + Birthsign_Attribute_Bonus(birthsign)[0] + Class_Attribute_Bonus(standardClass)[0] + Current_Attribute_Level(levels, Attribute.Strength)
                Base_Intelligence   = Race_Starting_Attributes(race,gender)[1] + Birthsign_Attribute_Bonus(birthsign)[1] + Class_Attribute_Bonus(standardClass)[1]
                Intelligence   = Race_Starting_Attributes(race,gender)[1] + Birthsign_Attribute_Bonus(birthsign)[1] + Class_Attribute_Bonus(standardClass)[1] + Current_Attribute_Level(levels, Attribute.Intelligence)
                Base_Willpower      = Race_Starting_Attributes(race,gender)[2] + Birthsign_Attribute_Bonus(birthsign)[2] + Class_Attribute_Bonus(standardClass)[2]
                Willpower      = Race_Starting_Attributes(race,gender)[2] + Birthsign_Attribute_Bonus(birthsign)[2] + Class_Attribute_Bonus(standardClass)[2] + Current_Attribute_Level(levels, Attribute.Willpower)
                Base_Agility        = Race_Starting_Attributes(race,gender)[3] + Birthsign_Attribute_Bonus(birthsign)[3] + Class_Attribute_Bonus(standardClass)[3]
                Agility        = Race_Starting_Attributes(race,gender)[3] + Birthsign_Attribute_Bonus(birthsign)[3] + Class_Attribute_Bonus(standardClass)[3] + Current_Attribute_Level(levels, Attribute.Agility)
                Base_Speed          = Race_Starting_Attributes(race,gender)[4] + Birthsign_Attribute_Bonus(birthsign)[4] + Class_Attribute_Bonus(standardClass)[4]
                Speed          = Race_Starting_Attributes(race,gender)[4] + Birthsign_Attribute_Bonus(birthsign)[4] + Class_Attribute_Bonus(standardClass)[4] + Current_Attribute_Level(levels, Attribute.Speed)
                Base_Endurance      = Race_Starting_Attributes(race,gender)[5] + Birthsign_Attribute_Bonus(birthsign)[5] + Class_Attribute_Bonus(standardClass)[5] 
                Endurance      = Race_Starting_Attributes(race,gender)[5] + Birthsign_Attribute_Bonus(birthsign)[5] + Class_Attribute_Bonus(standardClass)[5] + Current_Attribute_Level(levels, Attribute.Endurance)
                Base_Personality    = Race_Starting_Attributes(race,gender)[6] + Birthsign_Attribute_Bonus(birthsign)[6] + Class_Attribute_Bonus(standardClass)[6]
                Personality    = Race_Starting_Attributes(race,gender)[6] + Birthsign_Attribute_Bonus(birthsign)[6] + Class_Attribute_Bonus(standardClass)[6] + Current_Attribute_Level(levels, Attribute.Personality)
                Base_Luck           = Race_Starting_Attributes(race,gender)[7] + Birthsign_Attribute_Bonus(birthsign)[7] + Class_Attribute_Bonus(standardClass)[7]
                Luck           = Race_Starting_Attributes(race,gender)[7] + Birthsign_Attribute_Bonus(birthsign)[7] + Class_Attribute_Bonus(standardClass)[7] + Current_Attribute_Level(levels, Attribute.Luck)

                OverallLevel        = 0

      
            }

    