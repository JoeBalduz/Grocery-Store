using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace GroceryStore
{
    public partial class Form1 : Form
    {
        private User user;
        private List<Item> inStore;

        /*Used to make the items show up in the list*/
        BindingSource storeBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            inStore = new List<Item>();     //Holds store items

            /*Initializes the user along with their cart*/
            user = new User(0, 0, 250);
            user.cart = new List<Item>();

            /*Used to make text appear in the labels*/
            lblBalance.Text = string.Format("${0:0.00}", user.balance);
            lblTotalPrice.Text = string.Format("${0:0.00}", user.totalPrice);
            lblTaxIncluded.Text = string.Format("${0:0.00}", user.totalPriceWithTax);

            AddItemsToStore();

            /*Makes items show up on the store inventory list*/
            storeBinding.DataSource = inStore.Where(x => x.quantity > 0).ToList();
            listBoxStoreInventory.DataSource = storeBinding;
            listBoxStoreInventory.DisplayMember = "displayForItem";
            listBoxStoreInventory.ValueMember = "displayForItem";

            /*Makes items show up on the cart list*/
            cartBinding.DataSource = user.cart;
            listBoxYourCart.DataSource = cartBinding;
            listBoxYourCart.DisplayMember = "displayForItem";
            listBoxYourCart.ValueMember = "displayForItem";
        }

        /*Populates store with items*/
        public void AddItemsToStore()
        {
            inStore.Add(new Item("Cheese", 1.50, 20));
            inStore.Add(new Item("Steak", 3.30, 14));
            inStore.Add(new Item("Orange Juice", 1.50, 12));
            inStore.Add(new Item("Milk", 1.50, 12));
            inStore.Add(new Item("Cereal", 1.25, 10));
            inStore.Add(new Item("Peanut Butter", 2.95, 16));
            inStore.Add(new Item("Jelly", 2.75, 17));
            inStore.Add(new Item("Bread", 5.00, 13));
            inStore.Add(new Item("Pack of Water", 8.00, 20));
            inStore.Add(new Item("Eggs", 6.00, 18));
            inStore.Add(new Item("Pizza", 6.50, 12));
            inStore.Add(new Item("Apple", 0.80, 28));
            inStore.Add(new Item("Orange", 0.80, 30));
            inStore.Add(new Item("Banana", 0.90, 15));
            inStore.Add(new Item("Chips", 3.30, 14));
            inStore.Add(new Item("Granola Bar", 0.3, 18));
            inStore.Add(new Item("Turkey", 3.00, 11));
            inStore.Add(new Item("Ham", 1.35, 14));
            inStore.Add(new Item("Crackers", 3.40, 8));
            inStore.Add(new Item("Cookies", 3.50, 10));
            inStore.Add(new Item("Rice", 2.90, 5));
        }

        /*Add to cart button*/
        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;

            Item selectedItem = (Item) listBoxStoreInventory.SelectedItem; 

            if (selectedItem == null)   //No item is selected
                return;

            selectedItem.quantity--;

            /*Goes through every item in the cart to see if the item is already in the cart*/
            foreach (Item item in user.cart)
            {
                if (selectedItem.name == item.name)
                {
                    item.quantity++;
                    found = true;
                    break;
                }
            }

            /*Item was not found in cart so it must be added*/
            if(!found)
            {
                user.cart.Add(new Item(selectedItem.name, selectedItem.price, 1));
            }

            user.totalPrice += selectedItem.price;
            user.totalPriceWithTax = user.totalPrice * 1.07;

            lblTotalPrice.Text = string.Format("${0:0.00}", user.totalPrice);
            lblTaxIncluded.Text = string.Format("${0:0.00}", user.totalPriceWithTax);

            storeBinding.DataSource = inStore.Where(x => x.quantity > 0).ToList();
            cartBinding.DataSource = user.cart.Where(x => x.quantity > 0).ToList();

            /*Must be done to update the list*/
            storeBinding.ResetBindings(false);
            cartBinding.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ignore
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)listBoxYourCart.SelectedItem;

            if (selectedItem == null)
                return;

            selectedItem.quantity--;

            /*Goes through every item in the store to find which item to put back*/
            foreach(Item item in inStore)
            {
                if(selectedItem.name == item.name)
                {
                    item.quantity++;
                    break;
                }
            }

            user.totalPrice -= selectedItem.price;
            user.totalPriceWithTax = user.totalPrice * 1.07;

            lblTotalPrice.Text = string.Format("${0:0.00}", user.totalPrice);
            lblTaxIncluded.Text = string.Format("${0:0.00}", user.totalPriceWithTax);

            storeBinding.DataSource = inStore.Where(x => x.quantity > 0).ToList();
            cartBinding.DataSource = user.cart.Where(x => x.quantity > 0).ToList();

            /*Must be done to update lists*/
            storeBinding.ResetBindings(false);
            cartBinding.ResetBindings(false);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            /*Makes sure that the user has enough money to pay for the items*/
            if (user.balance >= user.totalPriceWithTax)
            {
                user.balance -= user.totalPriceWithTax;
                user.totalPrice = 0;
                user.totalPriceWithTax = 0;

                lblBalance.Text = string.Format("${0:0.00}", user.balance);
                lblTotalPrice.Text = string.Format("${0:0.00}", user.totalPrice);
                lblTaxIncluded.Text = string.Format("${0:0.00}", user.totalPriceWithTax);

                user.cart.Clear();

                cartBinding.DataSource = user.cart.Where(x => x.quantity > 0).ToList();

                /*Updates list*/
                cartBinding.ResetBindings(false);
            }
            /*Otherwise there is an error message*/
            else
                MessageBox.Show("You don't have enough money to purchase everything. Try removing some items from your cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
