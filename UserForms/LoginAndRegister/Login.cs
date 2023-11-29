using Store.Structs;
using Store.UserForms;
using Store.UserForms.EmailForms;
using Store.UserMenus;

namespace Store
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            FormClosing += Program.store.CloseEnvironment;
            BackButton.Click += BackButton_Click;

            LoginSubmitButton.Click += LoginSubmitButton_Click;
            ForgotPasswordButton.Click += ForgotPasswordButton_Click;
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            this.Hide();
            Program.store.ShowHomePage(this);
        }

        private void LoginSubmitButton_Click(object? sender, EventArgs e)
        {
            UserData userData = Program.store.dataParser.CheckLogin(textBox1.Text.ToString(), textBox2.Text.ToString());

            if (userData.UserId != null)
            {
                Program.store.SetUserData(userData);

                MessageBox.Show($"Login Success!\nWelcome {userData.FirstName} {userData.LastName}.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (userData.UserRole == UserRoles.Admin)
                {
                    AdminForm adminForm = (AdminForm)new AdminForm().SetFormProperties(this);
                    adminForm.Show();
                    adminForm.Focus();
                }
                else if (userData.UserRole == UserRoles.Employee)
                {
                    EmployeeForm employeeForm = (EmployeeForm)new EmployeeForm().SetFormProperties(this);
                    employeeForm.Show();
                    employeeForm.Focus();
                }
                else if (userData.UserRole == UserRoles.Customer)
                {
                    Program.store.ShowHomePage(this);
                }
                else if (userData.UserRole == UserRoles.Packager)
                {
                    PackagerForm packagerForm = (PackagerForm)new PackagerForm().SetFormProperties(this);
                    packagerForm.Show();
                    packagerForm.Focus();
                }
                return;
            }


            MessageBox.Show("Incorrect Login Details", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ForgotPasswordButton_Click(object? sender, EventArgs e)
        {
            ForgotPassword forgotPassword = (ForgotPassword)new ForgotPassword().SetDialogProperties();
            forgotPassword.ShowDialog();
        }
    }
}
