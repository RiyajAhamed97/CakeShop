using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public class Cakes
    {
        public string cakeName { get; set; }
        public string imageTitle { get; set; }
        public float price { get; set; }
        public bool Vanila { get; set; }
        public bool Chocolate { get; set; }
        public bool Pineapple { get; set; }

    }
}
