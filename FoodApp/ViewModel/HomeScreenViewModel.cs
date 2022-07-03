
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public partial class HomeScreenViewModel : BaseViewModel
    {
        [ObservableProperty]
        string location = "Agrabad 435, Chittagong";
        [ObservableProperty]
        string icon_user = "test_icon_user.png";
        public ObservableCollection<Carousel_advertisement> carousel_advertisement { get; } = new() { new Carousel_advertisement("test_carusel_icon.svg",
                                                                                       "Flash Offer",
                                                                                       "We are here with the best\ndeserts intown.",
                                                                                       "test_Indicator_view.png",
                                                                                       "#FF9F06",
                                                                                       "#FFE1B4"),
                                                                                       new Carousel_advertisement("test_carusel_icon.svg",
                                                                                       "Flash Offer",
                                                                                       "We are here with the best\ndeserts intown.",
                                                                                       "test_Indicator_view.png",
                                                                                       "#00D756",
                                                                                       "#018AC5")};
        public ObservableCollection<Carousel_offers> carousel_offers { get; } = new() { new Carousel_offers("Chicken Biryani",
                                                                                                            "Ambrosia Hotel &\nRestaurant",
                                                                                                            "test_car1.png"),
                                                                                        new Carousel_offers("Sauce Tonkatsu ",
                                                                                                            "Handi Restaurant,\nChittagong",
                                                                                                            "test_car2.png"),
                                                                                        new Carousel_offers("Chicken Biryani",
                                                                                                            "Ambrosia Hotel &\nRestaurant",
                                                                                                            "test_car1.png")};
        public ObservableCollection<CollectionViewRestorsan> сollectionViewRestorsan { get; } = new() { new CollectionViewRestorsan("Ambrosia Hotel & Restaurant",
                                                                                                            "kazi Deiry, Taiger Pass\nChittagong",
                                                                                                            "test_coll1.png"),
                                                                                                       new CollectionViewRestorsan("Tava Restaurant",
                                                                                                            "Zakir Hossain Rd, \nChittagong",
                                                                                                            "test_coll2.png"),
                                                                                                       new CollectionViewRestorsan("Haatkhola",
                                                                                                            "6 Surson Road, \nChittagong",
                                                                                                            "test_coll1.png")};
    }
}
