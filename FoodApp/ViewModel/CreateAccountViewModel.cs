using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public partial class CreateAccountViewModel : BaseViewModel
    {
        TokenServices tokenServices;
        public CreateAccountViewModel(TokenServices tokenServices)
        {
            this.tokenServices = tokenServices;
        }
        [ObservableProperty]
        string name = string.Empty;

        [ObservableProperty]
        string email = string.Empty;

        [ObservableProperty]
        string pass = string.Empty;
        [RelayCommand]
        async Task CreateAccountUser()
        {
            if (await tokenServices.Registr(Name, Email, Pass))
            {
                App.Current.MainPage = new MainPage();
            }
            else await App.Current.MainPage.DisplayAlert("Create Accoun", "Invalid password", "Ok");
        }
    }
}
