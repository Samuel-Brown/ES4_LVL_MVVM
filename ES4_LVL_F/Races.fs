namespace ES4_LVL_F

open ES4_LVL_F.Genders

type Race = 
   | Altmer     = 0
   | Argonian   = 1
   | Bosmer     = 2
   | Breton     = 3
   | Dunmer     = 4
   | Imperial   = 5
   | Khajiit    = 6
   | Nord       = 7
   | Orc        = 8
   | Redguard   = 9

module Races =

    let List_Races = 
        [| 
        "High Elf"; 
        "Argonian"; 
        "Wood Elf"; 
        "Breton"; 
        "Dark Elf"; 
        "Imperial"; 
        "Khajiit"; 
        "Nord"; 
        "Orc"; 
        "Redguard" 
        |]

    let Race_Starting_Attributes (race: Race, gender: Gender) =
        if gender = Gender.M then
            match race with //        Str Int Wil Agi Spe End Per Luc
            | Race.Altmer       -> [| 30; 50; 40; 40; 30; 40; 40; 50 |]
            | Race.Argonian     -> [| 40; 40; 30; 50; 50; 30; 30; 50 |]
            | Race.Bosmer       -> [| 30; 40; 30; 50; 50; 40; 30; 50 |]
            | Race.Breton       -> [| 40; 50; 50; 30; 30; 30; 40; 50 |]
            | Race.Dunmer       -> [| 40; 40; 30; 40; 50; 40; 30; 50 |]
            | Race.Imperial     -> [| 40; 40; 30; 30; 40; 40; 50; 50 |]
            | Race.Khajiit      -> [| 40; 40; 30; 50; 40; 30; 40; 50 |]
            | Race.Nord         -> [| 50; 30; 30; 40; 40; 50; 30; 50 |]
            | Race.Orc          -> [| 45; 30; 50; 35; 30; 50; 30; 50 |]
            | Race.Redguard     -> [| 50; 30; 30; 40; 40; 50; 30; 50 |]
            | _                 -> [| 40; 40; 40; 40; 40; 40; 40; 50 |]
        else 
            match race with //        Str Int Wil Agi Spe End Per Luc
            | Race.Altmer       -> [| 30; 50; 40; 40; 40; 30; 40; 50 |]
            | Race.Argonian     -> [| 40; 50; 40; 40; 40; 30; 30; 50 |]
            | Race.Bosmer       -> [| 30; 40; 30; 50; 50; 30; 40; 50 |]
            | Race.Breton       -> [| 30; 50; 50; 30; 40; 30; 40; 50 |]
            | Race.Dunmer       -> [| 40; 40; 30; 40; 50; 30; 40; 50 |]
            | Race.Imperial     -> [| 40; 40; 40; 30; 30; 40; 50; 50 |]
            | Race.Khajiit      -> [| 30; 40; 30; 50; 40; 40; 40; 50 |]
            | Race.Nord         -> [| 50; 30; 40; 40; 40; 40; 30; 50 |]
            | Race.Orc          -> [| 45; 40; 45; 35; 30; 50; 25; 50 |]
            | Race.Redguard     -> [| 40; 30; 30; 40; 40; 50; 40; 50 |]
            | _                 -> [| 40; 40; 40; 40; 40; 40; 40; 50 |]


    let Race_Starting_Skill_Bonus race =
        match race with //    ARM ATH BLA BLO BLU H2H HVA ALC ALT CON DES ILU MYS RES ACR LTA MRK MER SEC SNK SPE
        | Race.Altmer           -> [| 0;  0;  0;  0;  0;  0;  0;  5;  10; 5;  10; 5;  10; 0;  0;  0;  0;  0;  0;  0;  0; |]
        | Race.Argonian         -> [| 0;  10; 5;  0;  0;  5;  0;  5;  0;  0;  0;  5;  5;  0;  0;  0;  0;  0;  10; 0;  0; |]
        | Race.Bosmer           -> [| 0;  0;  0;  0;  0;  0;  0;  10; 5;  0;  0;  0;  0;  0;  5;  5;  10; 0;  0;  10; 0; |]
        | Race.Breton           -> [| 0;  0;  0;  0;  0;  0;  0;  5;  5;  10; 0;  5;  10; 10; 0;  0;  0;  0;  0;  0;  0; |]
        | Race.Dunmer           -> [| 0;  5;  10; 0;  5;  0;  0;  0;  0;  0;  10; 0;  5;  0;  0;  5;  5;  0;  0;  0;  0; |]
        | Race.Imperial         -> [| 0;  0;  5;  0;  5;  5;  10; 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  10; 0;  0;  10;|]
        | Race.Khajiit          -> [| 0;  5;  5;  0;  0;  10; 0;  0;  0;  0;  0;  0;  0;  0;  10; 5;  0;  0;  5;  5;  0; |]
        | Race.Nord             -> [| 5;  0;  10; 5;  10; 0;  10; 0;  0;  0;  0;  0;  0;  5;  0;  0;  0;  0;  0;  0;  0; |]
        | Race.Orc              -> [| 10; 0;  0;  10; 10; 5;  10; 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0; |]
        | Race.Redguard         -> [| 0;  10; 10; 0;  10; 0;  5;  0;  0;  0;  0;  0;  0;  0;  0;  5;  0;  5;  0;  0;  0; |]
        | _                     -> [| 0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0;  0; |]

