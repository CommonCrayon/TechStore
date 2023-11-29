using Store.UserForms.StaffSubForms;

namespace Store.UserForms
{
    public partial class PackagerForm : Form
    {
        public PackagerForm()
        {
            InitializeComponent();

            PersonalDetailsButton.TabIndex = 0;
            OrderButton.TabIndex = 1;
            ItemsButton.TabIndex = 2;
            LogOutButton.TabIndex = 3;

            nameLabel.Text = $"{Program.store.userData.FirstName} {Program.store.userData.LastName}";

            PersonalDetailsButton.Click += PersonalDetailsButton_Click;
            LogOutButton.Click += LogOutButton_Click;
            ItemsButton.Click += ItemsButton_Click;
            OrderButton.Click += OrderButton_Click;

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
            this.Dispose();

            Program.store.SetUserData(new Structs.UserData());
            Program.store.ShowHomePage(this);
        }

        private void PersonalDetailsButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            PersonalDetails personalDetails = (PersonalDetails)new PersonalDetails().SetFormProperties(this);
            personalDetails.Show();
            personalDetails.Focus();

        }
    }
}
