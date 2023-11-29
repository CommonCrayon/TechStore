using Store.Statics;
using Store.Structs;
using Store.UserForms.EmailForms;
using Store.UserMenus;

namespace Store.UserForms
{
    public partial class PersonalDetails : Form
    {
        private UserData userData;
        public PersonalDetails()
        {
            InitializeComponent();

            userData = Program.store.GetUserData();

            InitializeUserData();

            FormClosing += Program.store.CloseEnvironment;

            BackButton.Click += BackButton_Click;
            cancelButton.Click += CancelButton_Click;
            applyButton.Click += ApplyButton_Click;
        }

        private void InitializeUserData()
        {
            userRoleTextBox.Text = userData.UserRole.ToString();
            useridTextBox.Text = userData.UserId.ToString();
            usernameTextBox.Text = userData.UserName.ToString();
            firstNameTextBox.Text = userData.FirstName.ToString();
            lastNameTextBox.Text = userData.LastName.ToString();
            emailTextBox.Text = userData.Email.ToString();
            phoneTextBox.Text = userData.PhoneNumber.ToString();
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            InitializeUserData();
        }
        private void ApplyButton_Click(object? sender, EventArgs e)
        {
            // Validate different fields with their respective inputs
            bool isFirstNameValid = Validation.ValidateName(firstNameTextBox.Text.ToString().Trim());
            bool isLastNameValid = Validation.ValidateName(lastNameTextBox.Text.ToString().Trim());
            bool isPhoneNumberValid = Validation.ValidatePhoneNumber(phoneTextBox.Text.ToString().Trim());
            bool isEmailValid = Validation.ValidateEmail(emailTextBox.Text.ToString().Trim());

            if (isFirstNameValid && isLastNameValid && isPhoneNumberValid && isEmailValid)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to apply changes?", "Apply Changes", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    UserData newUser = new UserData(
                        Convert.ToInt32(Enum.Parse<UserRoles>(userRoleTextBox.Text)),
                        useridTextBox.Text.ToString().Trim(),
                        usernameTextBox.Text.ToString().Trim(),
                        userData.Password.ToString().Trim(),
                        firstNameTextBox.Text.ToString().Trim(),
                        lastNameTextBox.Text.ToString().Trim(),
                        emailTextBox.Text.ToString().Trim(),
                        phoneTextBox.Text.ToString().Trim()
                        );

                    Program.store.dataParser.EditUser(newUser);
                }
            }
            else
            {
                if (!isFirstNameValid)
                    MessageBox.Show("First Name is not Valid.\nName should not be empty and should only contain letters.", "Validation Error", MessageBoxButtons.OK);
                else if (!isLastNameValid)
                    MessageBox.Show("Last Name is not Valid.\nName should not be empty and should only contain letters.", "Validation Error", MessageBoxButtons.OK);
                else if (!isPhoneNumberValid)
                    MessageBox.Show("Phone Number is not Valid.", "Validation Error", MessageBoxButtons.OK);
                else if (!isEmailValid)
                    MessageBox.Show("Email is not Valid.", "Validation Error", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Validation Error", "Validation Error", MessageBoxButtons.OK);
            }
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            if (Program.store.userData.UserRole == UserRoles.Admin)
            {
                this.Hide();

                AdminForm adminForm = (AdminForm)new AdminForm().SetFormProperties(this);
                adminForm.Show();
                adminForm.Focus();
            }
            else if (Program.store.userData.UserRole == UserRoles.Employee)
            {
                this.Hide();

                EmployeeForm employeeForm = (EmployeeForm)new EmployeeForm().SetFormProperties(this);
                employeeForm.Show();
                employeeForm.Focus();
            }
            else if (Program.store.userData.UserRole.Equals(UserRoles.Packager))
            {
                this.Hide();

                PackagerForm form = (PackagerForm)new PackagerForm().SetFormProperties(this);
                form.Show();
                form.Focus();
            }
            else if (Program.store.userData.UserRole == UserRoles.Customer)
            {
                this.Hide();
                Program.store.ShowHomePage(this);
            }
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = (ForgotPassword)new ForgotPassword(userData).SetDialogProperties();
            forgotPassword.ShowDialog();
        }
    }
}
