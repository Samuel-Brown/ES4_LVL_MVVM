using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM.MVVM.View;

public partial class CharacterPage : ContentPage
{
	public CharacterPage(CharacterPageViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }

    private void TabbedPage_Appearing(object sender, EventArgs e)
    {

    }
}