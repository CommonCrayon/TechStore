using Store.Structs;

namespace Store.UserForms
{
    public partial class StoreCart : Form
    {
        public StoreCart()
        {
            InitializeComponent();

            FormClosing += Program.store.CloseEnvironment;

            BackButton.Click += BackButton_Click;
            checkoutButton.Click += CheckoutButton_Click;

            InitializeListView();
            InitializeListViewItems();
            RefreshTotalLabels();
        }



        private void InitializeListView()
        {
            listView1.View = View.Details;

            listView1.Columns.Clear();
            listView1.Columns.Add("Item Id", 70);
            listView1.Columns.Add("Item Name", 300);
            listView1.Columns.Add("Item Price", 100);
            listView1.Columns.Add("<", 25, HorizontalAlignment.Center);
            listView1.Columns.Add("Quantity", 75, HorizontalAlignment.Center);
            listView1.Columns.Add(">", 25, HorizontalAlignment.Center);
            listView1.Columns.Add("Total Price", 100, HorizontalAlignment.Right);
            listView1.Columns.Add("Remove", 100, HorizontalAlignment.Center);

            ListViewExtender extender = new ListViewExtender(listView1);

            // Make Columns Buttons
            ListViewButtonColumn LessQuantityButton = new ListViewButtonColumn(3);
            LessQuantityButton.Click += LessQuantityButton_Click;


            ListViewButtonColumn moreQuantityButton = new ListViewButtonColumn(5);
            moreQuantityButton.Click += MoreQuantityButton_Click;


            ListViewButtonColumn removeItemButton = new ListViewButtonColumn(7);
            removeItemButton.Click += RemoveItemButton_Click;


            extender.AddColumn(LessQuantityButton);
            extender.AddColumn(moreQuantityButton);
            extender.AddColumn(removeItemButton);
        }



        /// <summary>
        /// Repopulates list of items
        /// </summary>
        private void InitializeListViewItems()
        {
            listView1.Items.Clear();

            foreach (var cartItem in Program.store.dataParser.cartDataList)
            {
                ItemData itemData = Program.store.dataParser.GetItemById(cartItem.itemid.ToString());

                ListViewItem item = new ListViewItem(itemData.itemId.ToString());

                item.SubItems.Add(itemData.itemName.ToString());
                item.SubItems.Add(itemData.itemPrice.ToString());
                item.SubItems.Add("<");
                item.SubItems.Add(cartItem.itemQuantity.ToString());
                item.SubItems.Add(">");
                item.SubItems.Add($"{(Convert.ToDouble(cartItem.itemQuantity) * itemData.itemPrice):C}");
                item.SubItems.Add("Remove");

                listView1.Items.Add(item);
            }
        }

        private void RefreshTotalLabels()
        {
            double totalItems = 0;
            double totalPrice = 0;

            foreach (var cartItem in Program.store.dataParser.cartDataList)
            {
                ItemData itemData = Program.store.dataParser.GetItemById(cartItem.itemid.ToString());

                totalItems += cartItem.itemQuantity;
                totalPrice += itemData.itemPrice * cartItem.itemQuantity;
            }

            totalItemsLabel.Text = $"Total Items: {totalItems}";
            totalPriceLabel.Text = $"Total Price: {totalPrice:C}";
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            Program.store.ShowHomePage(this);
        }

        private void LessQuantityButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            Program.store.dataParser.MinusCartItemQuantity(Convert.ToInt32(e.Item.Text));
            InitializeListViewItems();
            RefreshTotalLabels();
        }

        private void MoreQuantityButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            Program.store.dataParser.AddCartItemQuantity(Convert.ToInt32(e.Item.Text));
            InitializeListViewItems();
            RefreshTotalLabels();
        }

        private void RemoveItemButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            Program.store.dataParser.RemoveCartItem(Convert.ToInt32(e.Item.Text));
            InitializeListViewItems();
            RefreshTotalLabels();
        }

        private void CheckoutButton_Click(object? sender, EventArgs e)
        {
            int totalItems = 0;
            double totalPrice = 0;

            List<CustomerCartItem> cart = Program.store.dataParser.cartDataList;

            if (cart.Count == 0)
            {
                MessageBox.Show("You need to have items in your cart to continue to checkout.", "Checkout Error", MessageBoxButtons.OK);
                return;
            }

            foreach (var cartItem in cart)
            {
                ItemData itemData = Program.store.dataParser.GetItemById(cartItem.itemid.ToString());

                totalItems += cartItem.itemQuantity;
                totalPrice += itemData.itemPrice * cartItem.itemQuantity;
            }


            Program.store.dataParser.SetCustomerOrderData(
                new OrderData(
                    Program.store.dataParser.GetAutoGeneratedOrderId(),
                    Program.store.userData,
                    totalPrice,
                    totalItems,
                    cart)
                );

            this.Hide();

            Checkout checkout = (Checkout)new Checkout().SetFormProperties(this);

            checkout.Show();
            checkout.Focus();
        }
    }
}
