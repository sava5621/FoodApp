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
            });

		return builder.Build();
	}
}
