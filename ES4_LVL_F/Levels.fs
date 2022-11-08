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
    let List_Levels = 
        [| 
        "Male"; 
        "Female"
        |]