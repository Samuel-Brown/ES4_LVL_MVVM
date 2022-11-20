using ES4_LVL_MVVM.MVVM.Model;

namespace ES4_LVL_MVVM.Contracts.Services
{
    public interface INavigationService
    {
        Task NavigateBack();
        Task NavigateToNewCharacterPage();
        Task NavigateToCharacterPage();
        Task NavigateToAttributesPage();
        Task NavigateToSkillsPage();
        Task NavigateToLevelUpPage();
        Task NavigateToShellPage();
        Task NavigateToCharacterPage(Character myCharacter);
        Task NavigateToLevelUpPage(Character myCharacter);
        Task NavigateToCharacterSelectionPage();
    }
}
