using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM.MVVM.View;

public partial class NewCharacterPage : ContentPage
{
	public NewCharacterPage(NewCharacterPageViewModel viewModel)
	{
        BindingContext = viewModel;
        InitializeComponent();
	}

	public NewCharacterPage()
	{
        InitializeComponent();
    }

}