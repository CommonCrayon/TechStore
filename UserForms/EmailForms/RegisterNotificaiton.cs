using store;
using Store.Structs;

namespace Store.UserForms.EmailForms
{
    public partial class RegisterNotificaiton : Form
    {
        UserData userData;
        public RegisterNotificaiton(UserData userData)
        {
            InitializeComponent();

            this.userData = userData;

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            EmailSender.SendRegisterNotification(userData, textBox1.Text.ToString().Trim());
            this.Dispose();
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
