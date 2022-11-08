namespace ES4_LVL_MVVM.Contracts.Services
{
    public interface INavigationService
    {
        Task NavigateBack();
        Task NavigateToMainPage();
        Task NavigateToNewCharacterPage();
        Task NavigateToCharacterPage();
        Task NavigateToAttributesPage();
        Task NavigateToSkillsPage();
        Task NavigateToLevelUpPage();
        Task NavigateToShellPage();
    }
}
