namespace FoodApp.View;

public partial class HardHome : ContentPage
{
	public HardHome(HardHomeScreenViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}