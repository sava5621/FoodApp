namespace FoodApp.View;

public partial class MapPage : ContentPage
{
	public MapPage(MapViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		//   testc.Reload();
		testc.Navigating += Testc_Navigating;
    }

	private void Testc_Navigating(object sender, WebNavigatingEventArgs e)
	{
		if (e.NavigationEvent == Microsoft.Maui.WebNavigationEvent.NewPage)
		{
			e.Cancel = true;
		}
	}


}
