using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Purchase:Item
    {
        
        public int NumberOfOtems { get; set; }
        public double TotalCost { get; set; }

        public Purchase()
        {
            NumberOfOtems = 0;
            TotalCost = 0;
        }
    }
}
