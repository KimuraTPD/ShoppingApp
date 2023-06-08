using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class User
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string tel { get; set; }
        public string address { get; set; }
        public List<Product> buyList { get; set; }
    }
}