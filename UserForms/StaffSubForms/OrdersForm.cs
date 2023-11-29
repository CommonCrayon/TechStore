using Store.Structs;
using Store.UserMenus;
using System.Data;

namespace Store.UserForms.StaffSubForms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();

            FormClosing += Program.store.CloseEnvironment;
            BackButton.Click += BackButton_Click;

            InitializeListView();

            if (Program.store.userData.UserRole.Equals(UserRoles.Admin))
            {
                deleteOrderTextBox.TextChanged += SearchDeleteTextBox_TextChanged;
                deleteOrderButton.Click += DeleteOrderButton_Click;
            }
            else
            {
                tabControl1.TabPages[1].Enabled = false;
            }
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            if (Program.store.userData.UserRole.Equals(UserRoles.Admin))
            {
                this.Hide();

                AdminForm form = (AdminForm)new AdminForm().SetFormProperties(this);
                form.Show();
                form.Focus();
            }
            else if (Program.store.userData.UserRole.Equals(UserRoles.Employee))
            {
                this.Hide();

                EmployeeForm form = (EmployeeForm)new EmployeeForm().SetFormProperties(this);
                form.Show();
                form.Focus();
            }
            else if (Program.store.userData.UserRole.Equals(UserRoles.Packager))
            {
                this.Hide();

                PackagerForm form = (PackagerForm)new PackagerForm().SetFormProperties(this);
                form.Show();
                form.Focus();
            }
            else
            {
                throw new Exception("Users that are not admin or employee should never be here");
            }
        }



        /// <summary>
        /// Initializes List View Coloumns and Details
        /// </summary>
        private void InitializeListView()
        {
            toolStripTextBox1.TextChanged += ToolStripTextBox1_TextChanged; ;

            listView1.View = View.Details;

            listView1.Groups.Clear();

            listView1.Columns.Clear();
            listView1.Columns.Add("Order Id", 75);
            listView1.Columns.Add("User Data", 75);
            listView1.Columns.Add("Total Price", 75);
            listView1.Columns.Add("Total Quantity", 100);

            listView1.Columns.Add("Order Items", 175);

            listView1.Columns.Add("Type", 75); // Pickup or Delivery
            listView1.Columns.Add("Shipping Info", 85);

            listView1.Columns.Add("Order Complete?", 110);



            ListViewExtender extender = new ListViewExtender(listView1);

            // Make Columns Buttons
            ListViewButtonColumn UserDataButton = new ListViewButtonColumn(1);
            ListViewButtonColumn OrderItemsDataButton = new ListViewButtonColumn(4);
            ListViewButtonColumn ShippingInfoDataButton = new ListViewButtonColumn(6);
            ListViewButtonColumn OrderCompleteDataButton = new ListViewButtonColumn(7);

            UserDataButton.Click += UserDataButton_Click;
            OrderItemsDataButton.Click += OrderItemsDataButton_Click;
            ShippingInfoDataButton.Click += ShippingInfoDataButton_Click;
            OrderCompleteDataButton.Click += OrderCompleteDataButton_Click;

            extender.AddColumn(UserDataButton);
            extender.AddColumn(OrderItemsDataButton);
            extender.AddColumn(ShippingInfoDataButton);
            extender.AddColumn(OrderCompleteDataButton);

            InitializeListViewItems();
        }

        /// <summary>
        /// Repopulates list of items
        /// </summary>
        private void InitializeListViewItems()
        {
            listView1.Items.Clear();

            foreach (var orderData in Program.store.dataParser.orderDataList)
            {
                ListViewItem item = new ListViewItem(orderData.orderId.ToString());

                item.SubItems.Add(orderData.userData.UserId.ToString());
                item.SubItems.Add(orderData.price.ToString("C"));
                item.SubItems.Add(orderData.quantity.ToString());
                item.SubItems.Add("Items");

                if (orderData.isDelivery)
                {
                    item.SubItems.Add("Delivery");
                    item.SubItems.Add("Click to View");
                }
                else
                {
                    item.SubItems.Add("Pickup");
                    item.SubItems.Add("");
                }

                if (orderData.orderComplete)
                {
                    item.SubItems.Add("Complete");
                }
                else
                {
                    item.SubItems.Add("Processing");
                }

                listView1.Items.Add(item);
            }
        }

        private void ToolStripTextBox1_TextChanged(object? sender, EventArgs e)
        {
            string newInput = toolStripTextBox1.Text;

            InitializeListViewItems();

            if (!string.IsNullOrEmpty(newInput))
            {
                listView1.Items.Cast<ListViewItem>()
                    .Where(item => !(item.Text.Contains(newInput) || item.SubItems[1].Text.Contains(newInput)))
                    .ToList()
                    .ForEach(item =>
                    {
                        listView1.Items.Remove(item);
                    });
            }
        }

        private void OrderCompleteDataButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            OrderData orderData = Program.store.dataParser.GetOrderData(Convert.ToInt32(e.Item.Text.ToString()));

            if (orderData.orderComplete)
            {
                DialogResult dialogResult = MessageBox.Show("Revert this order as processing?", "Order Processing", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Program.store.dataParser.ToggleOrderComplete(orderData.orderId);
                    InitializeListViewItems();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Mark this order as being processed and complete?", "Order Processing", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Program.store.dataParser.ToggleOrderComplete(orderData.orderId);
                    InitializeListViewItems();
                }
            }
        }

        private void ShippingInfoDataButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            OrderData orderData = Program.store.dataParser.GetOrderData(Convert.ToInt32(e.Item.Text.ToString()));

            MessageBox.Show(
                $"Street Address: {orderData.shippingInformation.streetAddress}\n" +
                $"City: {orderData.shippingInformation.city}\n" +
                $"State: {orderData.shippingInformation.state}\n" +
                $"Postcode: {orderData.shippingInformation.postCode}\n" +
                $"Country: {orderData.shippingInformation.country}\n",
                "Shipping Information",
                MessageBoxButtons.OK);
        }

        private void OrderItemsDataButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            string fullText = string.Empty;

            OrderData orderData = Program.store.dataParser.GetOrderData(Convert.ToInt32(e.Item.Text.ToString()));

            foreach (CustomerCartItem item in orderData.customerCartItems)
            {
                ItemData itemData = Program.store.dataParser.GetItemById(item.itemid.ToString());
                fullText +=
                    $"Item Id: {itemData.itemId}\n" +
                    $"Item Name: {itemData.itemName}\n" +
                    $"Item Quantity: {item.itemQuantity}\n" +
                    $"Item Price: {(itemData.itemPrice * item.itemQuantity).ToString("C")}\n\n";
            }

            MessageBox.Show(fullText, "Order Information", MessageBoxButtons.OK);
        }

        private void UserDataButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            UserData userData = Program.store.dataParser.GetUserDataById(e.Item.SubItems[1].Text.ToString());

            MessageBox.Show(
                $"User Id: {userData.UserId}\n" +
                $"Username: {userData.UserName}\n" +
                $"First Name: {userData.FirstName}\n" +
                $"Last Name: {userData.LastName}\n" +
                $"Email: {userData.Email}\n" +
                $"Phone Number: {userData.PhoneNumber}\n",
                "User Information",
                MessageBoxButtons.OK);
        }




        private void SearchDeleteTextBox_TextChanged(object? sender, EventArgs e)
        {
            string newInput = deleteOrderTextBox.Text;

            if (!string.IsNullOrEmpty(newInput) && int.TryParse(newInput, out int parsedInt))
            {
                foreach (OrderData order in Program.store.dataParser.orderDataList)
                {
                    if (order.orderId == Convert.ToInt32(newInput))
                    {
                        deleteOrderButton.Enabled = true;

                        orderIdTextBox.Text = order.orderId.ToString();
                        userIdTextBox.Text = order.userData.UserId.ToString();
                        orderCompleteTextBox.Text = order.orderComplete.ToString();
                        totalPriceTextBox.Text = order.price.ToString();
                        totalQuantityTextBox.Text = order.quantity.ToString();
                        isDeliveryTextBox.Text = order.isDelivery.ToString();

                        return;
                    }
                }
            }

            deleteOrderButton.Enabled = false;

            orderIdTextBox.Text = string.Empty;
            userIdTextBox.Text = string.Empty;
            orderCompleteTextBox.Text = string.Empty;
            totalPriceTextBox.Text = string.Empty;
            totalQuantityTextBox.Text = string.Empty;
            isDeliveryTextBox.Text = string.Empty;
        }

        private void DeleteOrderButton_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Order?", "Delete Order", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                OrderData order = Program.store.dataParser.GetOrderData(Convert.ToInt32(orderIdTextBox.Text));

                Program.store.dataParser.RemoveOrder(Convert.ToInt32(orderIdTextBox.Text));

                InitializeListViewItems();
                SearchDeleteTextBox_TextChanged(null, EventArgs.Empty);
            }
        }
    }
}
