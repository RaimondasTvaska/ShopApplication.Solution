using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Project
{
    class Shop
    {
        private int balance = 10;
        List<Shopitems> Items = new List<Shopitems>();

        public Shop()
        {
            Items.Add(new Shopitems("Candy", 1, 1));
            Items.Add(new Shopitems("Book", 3, 1));
            Items.Add(new Shopitems("Juice", 2, 1));
        }

        public void Buy(string itemName)
        {


            bool doesExist = Items.Select(i => i.Shopitem).Contains(itemName);
            if (!doesExist)
            {
                Console.WriteLine("No stock ...");

            }
            //else
            //{
            //    var item = Items.First(i => i.Shopitem == itemName);
            //    item.Quantity++;
            //}

            if (balance >= Items.First(i => i.Shopitem == itemName).Price)
            {
                balance -= Items.First(i => i.Shopitem == itemName).Price * Items.First(i => i.Shopitem == itemName).Quantity;
                Console.WriteLine("You have " + balance + "Eur left. Would You like to buy anything else?");
                bool eWallet = balance == 0;
                if (eWallet)
                {
                    Console.WriteLine("You don't have possibility to buy anything else. Refresh Your's account and You are welcome again!");
                }
            }
            else
            {
                Console.WriteLine("You do not have enough money! Refresh Your's account");
            }

            
        }

    }
}
