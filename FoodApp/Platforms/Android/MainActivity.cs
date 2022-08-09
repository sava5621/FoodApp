using Android.App;
using Android.Content.PM;
using Android.OS;

namespace FoodApp;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true , ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Android.OS.Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        SetColors();
    }

    private void SetColors()
    {
        if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Lollipop)
        {
            
            // Aqua.
            var color = Android.Graphics.Color.Black;
            // The thin bar at top of Android screen.
            Window.SetStatusBarColor(color);
            // The thicker bar at bottom of Android screen.
            Window.SetNavigationBarColor(color);
            
           
        }
    }
}
