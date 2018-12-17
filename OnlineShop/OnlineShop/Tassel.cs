using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Tassel:Item
    {
        public string Manufacturer { get; set; }
        public string TypeOfPile { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        public bool onStock { get; set; }
        public int NumberOnStock { get; set; }

        public Tassel()
        {
            Manufacturer = "Default";
            TypeOfPile = "Default";
            Number = "F";
            Price = 0.99;
            onStock = true;
            NumberOnStock = 100;

        }
    }
}
