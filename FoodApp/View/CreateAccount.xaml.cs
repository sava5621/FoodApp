namespace FoodApp.View;

public partial class CreateAccount : ContentPage
{
	public CreateAccount(CreateAccountViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}