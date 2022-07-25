using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model.View
{
    public class HomeModel
    {
        public ObservableCollection<Carousel_advertisement> carousel_advertisement { get; set; }
        public ObservableCollection<Carousel_offers> carousel_offers { get; set; }
        public ObservableCollection<CollectionViewRestorsan> сollectionViewRestorsan { get; set; }
    }
}
