using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Project
{
    class Shopitems
    {


        public string Shopitem { get; }
        public int Price { get; }
        public int Quantity { get; set; }

        

        public Shopitems(string name, int price, int quantity)
        {
            Shopitem = name;
            Price = price;
            Quantity = 1;
        }

    }
}