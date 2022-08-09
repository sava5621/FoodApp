namespace FoodApp.View;

public partial class Registration : ContentPage
{
	public Registration(RegistrationViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
	}
}