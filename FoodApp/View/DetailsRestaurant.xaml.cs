namespace FoodApp.View;

public partial class DetailsRestaurant : ContentPage
{
	public DetailsRestaurant(DetailsRestaurantViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    

    }
}