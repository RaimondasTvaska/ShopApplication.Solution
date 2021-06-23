using System;
using System.Collections.Generic;

namespace ShopApplication.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Shop shop = new Shop();

            Console.WriteLine("Welcome! There are You find some goods to buy");
            while (command != "Exit")
            {
                command = Console.ReadLine();

                if (command.Contains("Buy"))
                {
                    var itemName = command.Split(" ")[1];
                    shop.Buy(itemName);
                    //int balance = Shop.balance;
                    //Console.WriteLine("You have " + balance + "Eur left. Would You buy anything else?");
                }

            }
        }
    }
}
