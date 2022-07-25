namespace FoodApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(DetailsRestaurant), typeof(DetailsRestaurant));
        Routing.RegisterRoute(nameof(MapPage), typeof(MapPage));
    }

}
