namespace ES4_LVL_F

type Class = 
    | Acrobat       = 0
    | Agent         = 1
    | Archer        = 2
    | Assassin      = 3
    | Barbarian     = 4
    | Bard          = 5
    | Battlemage    = 6
    | Crusader      = 7
    | Healer        = 8
    | Knight        = 9
    | Mage          = 10
    | Monk          = 11
    | Nightblade    = 12
    | Pilgrim       = 13
    | Rogue         = 14
    | Scout         = 15
    | Sorcerer      = 16
    | Spellsword    = 17
    | Thief         = 18
    | Warrior       = 19
    | Witchhunter   = 20
    | Custom        = 99

module Classes =
    let List_Classes = 
        [| 
        "Acrobat"; 
        "Agent"; 
        "Archer"; 
        "Assassin"; 
        "Barbarian"; 
        "Bard"; 
        "Battlemage"; 
        "Crusader"; 
        "Healer"; 
        "Knight"; 
        "Mage"; 
        "Monk";  
        "Nightblade";  
        "Pilgrim";  
        "Rogue";  
        "Scout";  
        "Sorcerer";  
        "Spellsword";  
        "Thief";  
        "Warrior";  
        "Witchhunter";
        "Custom"
        |]



    let Class_Attribute_Bonus standardClass =
        match standardClass with //             Str     Int     Wil     Agi     Spe     End     Per     Luc
        | Class.Acrobat         ->       [|   0;      0;      0;      5;      0;      5;      0;      0   |]
        | Class.Agent           ->       [|   0;      0;      0;      5;      0;      0;      5;      0   |]
        | Class.Archer          ->       [|   5;      0;      0;      5;      0;      0;      0;      0   |]
        | Class.Assassin        ->       [|   0;      5;      0;      0;      5;      0;      0;      0   |]
        | Class.Barbarian       ->       [|   5;      0;      0;      0;      5;      0;      0;      0   |]
        | Class.Bard            ->       [|   0;      5;      0;      0;      0;      0;      5;      0   |]
        | Class.Battlemage      ->       [|   5;      5;      0;      0;      0;      0;      0;      0   |]
        | Class.Crusader        ->       [|   5;      0;      5;      0;      0;      0;      0;      0   |]
        | Class.Healer          ->       [|   0;      0;      5;      0;      0;      0;      5;      0   |]
        | Class.Knight          ->       [|   5;      0;      0;      0;      0;      0;      5;      0   |]
        | Class.Mage            ->       [|   0;      5;      5;      0;      0;      0;      0;      0   |]
        | Class.Monk            ->       [|   0;      0;      5;      5;      0;      0;      0;      0   |]
        | Class.Nightblade      ->       [|   0;      0;      5;      0;      5;      0;      0;      0   |]
        | Class.Pilgrim         ->       [|   0;      0;      0;      0;      0;      5;      5;      0   |]
        | Class.Rogue           ->       [|   0;      0;      0;      0;      5;      0;      5;      0   |]
        | Class.Scout           ->       [|   0;      0;      0;      0;      5;      5;      0;      0   |]
        | Class.Sorcerer        ->       [|   0;      5;      0;      0;      0;      5;      0;      0   |]
        | Class.Spellsword      ->       [|   0;      0;      5;      0;      0;      5;      0;      0   |]
        | Class.Thief           ->       [|   0;      0;      0;      5;      5;      0;      0;      0   |]
        | Class.Warrior         ->       [|   5;      0;      0;      0;      0;      5;      0;      0   |]
        | Class.Witchhunter     ->       [|   0;      5;      0;      5;      0;      0;      0;      0   |]
        | Class.Custom          ->       [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | _                     ->       [|   0;      0;      0;      0;      0;      0;      0;      0   |]

    let Class_Major_Skill_Bonus standardClass =
        match standardClass with     //     ARM ATH BLA BLO BLU H2H HVA ALC ALT CON DES ILU MYS RES ACR LTA MRK MER SEC SNK SPE
        | Class.Acrobat         ->       [| 0;  0;  20; 20; 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  20; 0;  20; 0;  20; 20; 20;|]
        | Class.Agent           ->       [| 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  20; 0;  0;  20; 0;  20; 20; 20; 20; 20;|]
        | Class.Archer          ->       [| 20; 0;  20; 0;  20; 20; 0;  0;  0;  0;  0;  0;  0;  0;  0;  20; 20; 0;  0;  20; 0; |]
        | Class.Assassin        ->       [| 0;  0;  20; 0;  0;  0;  0;  20; 0;  0;  0;  0;  0;  0;  20; 20; 20; 0;  20; 20; 0; |]
        | Class.Barbarian       ->       [| 20; 20; 20; 20; 20; 20; 0;  0;  0;  0;  0;  0;  0;  0;  0;  20; 0;  0;  0;  0;  0; |]
        | Class.Bard            ->       [| 0;  0;  20; 20; 0;  0;  0;  20; 0;  0;  0;  20; 0;  0;  0;  20; 0;  20; 0;  0;  20;|]
        | Class.Battlemage      ->       [| 0;  0;  20; 0;  20; 0;  0;  20; 20; 20; 20; 0;  20; 0;  0;  0;  0;  0;  0;  0;  0; |]
        | Class.Crusader        ->       [| 0;  20; 20;  0; 20; 20; 20; 0;  0;  0;  20; 0;  0;  20; 0;  0;  0;  0;  0;  0;  0; |]
        | Class.Healer          ->       [| 0;  0;  0;  0;  0;  0;  0;  20; 20; 0;  20; 20; 0;  20; 0;  0;  0;  20; 0;  0;  20;|]
        | Class.Knight          ->       [| 0;  0;  20; 20; 20; 20; 20; 0;  0;  0;  0;  20; 0;  0;  0;  0;  0;  0;  0;  0;  20;|]
        | Class.Mage            ->       [| 0;  0;  0;  0;  0;  0;  0;  20; 20; 20; 20; 20; 20; 20; 0;  0;  0;  0;  0;  0;  0; |]
        | Class.Monk            ->       [| 0;  20; 0;  0;  0;  20; 0;  0;  20; 0;  0;  0;  0;  0;  20; 0;  20; 0;  20; 20; 0; |]
        | Class.Nightblade      ->       [| 0;  20; 20; 0;  0;  0;  0;  0;  20; 0;  20; 0;  0;  20; 20; 20; 0;  0;  0;  0;  0; |]
        | Class.Pilgrim         ->       [| 20; 0;  0;  20; 20; 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  20; 0;  20; 20; 0;  20;|]
        | Class.Rogue           ->       [| 0;  20; 20; 20; 0;  0;  0;  20; 0;  0;  0;  20; 0;  0;  0;  20; 0;  20; 0;  0;  0; |]
        | Class.Scout           ->       [| 20; 20; 20; 20; 0;  0;  0;  20; 0;  0;  0;  0;  0;  0;  20; 20; 0;  0;  0;  0;  0; |]
        | Class.Sorcerer        ->       [| 0;  0;  0;  0;  0;  0;  20; 20; 20; 20; 20; 0;  20; 20; 0;  0;  0;  0;  0;  0;  0; |]
        | Class.Spellsword      ->       [| 0;  0;  20; 20; 0;  0;  20; 0;  20; 0;  20; 20; 0;  20; 0;  0;  0;  0;  0;  0;  0; |]
        | Class.Thief           ->       [| 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  20; 20; 20; 20; 20; 20; 20;|]
        | Class.Warrior         ->       [| 20; 20; 20; 20; 20; 20; 20; 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0; |]
        | Class.Witchhunter     ->       [| 0;  20; 0;  0;  0;  0;  0;  20; 0;  20; 20; 0;  20; 0;  0;  0;  20; 0;  20; 0;  0; |]
        | Class.Custom          ->       [| 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0; |]
        | _                     ->       [| 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0; |]

