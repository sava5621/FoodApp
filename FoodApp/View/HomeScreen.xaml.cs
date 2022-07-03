namespace FoodApp.View;

public partial class HomeScreen : ContentPage
{
	public HomeScreen(HomeScreenViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {

    }
}