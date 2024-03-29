﻿

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace FoodApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder


            .UseMauiApp<App>()
            .UseMauiCompatibility()
            .ConfigureMauiHandlers(handlers =>
            {
#if __ANDROID__
                handlers.AddCompatibilityRenderer(typeof(WebView), typeof(Platforms.Android.GeoWebViewRenderer));
#endif
                //  handlers.AddCompatibilityRenderer(typeof(WebViewer), typeof(FoodApp.Platforms.Android.CastomRender.WebViewRender));
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Inter-SemiBold.otf", "SemiBold");
                fonts.AddFont("Inter-Medium.otf", "Medium");
                fonts.AddFont("Inter-Regular.otf", "Regular");
                fonts.AddFont("Inter-Bold.otf", "Bold");
            });

        builder.Services.AddSingleton<TokenServices>();
        builder.Services.AddSingleton<FoodServices>();
        builder.Services.AddSingleton<dbServices>();

        builder.Services.AddSingleton<HomeScreen>();
        builder.Services.AddSingleton<HomeScreenViewModel>();

        builder.Services.AddSingleton<Booking>();
        builder.Services.AddSingleton<BookingScreenViewModel>();

        builder.Services.AddSingleton<Account>();
        builder.Services.AddSingleton<AccountViewModel>();

        builder.Services.AddSingleton<DetailsRestaurant>();
        builder.Services.AddSingleton<DetailsRestaurantViewModel>();

        builder.Services.AddSingleton<HardHome>();
        builder.Services.AddSingleton<HardHomeScreenViewModel>();

        builder.Services.AddSingleton<MapPage>();
        builder.Services.AddSingleton<MapViewModel>();

        builder.Services.AddSingleton<Registration>();
        builder.Services.AddSingleton<RegistrationViewModel>();

        builder.Services.AddSingleton<Login>();
        builder.Services.AddSingleton<LoginViewModel>();

        builder.Services.AddSingleton<CreateAccount>();
        builder.Services.AddSingleton<CreateAccountViewModel>();

        return builder.Build();
    }

}
