using ES4_LVL_MVVM.Contracts.Services;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public class NewCharacterPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        public string txt;

        public NewCharacterPageViewModel(INavigationService navigationService)
        {
            //_dataService = dataService;
            _navigationService = navigationService;
        }

    }
}
