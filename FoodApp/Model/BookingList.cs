using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class BookingList : CollectionData
    {
        public BookingList(string title, string additionally, string image)
        {
            this.title = title;
            this.additionally = additionally;
            this.image = image;
        }
    }
}
