using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class Product
    {
        public int productId { get; set; }
        public int price { get; set; }
        public string create_date { get; set; }
        public string image_url { get; set; }
    }
}