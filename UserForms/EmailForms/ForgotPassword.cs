using store;
using Store.Structs;

namespace Store.UserForms.EmailForms
{
    public partial class ForgotPassword : Form
    {
        UserData userData;
        public ForgotPassword()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        public ForgotPassword(UserData userData)
        {
            InitializeComponent();

            Text = "Password Reset";
            SubTitleLabel.Text = "Password Reset Email";

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            this.userData = userData;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            if (this.userData.IsValid())
            {
                EmailSender.SendPasswordResetEmail(this.userData, textBox1.Text.ToString().Trim());
                this.Dispose();
            }
            else
            {
                UserData userData = Program.store.dataParser.GetUserDataByEmail(textBox1.Text.ToString().Trim());

                EmailSender.SendForgotPasswordEmail(userData, textBox1.Text.ToString().Trim());
                this.Dispose();
            }

        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
