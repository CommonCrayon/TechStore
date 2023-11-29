using Store.Structs;
using Store.UserMenus;
using System.Data;

namespace Store.UserForms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();

            FormClosing += Program.store.CloseEnvironment;
            toolStripTextBox1.TextChanged += ToolStripTextBox1_TextChanged;
            toolStripDropDownButton1.DropDownItemClicked += ToolStripDropDownButton1_Click;

            InitializeListView();
            RefreshListViewItems();

            if (Program.store.userData.UserRole.Equals(UserRoles.Admin))
            {
                InitializeEditTab();
                InitializeDeleteTab();
            }
            else
            {
                // Disable if not Admin
                tabControl1.TabPages[1].Enabled = false;
                tabControl1.TabPages[2].Enabled = false;
            }
        }

        /// <summary>
        /// Initializes all ListView resources
        /// </summary>
        private void InitializeListView()
        {
            listView1.Groups.Clear();
            toolStripDropDownButton1.DropDown.Items.Clear();

            toolStripDropDownButton1.DropDown.Items.Add("View All");

            foreach (UserRoles role in Enum.GetValues(typeof(UserRoles)))
            {
                listView1.Groups.Add(new ListViewGroup(role.ToString(), HorizontalAlignment.Left));
                toolStripDropDownButton1.DropDown.Items.Add(role.ToString());
            }

            listView1.View = View.Details;

            listView1.Columns.Clear();
            listView1.Columns.Add("User Id", 70);
            listView1.Columns.Add("User Role", 100);
            listView1.Columns.Add("Username", 100);
            listView1.Columns.Add("First Name", 100);
            listView1.Columns.Add("Last Name", 100);
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("Phone Number", 100);
        }

        /// <summary>
        /// Initializes List View Items, can be refreshed.
        /// </summary>
        private void RefreshListViewItems()
        {
            listView1.Items.Clear();

            foreach (var user in Program.store.dataParser.userDataList)
            {
                ListViewItem item = new ListViewItem(user.UserId.ToString());

                item.SubItems.Add(user.UserRole.ToString());
                item.SubItems.Add(user.UserName.ToString());
                item.SubItems.Add(user.FirstName.ToString());
                item.SubItems.Add(user.LastName.ToString());
                item.SubItems.Add(user.Email.ToString());
                item.SubItems.Add(user.PhoneNumber.ToString());

                item.Group = listView1.Groups[((int)user.UserRole) - 1];

                listView1.Items.Add(item);
            }
        }

        private void InitializeEditTab()
        {
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            cancelButton.Click += CancelButton_Click;
            applyButton.Click += ApplyButton_Click;

            userRoleComboBox.Items.Clear();

            foreach (UserRoles role in Enum.GetValues(typeof(UserRoles)))
            {
                userRoleComboBox.Items.Add(role.ToString());
            }
        }

        private void InitializeDeleteTab()
        {
            searchDeleteTextBox.TextChanged += SearchDeleteTextBox_TextChanged;
            deleteUserButton.Click += DeleteUserButton_Click;

            userRoleDeleteComboBox.Items.Clear();

            foreach (UserRoles role in Enum.GetValues(typeof(UserRoles)))
            {
                userRoleDeleteComboBox.Items.Add(role.ToString());
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
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
            else
            {
                throw new Exception("Users that are not admin or employee should never be here");
            }
        }


        private void ToolStripDropDownButton1_Click(object? sender, ToolStripItemClickedEventArgs e)
        {
            RefreshListViewItems();

            if (e.ClickedItem.Text.ToString() == "View All") return;

            listView1.Items.Cast<ListViewItem>()
                .Where(item => item.Group.Header != e.ClickedItem.Text.ToString())
                .ToList()
                .ForEach(item =>
                {
                    listView1.Items.Remove(item);
                });
        }

        private void ToolStripTextBox1_TextChanged(object? sender, EventArgs e)
        {
            string newInput = toolStripTextBox1.Text;

            RefreshListViewItems();

            if (!string.IsNullOrEmpty(newInput))
            {
                listView1.Items.Cast<ListViewItem>()
                    .Where(item => !(item.Text.Contains(newInput) ||
                                    item.SubItems[1].Text.ToLower().Contains(newInput.ToLower()) ||
                                    item.SubItems[2].Text.ToLower().Contains(newInput.ToLower()) ||
                                    item.SubItems[3].Text.ToLower().Contains(newInput.ToLower()) ||
                                    item.SubItems[4].Text.ToLower().Contains(newInput.ToLower()) ||
                                    item.SubItems[5].Text.ToLower().Contains(newInput.ToLower()) ||
                                    item.SubItems[6].Text.ToLower().Contains(newInput.ToLower())))
                    .ToList()
                    .ForEach(item =>
                    {
                        listView1.Items.Remove(item);
                    });
            }
        }


        private void SearchTextBox_TextChanged(object? sender, EventArgs e)
        {
            string newInput = searchTextBox.Text;

            if (!string.IsNullOrEmpty(newInput))
            {
                foreach (UserData user in Program.store.dataParser.userDataList)
                {
                    if (user.UserId.ToLower().Equals(newInput.ToLower()) ||
                        user.UserName.ToLower().Equals(newInput.ToLower()) ||
                        user.FirstName.ToLower().Equals(newInput.ToLower()) ||
                        user.LastName.ToLower().Equals(newInput.ToLower()) ||
                        user.Email.ToLower().Equals(newInput.ToLower()) ||
                        user.PhoneNumber.ToLower().Equals(newInput.ToLower())
                        )
                    {
                        applyButton.Enabled = true;
                        cancelButton.Enabled = true;

                        userRoleComboBox.SelectedIndex = ((int)user.UserRole) - 1;
                        useridTextBox.Text = user.UserId.ToString();
                        usernameTextBox.Text = user.UserName.ToString();
                        passwordTextBox.Text = user.Password.ToString();
                        firstNameTextBox.Text = user.FirstName.ToString();
                        lastNameTextBox.Text = user.LastName.ToString();
                        emailTextBox.Text = user.Email.ToString();
                        phoneTextBox.Text = user.PhoneNumber.ToString();

                        return;
                    }
                }
            }

            applyButton.Enabled = false;
            cancelButton.Enabled = false;

            userRoleComboBox.SelectedItem = 0;
            useridTextBox.Text = string.Empty;
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            string newInput = searchTextBox.Text;

            if (!string.IsNullOrEmpty(newInput))
            {
                foreach (UserData user in Program.store.dataParser.userDataList)
                {
                    if (user.UserId.ToLower().Equals(newInput.ToLower()) ||
                        user.UserName.ToLower().Equals(newInput.ToLower()) ||
                        user.FirstName.ToLower().Equals(newInput.ToLower()) ||
                        user.LastName.ToLower().Equals(newInput.ToLower()) ||
                        user.Email.ToLower().Equals(newInput.ToLower()) ||
                        user.PhoneNumber.ToLower().Equals(newInput.ToLower())
                        )
                    {
                        applyButton.Enabled = true;
                        cancelButton.Enabled = true;

                        userRoleComboBox.SelectedIndex = ((int)user.UserRole) - 1;
                        useridTextBox.Text = user.UserId.ToString();
                        usernameTextBox.Text = user.UserName.ToString();
                        passwordTextBox.Text = user.Password.ToString();
                        firstNameTextBox.Text = user.FirstName.ToString();
                        lastNameTextBox.Text = user.LastName.ToString();
                        emailTextBox.Text = user.Email.ToString();
                        phoneTextBox.Text = user.PhoneNumber.ToString();

                        return;
                    }
                }
            }

            applyButton.Enabled = false;
            cancelButton.Enabled = false;

            userRoleComboBox.SelectedItem = 0;
            useridTextBox.Text = string.Empty;
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
        }

        private void ApplyButton_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update user details?", "Edit User", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                UserData newUser = new UserData(
                    Convert.ToInt32(Enum.Parse<UserRoles>(userRoleComboBox.Text)),
                    useridTextBox.Text.ToString().Trim(),
                    usernameTextBox.Text.ToString().Trim(),
                    passwordTextBox.Text.ToString().Trim(),
                    firstNameTextBox.Text.ToString().Trim(),
                    lastNameTextBox.Text.ToString().Trim(),
                    emailTextBox.Text.ToString().Trim(),
                    phoneTextBox.Text.ToString().Trim()
                    );

                Program.store.dataParser.EditUser(newUser);
                RefreshListViewItems();
            }
        }



        private void SearchDeleteTextBox_TextChanged(object? sender, EventArgs e)
        {
            string newInput = searchDeleteTextBox.Text;

            if (!string.IsNullOrEmpty(newInput))
            {
                foreach (UserData user in Program.store.dataParser.userDataList)
                {
                    if (user.UserId.ToLower().Equals(newInput.ToLower()) ||
                        user.UserName.ToLower().Equals(newInput.ToLower()) ||
                        user.FirstName.ToLower().Equals(newInput.ToLower()) ||
                        user.LastName.ToLower().Equals(newInput.ToLower()) ||
                        user.Email.ToLower().Equals(newInput.ToLower()) ||
                        user.PhoneNumber.ToLower().Equals(newInput.ToLower())
                        )
                    {
                        deleteUserButton.Enabled = true;

                        userRoleDeleteComboBox.SelectedIndex = ((int)user.UserRole) - 1;
                        useridDeleteTextBox.Text = user.UserId.ToString();
                        usernameDeleteTextBox.Text = user.UserName.ToString();
                        passwordDeleteTextBox.Text = user.Password.ToString();
                        firstNameDeleteTextBox.Text = user.FirstName.ToString();
                        lastNameDeleteTextBox.Text = user.LastName.ToString();
                        emailDeleteTextBox.Text = user.Email.ToString();
                        phoneDeleteTextBox.Text = user.PhoneNumber.ToString();

                        return;
                    }
                }
            }

            deleteUserButton.Enabled = false;

            userRoleDeleteComboBox.SelectedItem = 0;
            useridDeleteTextBox.Text = string.Empty;
            usernameDeleteTextBox.Text = string.Empty;
            passwordDeleteTextBox.Text = string.Empty;
            firstNameDeleteTextBox.Text = string.Empty;
            lastNameDeleteTextBox.Text = string.Empty;
            emailDeleteTextBox.Text = string.Empty;
            phoneDeleteTextBox.Text = string.Empty;
        }

        private void DeleteUserButton_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete user?", "Delete User", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                UserData deleteUser = Program.store.dataParser.GetUserDataById(useridDeleteTextBox.Text.ToString().Trim());

                Program.store.dataParser.DeleteUser(deleteUser);
                RefreshListViewItems();
                SearchDeleteTextBox_TextChanged(null, EventArgs.Empty);
            }
        }
    }
}
