using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Paper:Item
    {
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Opacity { get; set; }
        public double Price { get; set; }
        public bool onStock { get; set; }
        public int NumberOnStock { get; set; }

        public Paper()
        {
            Manufacturer = "Default";
            Type = "Default";
            Color = "White";
            Opacity = 1;
            Price= 0.99;
            onStock = true;
            NumberOnStock = 100;

        }
    }
}
