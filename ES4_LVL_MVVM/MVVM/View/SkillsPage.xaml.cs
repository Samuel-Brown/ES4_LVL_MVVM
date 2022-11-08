using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM.MVVM.View;

public partial class SkillsPage : ContentPage
{
	public SkillsPage(SkillsPageViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}