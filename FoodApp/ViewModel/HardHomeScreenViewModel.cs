using FoodApp.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public partial class HardHomeScreenViewModel : BaseViewModel
    {
        public HardHomeScreenViewModel(FoodServices foodServices)
        {
            homes.Add(new HomeModel() { carousel_advertisement= FoodServices.carousel_advertisement,
                                        carousel_offers = FoodServices.carousel_offers,
                                        сollectionViewRestorsan= FoodServices.сollectionViewRestorsan});
        }
        [ObservableProperty]
        string location = "Agrabad 435, Chittagong";
        [ObservableProperty]
        string icon_user = "test_icon_user.png";
        public ObservableCollection<HomeModel> homes { get; } = new();
        [RelayCommand]
        async Task GoToMap(CollectionViewRestorsan item)
        {
            await Shell.Current.GoToAsync(nameof(MapPage), true, new Dictionary<string, object>
            {
                {"Restoran", item }
            });
        }
    }
}
