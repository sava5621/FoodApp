using FoodApp.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    [QueryProperty(nameof(Restoran), "Restoran")]
    public partial class MapViewModel : BaseViewModel
    {
        public MapViewModel()
        {
            
             url = "https://u1648633.plsk.regruhosting.ru/YandexMap/byName?x=55.847&y=37.6";
            //@"https://u1648633.plsk.regruhosting.ru/YandexMap/byName?x=50.847&y=37.6";
        }

        [ObservableProperty]
        public CollectionViewRestorsan restoran;
        [ObservableProperty]
        public string url;


    }
}
