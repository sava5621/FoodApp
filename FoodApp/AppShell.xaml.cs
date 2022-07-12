namespace FoodApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        FoodServices.GetBookingData();
        Routing.RegisterRoute(nameof(DetailsRestaurant), typeof(DetailsRestaurant));
    }
}
