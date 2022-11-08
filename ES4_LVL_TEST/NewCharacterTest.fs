module NewCharacterTests

open System
open Xunit
open ES4_LVL_F
open ES4_LVL_F.Characters
open System.Diagnostics
open ES4_LVL_F.Levels

//[<Fact>]
//let ``Character Gender Differences`` () =
//    let TestCharacterM = New_Character ("Male", Race.Imperial, Gender.M, Specialization.Combat, Birthsign.Serpent, Class.Acrobat, 0);
//    let TestCharacterF = New_Character ("Female", Race.Imperial, Gender.F, Specialization.Combat, Birthsign.Serpent, Class.Acrobat, 0);

//    Debug.WriteLine(TestCharacterM)
//    Debug.WriteLine(TestCharacterF)

//    //Assert.True(TestCharacterM.Race.Equals(Race.Dunmer))
//    Assert.Equal    (TestCharacterM.Base_Strength,      TestCharacterF.Base_Strength)
//    Assert.Equal    (TestCharacterM.Base_Endurance,     TestCharacterF.Base_Endurance)
//    Assert.NotEqual (TestCharacterM.Base_Speed,         TestCharacterF.Base_Speed)
//    Assert.Equal    (TestCharacterM.Base_Agility,       TestCharacterF.Base_Agility)
//    Assert.Equal    (TestCharacterM.Base_Personality,   TestCharacterF.Base_Personality)
//    Assert.Equal    (TestCharacterM.Base_Intelligence,  TestCharacterF.Base_Intelligence)
//    Assert.NotEqual (TestCharacterM.Base_Willpower,     TestCharacterF.Base_Willpower)
//    Assert.Equal    (TestCharacterM.Base_Luck,          TestCharacterF.Base_Luck)








[<Fact>]
let ``New Character Test`` () =
    let TestLevel1 = New_Level (0,5,4,0,4,0,0,10,0,1,4,0,1,0,5,0,0,0,3,0,0,1,1,0,1,0,0,0,0)
    let TestLevel2 = New_Level (0,5,4,0,4,0,0,10,0,1,4,0,1,0,5,0,0,0,3,0,0,1,1,0,1,0,0,0,0)
    let TestLevel3 = New_Level (0,5,4,0,4,0,0,10,0,1,4,0,1,0,5,0,0,0,3,0,0,1,1,0,1,0,0,0,0)
    let TestLevel4 = New_Level (0,5,4,0,4,0,0,10,0,1,4,0,1,0,5,0,0,0,3,0,0,1,1,0,1,0,0,0,0)
    let TestLevel5 = New_Level (0,5,4,0,4,0,0,10,0,1,4,0,1,0,5,0,0,0,3,0,0,1,1,0,1,0,0,0,0)
    let TestLevels = [| TestLevel1; TestLevel2; TestLevel3; TestLevel4; TestLevel5 |]
    let TestCharacterM = New_Character ("Test", Race.Dunmer, Gender.M, Specialization.Combat, Birthsign.Thief,Class.Acrobat, TestLevels);
    let TestCharacterF = New_Character ("Test", Race.Dunmer, Gender.F, Specialization.Combat, Birthsign.Thief,Class.Acrobat, TestLevels);

    Debug.WriteLine(TestCharacterM)
    Debug.WriteLine(TestCharacterF)

    //Assert.True(TestCharacterM.Race.Equals(Race.Dunmer))
    Assert.Equal(TestCharacterM.Base_Strength, TestCharacterF.Base_Strength)
    Assert.Equal(TestCharacterM.Base_Endurance, TestCharacterF.Base_Endurance)
    Assert.Equal(TestCharacterM.Base_Speed, TestCharacterF.Base_Speed)
    Assert.Equal(TestCharacterM.Base_Agility, TestCharacterF.Base_Agility)
    Assert.Equal(TestCharacterM.Base_Personality, TestCharacterF.Base_Personality)
    Assert.NotEqual(TestCharacterM.Base_Intelligence, TestCharacterF.Base_Intelligence)
    Assert.NotEqual(TestCharacterM.Base_Willpower, TestCharacterF.Base_Willpower)
    Assert.Equal(TestCharacterM.Base_Luck, TestCharacterF.Base_Luck)

