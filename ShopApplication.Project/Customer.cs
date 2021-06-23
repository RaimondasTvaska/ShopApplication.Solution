using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Project
{
    class Customer
    {
        public string CustomerName { get; set; }
        public int Wallet { get; set; }
        public Customer(string name, int wallet)
        {
            CustomerName = name;
            Wallet = wallet;
        }
    }
}
