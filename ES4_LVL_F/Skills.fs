namespace ES4_LVL_F

type Skill = 
    | Blade             = 11
    | Blunt             = 12
    | Hand_to_Hand      = 13
    | Armorer           = 21
    | Block             = 22
    | Heavy_Armor       = 23
    | Athletics         = 31
    | Acrobatics        = 32
    | Light_Armor       = 33
    | Security          = 41
    | Sneak             = 42
    | Marksman          = 43
    | Mercantile        = 51
    | Speechcraft       = 52
    | Illusion          = 53
    | Alchemy           = 61
    | Conjuration       = 62
    | Mysticism         = 63
    | Alteration        = 71
    | Destruction       = 72
    | Restoration       = 73

module Skills =
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