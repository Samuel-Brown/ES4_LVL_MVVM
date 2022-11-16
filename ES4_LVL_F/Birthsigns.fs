namespace ES4_LVL_F

type Birthsign = 
    | Apprentice    = 0
    | Atronach      = 1
    | Lady          = 2
    | Lord          = 3
    | Lover         = 4
    | Mage          = 5
    | Ritual        = 6
    | Serpent       = 7
    | Shadow        = 8
    | Steed         = 9
    | Thief         = 10
    | Tower         = 12
    | Warrior       = 13


module Birthsigns =
    let List_Birthsigns = 
        [| 
        "Apprentice"; 
        "Atronach"; 
        "Lady"; 
        "Lord"; 
        "Lover"; 
        "Mage"; 
        "Ritual"; 
        "Serpent"; 
        "Shadow"; 
        "Steed"; 
        "Thief"; 
        "Tower"; 
        "Warrior"
        |]




    let Birthsign_Attribute_Bonus birthsign =
        match birthsign with //             Str     Int     Wil     Agi     Spe     End     Per     Luc
        | Birthsign.Apprentice      -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Atronach        -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Lady            -> [|   0;      0;      10;     0;      0;      10;     0;      0   |]
        | Birthsign.Lord            -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Lover           -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Mage            -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Ritual          -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Serpent         -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Shadow          -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Steed           -> [|   0;      0;      0;      0;      20;     0;      0;      0   |]
        | Birthsign.Thief           -> [|   0;      0;      0;      10;     10;     0;      0;      10  |]
        | Birthsign.Tower           -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]
        | Birthsign.Warrior         -> [|   10;     0;      0;      0;      0;      10;     0;      0   |]
        | _                         -> [|   0;      0;      0;      0;      0;      0;      0;      0   |]