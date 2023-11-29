using Store.Structs;

namespace Store.UserForms.CustomerSubForms
{
    public partial class OrderFinalization : Form
    {
        public OrderFinalization()
        {
            InitializeComponent();

            FormClosing += Program.store.CloseEnvironment;
            BackButton.Click += BackButton_Click;
            confirmButton.Click += ConfirmButton_Click;

            OrderData orderData = Program.store.dataParser.customerOrderData;

            orderIdLabel.Text = "Order Id:\n" + orderData.orderId.ToString();
            totalPriceLabel.Text = "Total Price:\n" + orderData.price.ToString("C");
            totalItemsLabel.Text = "Total Quantity:\n" + orderData.quantity.ToString();

            string fullText =
                "User Information" + Environment.NewLine +
                "User Id: " + orderData.userData.UserId + Environment.NewLine +
                "Username: " + orderData.userData.UserName + Environment.NewLine +
                "First Name: " + orderData.userData.FirstName + Environment.NewLine +
                "Last Name: " + orderData.userData.LastName + Environment.NewLine +
                Environment.NewLine +
                "Contact Information: " + Environment.NewLine +
                "Email: " + orderData.userData.Email + Environment.NewLine +
                "Phone Number: " + orderData.userData.PhoneNumber + Environment.NewLine +
                Environment.NewLine +
                "Payment Information: " + Environment.NewLine +
                "Name on Card: " + orderData.paymentInformation.name + Environment.NewLine +
                "Card Number: " + orderData.paymentInformation.number + Environment.NewLine +
                "Expiry Date: " + orderData.paymentInformation.expiryDate + Environment.NewLine +
                "Security Code: " + orderData.paymentInformation.securityCode + Environment.NewLine +
                "Postcode: " + orderData.paymentInformation.postCode + Environment.NewLine +
                Environment.NewLine;

            if (orderData.isDelivery)
            {
                fullText +=
                    "Shipping Information: " + Environment.NewLine +
                    "Street Address: " + orderData.shippingInformation.streetAddress + Environment.NewLine +
                    "City: " + orderData.shippingInformation.city + Environment.NewLine +
                    "State: " + orderData.shippingInformation.state + Environment.NewLine +
                    "Postcode: " + orderData.shippingInformation.postCode + Environment.NewLine +
                    "Country: " + orderData.shippingInformation.country + Environment.NewLine +
                    Environment.NewLine;
            }

            fullText += "Order Items:" + Environment.NewLine;

            foreach (CustomerCartItem item in orderData.customerCartItems)
            {
                ItemData itemData = Program.store.dataParser.GetItemById(item.itemid.ToString());
                fullText +=
                    "Item Id: " + itemData.itemId + Environment.NewLine +
                    "Item Name: " + itemData.itemName + Environment.NewLine +
                    "Item Quantity: " + item.itemQuantity + Environment.NewLine +
                    "Item Price: " + (itemData.itemPrice * item.itemQuantity).ToString("C") + Environment.NewLine + Environment.NewLine;
            }

            fullText += $"==================================={Environment.NewLine}" +
                        $"Order Id: {orderData.orderId}{Environment.NewLine}" +
                        $"Total Price: {orderData.price:C}{Environment.NewLine}" +
                        $"Total Quantity: {orderData.quantity}{Environment.NewLine}" +
                        $"==================================={Environment.NewLine}";


            textBox1.Text = fullText;
        }

        private void ConfirmButton_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Purchase?", "Confirm Purchase", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                Program.store.dataParser.AddOrder(Program.store.dataParser.customerOrderData);
                Program.store.dataParser.ClearCart();

                this.Hide();
                Program.store.ShowHomePage(this);
            }

        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            Checkout checkout = (Checkout)new Checkout().SetFormProperties(this);
            checkout.Show();
            checkout.Focus();
        }
    }
}
