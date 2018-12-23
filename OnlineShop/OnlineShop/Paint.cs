using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Paint: Item
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Covering { get; set; }
        public double Price { get; set; }
        public bool onStock { get; set; }
        public int NumberOnStock { get; set; }

        public  Paint()
        {
            Manufacturer = "Default";
            Type = "Default";
            Color = "White";
            Covering = 1;
            Price = 0.99;
            onStock = true;
            NumberOnStock = 100;

        }
    }
}
