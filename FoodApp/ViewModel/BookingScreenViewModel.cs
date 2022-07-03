using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public partial class BookingScreenViewModel : BaseViewModel
    {
        public ObservableCollection<BookingList> bookingList { get; } = new(){ new BookingList("Ambrosia Hotel & Restaurant",
                                                                                                            "kazi Deiry, Taiger Pass\nChittagong",
                                                                                                            "test_coll1.png"),
                                                                                                       new BookingList("Tava Restaurant",
                                                                                                            "Zakir Hossain Rd, \nChittagong",
                                                                                                            "test_coll2.png"),
                                                                                                       new BookingList("Haatkhola",
                                                                                                            "6 Surson Road, \nChittagong",
                                                                                                            "test_coll1.png")};
    }
}
