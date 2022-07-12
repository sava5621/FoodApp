namespace FoodApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Inter-SemiBold.otf", "SemiBold");
                fonts.AddFont("Inter-Medium.otf", "Medium");
                fonts.AddFont("Inter-Regular.otf", "Regular");
                fonts.AddFont("Inter-Bold.otf", "Bold");
            });
        builder.Services.AddSingleton<FoodServices>();

        builder.Services.AddSingleton<HomeScreen>();
        builder.Services.AddSingleton<HomeScreenViewModel>();

        builder.Services.AddSingleton<Booking>();
        builder.Services.AddSingleton<BookingScreenViewModel>();

        builder.Services.AddSingleton<Account>();
        builder.Services.AddSingleton<AccountViewModel>();

        builder.Services.AddSingleton<DetailsRestaurant>();
        builder.Services.AddSingleton<DetailsRestaurantViewModel>();

        return builder.Build();
    }
}
