using FoodApp.Model.View;

namespace FoodApp.ViewModel
{
    public partial class HomeScreenViewModel : BaseViewModel
    {
        public HomeScreenViewModel(FoodServices foodServices)
        {
        }
        //TODO: Переход на карту
        //TODO: Анимация ImageButton
        [ObservableProperty]
        string location = "Agrabad 435, Chittagong";
        [ObservableProperty]
        string icon_user = "test_icon_user.png";
        public ObservableCollection<Carousel_advertisement> carousel_advertisement { get; } = FoodServices.carousel_advertisement;
        public ObservableCollection<Carousel_offers> carousel_offers { get; } = FoodServices.carousel_offers;
        public ObservableCollection<CollectionViewRestorsan> сollectionViewRestorsan { get; } = FoodServices.сollectionViewRestorsan;             
    }
}
