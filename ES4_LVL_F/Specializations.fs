namespace ES4_LVL_F

type Specialization = 
    | Combat    = 0
    | Magic     = 1
    | Stealth   = 2

module Specializations =
    let List_Specializations = 
        [| 
        "Combat"; 
        "Magic"; 
        "Stealth"
        |]