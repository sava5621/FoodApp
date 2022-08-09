using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class UserToken
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string Name { get; set; }
        public string CreationT { get; set; }
        public string DryingT { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

    }
}
