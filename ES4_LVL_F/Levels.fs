namespace ES4_LVL_F

type Level =
    { 
    Armorer_Increased_By        : int
    Athletics_Increased_By      : int
    Blade_Increased_By          : int
    Block_Increased_By          : int
    Blunt_Increased_By          : int
    Hand_to_Hand_Increased_By   : int
    Heavy_Armor_Increased_By    : int
    Alchemy_Increased_By        : int
    Alteration_Increased_By     : int
    Conjuration_Increased_By    : int
    Destruction_Increased_By    : int
    Illusion_Increased_By       : int
    Mysticism_Increased_By      : int
    Restoration_Increased_By    : int
    Acrobatics_Increased_By     : int
    Light_Armor_Increased_By    : int
    Marksman_Increased_By       : int
    Mercantile_Increased_By     : int
    Security_Increased_By       : int
    Sneak_Increased_By          : int
    Speechcraft_Increased_By    : int

    Strength_Add       : int
    Intelligence_Add   : int
    Willpower_Add      : int
    Agility_Add        : int
    Speed_Add          : int
    Endurance_Add      : int
    Personality_Add    : int
    Luck_Add           : int
    }

module Levels = 
    let Class_Skill_Increases (level) = 
        [| 
        level.Armorer_Increased_By;  
        level.Athletics_Increased_By;  
        level.Blade_Increased_By;  
        level.Block_Increased_By;  
        level.Blunt_Increased_By;  
        level.Hand_to_Hand_Increased_By;  
        level.Heavy_Armor_Increased_By;  
        level.Alchemy_Increased_By;  
        level.Alteration_Increased_By;  
        level.Conjuration_Increased_By;  
        level.Destruction_Increased_By;  
        level.Illusion_Increased_By;  
        level.Mysticism_Increased_By;  
        level.Restoration_Increased_By;  
        level.Acrobatics_Increased_By;  
        level.Light_Armor_Increased_By;  
        level.Marksman_Increased_By;  
        level.Mercantile_Increased_By;  
        level.Security_Increased_By;  
        level.Sneak_Increased_By;  
        level.Speechcraft_Increased_By  
        |]

    let Attribute_Increase(skill1, skill2, skill3) =
        match (skill1 + skill2 + skill3) with
            | 0     -> 1
            | 1     -> 2
            | 2     -> 2
            | 3     -> 2
            | 4     -> 2
            | 5     -> 3
            | 6     -> 3
            | 7     -> 3
            | 8     -> 4
            | 9     -> 4
            | 10    -> 5
            | _     -> 5


    let Strength_Increases      (level : Level) = Attribute_Increase(level.Blade_Increased_By,      level.Blunt_Increased_By,       level.Hand_to_Hand_Increased_By)
    let Endurance_Increases     (level : Level) = Attribute_Increase(level.Armorer_Increased_By,    level.Block_Increased_By,       level.Heavy_Armor_Increased_By)
    let Speed_Increases         (level : Level) = Attribute_Increase(level.Athletics_Increased_By,  level.Acrobatics_Increased_By,  level.Light_Armor_Increased_By)
    let Agility_Increases       (level : Level) = Attribute_Increase(level.Security_Increased_By,   level.Sneak_Increased_By,       level.Marksman_Increased_By)
    let Personality_Increases   (level : Level) = Attribute_Increase(level.Mercantile_Increased_By, level.Speechcraft_Increased_By, level.Illusion_Increased_By)
    let Intelligence_Increases  (level : Level) = Attribute_Increase(level.Alchemy_Increased_By,    level.Conjuration_Increased_By, level.Mysticism_Increased_By)
    let Willpower_Increases     (level : Level) = Attribute_Increase(level.Alteration_Increased_By, level.Destruction_Increased_By, level.Restoration_Increased_By)
    let Luck_Increases          (level : Level) = 1

      
    let New_Level (
        armorer_Increased_By, 
        athletics_Increased_By, 
        blade_Increased_By, 
        block_Increased_By, 
        blunt_Increased_By, 
        hand_to_Hand_Increased_By, 
        heavy_Armor_Increased_By, 
        alchemy_Increased_By, 
        alteration_Increased_By, 
        conjuration_Increased_By, 
        destruction_Increased_By, 
        illusion_Increased_By,
        mysticism_Increased_By,
        restoration_Increased_By,
        acrobatics_Increased_By,
        light_Armor_Increased_By,
        marksman_Increased_By,
        mercantile_Increased_By,
        security_Increased_By,
        sneak_Increased_By,
        speechcraft_Increased_By,
        strength_Chosen,
        intelligence_Chosen,
        willpower_Chosen,
        agility_Chosen,
        speed_Chosen,
        endurance_Chosen,
        personality_Chosen,
        luck_Chosen
        )  = 
        {
            Armorer_Increased_By        = armorer_Increased_By
            Athletics_Increased_By      = athletics_Increased_By
            Blade_Increased_By          = blade_Increased_By
            Block_Increased_By          =  block_Increased_By
            Blunt_Increased_By          = blunt_Increased_By
            Hand_to_Hand_Increased_By   = hand_to_Hand_Increased_By
            Heavy_Armor_Increased_By    =  heavy_Armor_Increased_By
            Alchemy_Increased_By        = alchemy_Increased_By
            Alteration_Increased_By     = alteration_Increased_By
            Conjuration_Increased_By    = conjuration_Increased_By
            Destruction_Increased_By    = destruction_Increased_By
            Illusion_Increased_By       = illusion_Increased_By
            Mysticism_Increased_By      = mysticism_Increased_By
            Restoration_Increased_By    = restoration_Increased_By
            Acrobatics_Increased_By     = acrobatics_Increased_By
            Light_Armor_Increased_By    = light_Armor_Increased_By
            Marksman_Increased_By       = marksman_Increased_By
            Mercantile_Increased_By     = mercantile_Increased_By
            Security_Increased_By       = security_Increased_By
            Sneak_Increased_By          = sneak_Increased_By
            Speechcraft_Increased_By    = speechcraft_Increased_By

            Strength_Add        = strength_Chosen       * Attribute_Increase(blade_Increased_By,        blunt_Increased_By,         hand_to_Hand_Increased_By)
            Intelligence_Add    = intelligence_Chosen   * Attribute_Increase(alchemy_Increased_By,      conjuration_Increased_By,   mysticism_Increased_By)
            Willpower_Add       = willpower_Chosen      * Attribute_Increase(alteration_Increased_By,   destruction_Increased_By,   restoration_Increased_By)
            Agility_Add         = agility_Chosen        * Attribute_Increase(security_Increased_By,     sneak_Increased_By,         marksman_Increased_By)
            Speed_Add           = speed_Chosen          * Attribute_Increase(athletics_Increased_By,    acrobatics_Increased_By,    light_Armor_Increased_By)
            Endurance_Add       = endurance_Chosen      * Attribute_Increase(armorer_Increased_By,      block_Increased_By,         heavy_Armor_Increased_By)
            Personality_Add     = personality_Chosen    * Attribute_Increase(mercantile_Increased_By,   speechcraft_Increased_By,   illusion_Increased_By)
            Luck_Add            = luck_Chosen           * 1

        }