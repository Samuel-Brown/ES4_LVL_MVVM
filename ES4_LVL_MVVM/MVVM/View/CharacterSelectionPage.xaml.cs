using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM.MVVM.View;

public partial class CharacterSelectionPage : ContentPage
{
	public CharacterSelectionPage(CharacterPageViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }

    public CharacterSelectionPage()
    {
        InitializeComponent();
    }

}