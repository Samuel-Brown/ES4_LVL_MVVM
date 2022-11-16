//using AndroidX.Lifecycle;
using ES4_LVL_MVVM.MVVM.ViewModels;

namespace ES4_LVL_MVVM.MVVM.View;

public partial class AttributesPage : ContentPage
{
	public AttributesPage(AttributesPageViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }

    public AttributesPage()
    {
        InitializeComponent();
    }

}