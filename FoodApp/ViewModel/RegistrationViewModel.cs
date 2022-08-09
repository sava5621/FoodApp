using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public partial class RegistrationViewModel : BaseViewModel
    {

        [RelayCommand]
        async Task Clear()
        {
            dbServices db = new dbServices();
            await db.RemoveToken();
        }
        [RelayCommand]
        async Task GoToCreate() 
        {
            await Shell.Current.GoToAsync(nameof(CreateAccount), true);
        }
        [RelayCommand]
        async Task GoToLogin()
        {
            await Shell.Current.GoToAsync(nameof(Login), true);
        }
    }
}
