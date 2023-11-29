using Store.LoginAndRegister;

namespace Store
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();

            FormClosing += Program.store.CloseEnvironment;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = (Login)new Login().SetFormProperties(this);
            login.Show();
            login.Focus();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = (Register)new Register().SetFormProperties(this);
            register.Show();
            register.Focus();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.store.ShowHomePage(this);
        }
    }
}
