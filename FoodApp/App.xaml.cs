using FoodApp.Services;

namespace FoodApp;

public partial class App : Application
{
    private readonly dbServices db;
    private TokenServices tokenServices;
    public App()
	{
        this.tokenServices = new();
        this.db = new();

        InitializeComponent();

        Routing.RegisterRoute(nameof(Registration), typeof(Registration));
        Routing.RegisterRoute(nameof(Login), typeof(Login));
        Routing.RegisterRoute(nameof(CreateAccount), typeof(CreateAccount));
        Routing.RegisterRoute(nameof(AppShell), typeof(AppShell));
        Routing.RegisterRoute(nameof(FoodApp.MainPage), typeof(FoodApp.MainPage));
        Routing.RegisterRoute(nameof(DetailsRestaurant), typeof(DetailsRestaurant));

        MainPage = new Load();

        ChekToken();
    }
    async void ChekToken()
    {
        UserToken token = await db.GetToken();

        token = await db.GetToken();
        if (token is not null && await tokenServices.RefreshAsync(token))
        {
           MainPage = new MainPage();
        }
        else
        {
           MainPage = new AppShell();
        }

    }
}