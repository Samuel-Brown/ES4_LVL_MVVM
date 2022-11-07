namespace ES4_LVL_MVVM.Contracts.Services
{
    public interface INavigationService
    {
        Task NavigateBack();
        Task NavigateToMainPage();
        Task NavigateToNewCharacterPage();
    }
}
