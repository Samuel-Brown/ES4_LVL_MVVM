using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM.MVVM.View;

public partial class ShellPage : Shell
{
	public ShellPage(CharacterPageViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }

}