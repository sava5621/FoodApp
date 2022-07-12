namespace FoodApp.View;

public partial class Account : ContentPage
{
	public Account(AccountViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}