using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM.MVVM.View;

public partial class LevelUpPage : ContentPage
{
	public LevelUpPage(LevelUpPageViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }

    public LevelUpPage()
    {
        InitializeComponent();
    }
}