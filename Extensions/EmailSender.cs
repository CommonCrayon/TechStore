using Store.Structs;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;


namespace store
{
    // Class responsible for sending email notifications
    class EmailSender
    {
        // Private fields to store SMTP server information
        private readonly string smtpServer = "smtp.gmail.com";
        private readonly int smtpPort = 587;
        private readonly string smtpUsername = "hospitalsystem565@gmail.com";
        private readonly string smtpPassword;

        // Constructor to initialize SMTP server details
        public EmailSender()
        {
            this.smtpPassword = File.ReadAllLines("SMTPPasword.txt").FirstOrDefault() ?? "NULL";
        }

        // Method to send an email, receives the email address, message subject and body as strings
        public void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                using (var client = new SmtpClient(smtpServer))
                {
                    client.Port = smtpPort;
                    client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    var message = new MailMessage
                    {
                        From = new MailAddress(smtpUsername),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    };

                    message.To.Add(toEmail);

                    client.Send(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }

        public static void SendRegisterNotification(UserData userData, string emailToSendTo)
        {
            Debug.WriteLine("Sending email to: " + emailToSendTo);

            EmailSender emailSender = new EmailSender();

            string Subject = "Registration Notification";
            string Body = $"Dear {userData.FirstName} {userData.LastName},<br /><br />" +
                $"We have emailed you to notify you that you have registered to TechStore!<br />" +
                $"Your Details<br />" +
                $"User Id: {userData.UserId}<br />" +
                $"Username: {userData.UserName}<br />" +
                $"First Name: {userData.FirstName}<br />" +
                $"Last Name: {userData.LastName}<br />" +
                $"Phone Number: {userData.PhoneNumber}<br />" +
                $"Email: {userData.Email}<br /><br />" +
                $"Best Regards,<br />TechStore";


            emailSender.SendEmail(emailToSendTo, Subject, Body);
        }

        public static void SendForgotPasswordEmail(UserData userData, string emailToSendTo)
        {
            Debug.WriteLine("Sending email to: " + emailToSendTo);

            EmailSender emailSender = new EmailSender();

            string Subject = "Forgot Password";
            string Body = $"Dear {userData.FirstName} {userData.LastName},<br /><br />" +
                "We have emailed you because you have forgotten your password to TechStore. <br />" +
                "Your Details<br />" +
                $"User Id: {userData.UserId}<br />" +
                $"Username: {userData.UserName}<br />" +
                $"Password: {userData.Password}<br />" +
                $"<br />" +
                $"(This is only for Debugging purposes. In a larger scope this process would be more sophisticated.)<br />" +
                "Best Regards,<br />TechStore";


            emailSender.SendEmail(emailToSendTo, Subject, Body);
        }

        public static void SendPasswordResetEmail(UserData userData, string emailToSendTo)
        {
            Debug.WriteLine("Sending email to: " + emailToSendTo);

            EmailSender emailSender = new EmailSender();

            string Subject = "Forgot Password";
            string Body = $"Dear {userData.FirstName} {userData.LastName},<br /><br />" +
                "We have emailed you because you want to reset your password for TechStore. <br />" +
                "Your Details<br />" +
                $"User Id: {userData.UserId}<br />" +
                $"Username: {userData.UserName}<br /><br />" +
                $"Your Current Password is this: {userData.Password}<br />" +
                "Follow the link to change your password: (This is only for Debugging purposes. In a larger scope, this process would involve a link.)<br />" +
                "<br />Best Regards,<br />TechStore";


            emailSender.SendEmail(emailToSendTo, Subject, Body);
        }
    }
}