using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public partial class AccountViewModel : BaseViewModel
    {
        [ObservableProperty]
        string name = "Sadek Hossen";
        [ObservableProperty]
        string email = "sadekbranding@gmail.com";
        [ObservableProperty]
        string image = "test_icon_user.png";
        [ObservableProperty]
        bool notify_is_visible = true;
        [ObservableProperty]
        int notify_count = 5;
    }
}
