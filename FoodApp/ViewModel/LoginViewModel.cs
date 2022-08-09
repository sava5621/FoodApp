namespace FoodApp.ViewModel
{
    public partial class LoginViewModel : BaseViewModel
    {
        TokenServices tokenServices;
        public LoginViewModel(TokenServices tokenServices)
        {
            this.tokenServices = tokenServices;
        }
        [ObservableProperty]
        string email = string.Empty;

        [ObservableProperty]
        string pass = string.Empty;
        [RelayCommand]
        async Task LoginUser()
        {
           if (await tokenServices.LoginAsync(email, pass))
           {
                App.Current.MainPage = new MainPage();
           }
           else await App.Current.MainPage.DisplayAlert("Login", "Invalid password", "Ok");
        }
    }
}
