using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class User
    {
        public double totalPrice { get; set; }
        public double totalPriceWithTax { get; set; }
        public double balance { get; set; }
        public List<Item> cart { get; set; }


        public User(double totalPrice_, double totalPriceWithTax_, double balance_)
        {
            totalPrice = totalPrice_;
            totalPriceWithTax = totalPriceWithTax_;
            balance = balance_;
        }
    }
}
