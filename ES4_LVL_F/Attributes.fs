namespace ES4_LVL_F

type Attribute = 
    | Strength      = 10
    | Endurance     = 20
    | Speed         = 30
    | Agility       = 40
    | Personality   = 50
    | Intelligence  = 60
    | Willpower     = 70
    | Luck          = 99

module Attributes =
    let List_Attributes = 
        [| 
        "Strength"; 
        "Endurance"; 
        "Speed"; 
        "Agility"; 
        "Personality"; 
        "Intelligence"; 
        "Willpower"; 
        "Luck"
        |]