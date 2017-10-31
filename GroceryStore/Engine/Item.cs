using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        /*Used to put the items on the list in a specific way*/
        public string displayForItem
        {
            get
            {
                return string.Format("{0} - ${1:0.00} - Quantity: {2}", name, price, quantity);
            }
        }

        public Item(string name_, double price_, int quantity_)
        {
            name = name_;
            price = price_;
            quantity = quantity_;
        }
    }
}
