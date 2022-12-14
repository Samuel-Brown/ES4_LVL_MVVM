using ES4_LVL_MVVM.MVVM.Model;
using ES4_LVL_MVVM.Contracts.Services;
using ES4_LVL_MVVM.MVVM.View;
using ES4_LVL_MVVM.MVVM.ViewModels;
using System.Diagnostics;

namespace ES4_LVL_MVVM.Services
{
    public class NavigationService : INavigationService
    {
        readonly IServiceProvider _services;


        protected INavigation Navigation
        {
            get
            {
                INavigation navigation = Application.Current?.MainPage?.Navigation;
                if (navigation is not null)
                    return navigation;
                else
                {
                    //This is not good!
                    if (Debugger.IsAttached)
                        Debugger.Break();
                    throw new Exception();
                }
            }
        }

        public NavigationService(IServiceProvider services)
            => _services = services;


        //-----------------------------------------------------NavigateTo Commands------------------

        public Task NavigateToMainPage()
            => NavigateToPage<MainPage>();

        public Task NavigateToNewCharacterPage()
            => NavigateToPage<NewCharacterPage>();

        public Task NavigateToCharacterPage()
            => NavigateToPage<CharacterPage>();
        public Task NavigateToCharacterPage(Character character)
            => NavigateToPage<CharacterPage>(character);

        public Task NavigateToAttributesPage()
            => NavigateToPage<AttributesPage>();

        public Task NavigateToSkillsPage()
            => NavigateToPage<SkillsPage>();

        public Task NavigateToLevelUpPage()
            => NavigateToPage<LevelUpPage>();

        public Task NavigateToLevelUpPage(Character character)
            => NavigateToPage<LevelUpPage>(character);

        public Task NavigateToShellPage()
            => NavigateToPage<ShellPage>();

        public Task NavigateToCharacterSelectionPage()
            => NavigateToPage<CharacterSelectionPage>();






        public Task NavigateBack()
        {
            if (Navigation.NavigationStack.Count > 1)
                return Navigation.PopAsync();

            throw new InvalidOperationException("No pages to navigate back to!");
        }

        private async Task NavigateToPage<T>(object parameter = null) where T : Page
        {
            var toPage = ResolvePage<T>();

            if (toPage is not null)
            {
                //Subscribe to the toPage's NavigatedTo event
                toPage.NavigatedTo += Page_NavigatedTo;

                //Get VM of the toPage
                var toViewModel = GetPageViewModelBase(toPage);

                //Call navigatingTo on VM, passing in the paramter
                if (toViewModel is not null)
                    await toViewModel.OnNavigatingTo(parameter);

                //Navigate to requested page
                await Navigation.PushAsync(toPage, true);

                //Subscribe to the toPage's NavigatedFrom event
                toPage.NavigatedFrom += Page_NavigatedFrom;
            }
            else
                throw new InvalidOperationException($"Unable to resolve type {typeof(T).FullName}");
        }


        private async Task NavigateToPage<T>(Character parameter) where T : Page
        {
            var toPage = ResolvePage<T>();

            if (toPage is not null)
            {
                //Subscribe to the toPage's NavigatedTo event
                toPage.NavigatedTo += Page_NavigatedTo;

                //Get VM of the toPage
                var toViewModel = GetPageViewModelBase(toPage);

                //Call navigatingTo on VM, passing in the paramter
                if (toViewModel is not null)
                    await toViewModel.OnNavigatingTo(parameter);

                //Navigate to requested page
                await Navigation.PushAsync(toPage, true);

                //Subscribe to the toPage's NavigatedFrom event
                toPage.NavigatedFrom += Page_NavigatedFrom;
            }
            else
                throw new InvalidOperationException($"Unable to resolve type {typeof(T).FullName}");
        }







        private async void Page_NavigatedFrom(object sender, NavigatedFromEventArgs e)
        {
            //To determine forward navigation, we look at the 2nd to last item on the NavigationStack
            //If that entry equals the sender, it means we navigated forward from the sender to another page
            bool isForwardNavigation = Navigation.NavigationStack.Count > 1 
                && Navigation.NavigationStack[^2] == sender;

            if (sender is Page thisPage)
            {
                if (!isForwardNavigation)
                {
                    thisPage.NavigatedTo -= Page_NavigatedTo;
                    thisPage.NavigatedFrom -= Page_NavigatedFrom;
                }

                await CallNavigatedFrom(thisPage, isForwardNavigation);
            }
        }

        private Task CallNavigatedFrom(Page p, bool isForward)
        {
            var fromViewModel = GetPageViewModelBase(p);

            if (fromViewModel is not null)
                return fromViewModel.OnNavigatedFrom(isForward);
            return Task.CompletedTask;
        }

        private async void Page_NavigatedTo(object sender, NavigatedToEventArgs e)
            => await CallNavigatedTo(sender as Page);

        private Task CallNavigatedTo(Page p)
        {
            var fromViewModel = GetPageViewModelBase(p);

            if (fromViewModel is not null)
                return fromViewModel.OnNavigatedTo();
            return Task.CompletedTask;
        }

        private ViewModelBase GetPageViewModelBase(Page p)
            => p?.BindingContext as ViewModelBase;

        private T ResolvePage<T>() where T : Page
            => _services.GetService<T>();

    }
}
