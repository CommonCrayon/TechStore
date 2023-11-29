using Store.Structs;
using Store.UserForms;
using Store.UserMenus;

namespace Store
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            LeftSideButton.TabIndex = 0;
            CartButton.TabIndex = 1;
            LogOutButton.TabIndex = 2;

            FormClosing += Program.store.CloseEnvironment;
            toolStripTextBox1.TextChanged += ToolStripTextBox1_TextChanged;
            toolStripDropDownButton1.DropDownItemClicked += ToolStripDropDownButton1_Click;
            LogOutButton.Click += LogOutForCustomersButton_Click;
            CartButton.Click += CartButton_Click;

            InitializeListView();
            InitializeHomePage();
        }



        /// <summary>
        /// Created to refresh upon page enter
        /// </summary>
        public void InitializeHomePage()
        {
            LeftSideButton.Click -= BackToMenuButton_Click;
            LeftSideButton.Click -= LoginOrRegisterButton_Click;
            LeftSideButton.Click -= PersonalDetailsForCustomersButton_Click;

            if (Program.store.userData.IsValid())
            {
                label1.Text = $"Welcome {Program.store.userData.FirstName} {Program.store.userData.LastName}";

                if (Program.store.userData.UserRole != UserRoles.Customer)
                {
                    CartButton.Visible = false;

                    LogOutButton.Enabled = false;
                    LogOutButton.Visible = false;

                    LeftSideButton.Text = "Back To Menu";
                    LeftSideButton.Click += BackToMenuButton_Click;
                }
                else
                {
                    CartButton.Enabled = true;
                    CartButton.BackColor = Color.SlateGray;

                    LogOutButton.Enabled = true;
                    LogOutButton.Visible = true;

                    LeftSideButton.Text = "Personal Details";
                    LeftSideButton.Click += PersonalDetailsForCustomersButton_Click;
                }
            }
            else
            {
                LogOutButton.Enabled = false;
                LogOutButton.Visible = false;

                CartButton.Enabled = false;
                CartButton.Visible = true;
                CartButton.BackColor = Color.DarkGray;

                label1.Text = string.Empty;

                LeftSideButton.Text = "Login/Register";
                LeftSideButton.Click += LoginOrRegisterButton_Click;
            }

            InitializeListViewItems();
        }




        /// <summary>
        /// Initializes List View Coloumns and Details
        /// </summary>
        private void InitializeListView()
        {
            listView1.View = View.Details;

            listView1.Groups.Clear();
            toolStripDropDownButton1.DropDown.Items.Clear();

            toolStripDropDownButton1.DropDown.Items.Add("View All");

            foreach (ItemCategories categories in Enum.GetValues(typeof(ItemCategories)))
            {
                listView1.Groups.Add(new ListViewGroup(categories.ToString(), HorizontalAlignment.Left));
                toolStripDropDownButton1.DropDown.Items.Add(categories.ToString());
            }


            listView1.Columns.Clear();
            listView1.Columns.Add("Item Id", 100);
            listView1.Columns.Add("Item Name", 300);
            listView1.Columns.Add("Item Price", 100);
            listView1.Columns.Add("More Details", 100);
            listView1.Columns.Add("Add to Cart", 100);


            ListViewExtender extender = new ListViewExtender(listView1);

            // Make Columns Buttons
            ListViewButtonColumn MoreDetailsButton = new ListViewButtonColumn(3);
            MoreDetailsButton.Click += MoreDetailsButton_Click;


            ListViewButtonColumn AddToCartButton = new ListViewButtonColumn(4);
            AddToCartButton.Click += AddToCartButton_Click;

            extender.AddColumn(MoreDetailsButton);
            extender.AddColumn(AddToCartButton);
        }


        //=======================================================================================================
        //      START OF CLICK AND TEXTCHANGED FUNCTIONS
        //=======================================================================================================

        /// <summary>
        /// Repopulates list of items
        /// </summary>
        private void InitializeListViewItems()
        {
            listView1.Items.Clear();

            foreach (var itemData in Program.store.dataParser.itemDataList)
            {
                ListViewItem item = new ListViewItem(itemData.itemId.ToString());

                item.SubItems.Add(itemData.itemName.ToString());
                item.SubItems.Add($"{itemData.itemPrice:C}");
                item.SubItems.Add("Details");
                item.SubItems.Add("Add to Cart");

                item.Group = listView1.Groups[((int)itemData.itemCategory) - 1];

                listView1.Items.Add(item);
            }
        }



        /// <summary>
        /// Filters for the specific category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripDropDownButton1_Click(object? sender, ToolStripItemClickedEventArgs e)
        {
            InitializeListViewItems();

            if (e.ClickedItem.Text.ToString() == "View All") return;

            listView1.Items.Cast<ListViewItem>()
                .Where(item => item.Group.Header != e.ClickedItem.Text.ToString())
                .ToList()
                .ForEach(item =>
                {
                    listView1.Items.Remove(item);
                });
        }



        /// <summary>
        /// Filters for specfic text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTextBox1_TextChanged(object? sender, EventArgs e)
        {
            string newInput = toolStripTextBox1.Text;

            InitializeListViewItems();

            if (!string.IsNullOrEmpty(newInput))
            {
                listView1.Items.Cast<ListViewItem>()
                    .Where(item => !(item.Text.Contains(newInput) || item.SubItems[1].Text.ToLower().Contains(newInput.ToLower())))
                    .ToList()
                    .ForEach(item =>
                    {
                        listView1.Items.Remove(item);
                    });
            }
        }



        /// <summary>
        /// Opens upon more details button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoreDetailsButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            ItemData item = Program.store.dataParser.GetItemById(e.Item.Text.ToString());
            MessageBox.Show(this, $"Item Id: {item.itemId}\nItem Price: ${item.itemPrice}\nItem Description: {item.itemDescription}", item.itemName.ToString(), MessageBoxButtons.OK);
        }



        /// <summary>
        /// Adds Items to Cart from ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButton_Click(object? sender, ListViewColumnMouseEventArgs e)
        {
            if (Program.store.userData.UserRole.Equals(UserRoles.Customer))
            {
                CustomerCartItem newCartItem = new CustomerCartItem(Convert.ToInt32(e.Item.Text), 1);

                for (int i = 0; i < Program.store.dataParser.cartDataList.Count; i++)
                {
                    CustomerCartItem item = Program.store.dataParser.cartDataList[i];

                    if (newCartItem.itemid == item.itemid)
                    {
                        MessageBox.Show("Your Selected Item is already in Cart.", "Item in Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Program.store.dataParser.cartDataList.Add(newCartItem);
                Program.store.dataParser.SaveCartDataList();
                MessageBox.Show($"Item {e.Item.Text} was added to your Cart", "Successfully Added Item", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Only Customers are Allowed to Add to Cart", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Takes user to entry page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginOrRegisterButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            EntryForm entryForm = (EntryForm)new EntryForm().SetFormProperties(this);
            entryForm.Show();
            entryForm.Focus();
        }



        /// <summary>
        /// Takes an admin or employee back to their menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToMenuButton_Click(object? sender, EventArgs e)
        {
            if (Program.store.userData.UserRole.Equals(UserRoles.Admin))
            {
                this.Hide();

                AdminForm adminForm = (AdminForm)new AdminForm().SetFormProperties(this);
                adminForm.Show();
                adminForm.Focus();
            }
            else if (Program.store.userData.UserRole.Equals(UserRoles.Employee))
            {
                this.Hide();

                EmployeeForm empForm = (EmployeeForm)new EmployeeForm().SetFormProperties(this);
                empForm.Show();
                empForm.Focus();
            }
        }



        /// <summary>
        /// Allows customer to see their own personal details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonalDetailsForCustomersButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            PersonalDetails personalDetails = (PersonalDetails)new PersonalDetails().SetFormProperties(this);
            personalDetails.Show();
            personalDetails.Focus();
        }



        /// <summary>
        /// Allows customer to logout and refreshes page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOutForCustomersButton_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Click OK to Continue to LogOut and return to Home Page.", "Logging Out", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                Program.store.SetUserData(new UserData());
                Program.store.ShowHomePage(this);
            }
        }



        /// <summary>
        /// Go To Customer Cart
        /// Can only be done by Customer Role
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            StoreCart storeCart = (StoreCart)new StoreCart().SetFormProperties(this);
            storeCart.Show();
            storeCart.Focus();
        }
    }
}