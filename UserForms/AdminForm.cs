using Store.UserForms;
using Store.UserForms.StaffSubForms;

namespace Store.UserMenus
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            PersonalDetailsButton.TabIndex = 0;
            HomePageButton.TabIndex = 1;
            UsersButton.TabIndex = 2;
            OrderButton.TabIndex = 3;
            ItemsButton.TabIndex = 4;
            LogOutButton.TabIndex = 5;

            nameLabel.Text = $"{Program.store.userData.FirstName} {Program.store.userData.LastName}";

            UsersButton.Click += UsersButton_Click;
            HomePageButton.Click += HomePageButton_Click;
            PersonalDetailsButton.Click += PersonalDetailsButton_Click;
            ItemsButton.Click += ItemsButton_Click;
            OrderButton.Click += OrderButton_Click;

            LogOutButton.Click += LogOutButton_Click;

            FormClosing += Program.store.CloseEnvironment;
        }

        private void OrderButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            OrdersForm ordersForm = (OrdersForm)new OrdersForm().SetFormProperties(this);
            ordersForm.Show();
            ordersForm.Focus();
        }

        private void ItemsButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            ItemsForm itemsForm = (ItemsForm)new ItemsForm().SetFormProperties(this);
            itemsForm.Show();
            itemsForm.Focus();
        }

        private void LogOutButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            Program.store.SetUserData(new Structs.UserData());
            Program.store.ShowHomePage(this);
        }

        private void PersonalDetailsButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            PersonalDetails personalDetails = (PersonalDetails)new PersonalDetails().SetFormProperties(this); ;
            personalDetails.Show();
            personalDetails.Focus();

        }

        private void HomePageButton_Click(object? sender, EventArgs e)
        {
            this.Hide();
            Program.store.ShowHomePage(this);
        }

        private void UsersButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            UsersForm userForms = (UsersForm)new UsersForm().SetFormProperties(this);
            userForms.Show();
            userForms.Focus();
        }
    }
}
