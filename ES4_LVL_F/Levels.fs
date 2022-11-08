namespace ES4_LVL_F

type Level =
    { 
    Armorer        : int
    Athletics      : int
    Blade          : int
    Block          : int
    Blunt          : int
    Hand_to_Hand   : int
    Heavy_Armor    : int
    Alchemy        : int
    Alteration     : int
    Conjuration    : int
    Destruction    : int
    Illusion       : int
    Mysticism      : int
    Restoration    : int
    Acrobatics     : int
    Light_Armor    : int
    Marksman       : int
    Mercantile     : int
    Security       : int
    Sneak          : int
    Speechcraft    : int

    Strength       : int
    Intelligence   : int
    Willpower      : int
    Agility        : int
    Speed          : int
    Endurance      : int
    Personality    : int
    Luck           : int

    }

module Levels =
    let List_Skills = 
        [| 
        "Blade"; 
        "Blunt"; 
        "Hand to Hand"; 
        "Armorer"; 
        "Block"; 
        "Heavy Armor"; 
        "Athletics"; 
        "Acrobatics"; 
        "Light Armor"; 
        "Security"; 
        "Sneak"; 
        "Marksman";  
        "Mercantile";  
        "Speechcraft";  
        "Illusion";  
        "Alchemy";  
        "Conjuration";  
        "Mysticism";  
        "Alteration";  
        "Destruction";  
        "Restoration"
        |]