namespace FoodApp.View;

public partial class Booking : ContentPage
{
	public Booking(BookingScreenViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}