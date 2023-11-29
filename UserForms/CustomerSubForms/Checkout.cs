using Store.Statics;
using Store.Structs;
using Store.UserForms.CustomerSubForms;

namespace Store.UserForms
{
    public partial class Checkout : Form
    {
        private OrderData orderData;

        public Checkout()
        {
            InitializeComponent();

            FormClosing += Program.store.CloseEnvironment;
            BackButton.Click += BackButton_Click;

            deliverCheckoutButton.Click += DeliverCheckoutButton_Click;
            pickupCheckoutButton.Click += PickupCheckoutButton_Click;

            orderData = Program.store.dataParser.GetCustomerOrderData();

            totalPriceLabel.Text = "Total Price: " + orderData.price.ToString("C");
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            this.Hide();

            StoreCart storeCart = (StoreCart)new StoreCart().SetFormProperties(this);
            storeCart.Show();
            storeCart.Focus();
        }

        private void DeliverCheckoutButton_Click(object? sender, EventArgs e)
        {
            string name = deliverPMname.Text.ToString().Trim();
            string cardNumber = deliverPMNumber.Text.ToString().Trim();
            string expiryDate = deliverPMexpiry.Text.ToString().Trim();
            string securityCodeText = deliverPMSecurity.Text;
            string postCodeText = deliverSAPostcode.Text;

            if (!Validation.ValidateNameOnCard(name))
            {
                MessageBox.Show("Invalid Name on Card", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!Validation.ValidateCardNumber(cardNumber))
            {
                MessageBox.Show("Invalid Card Number", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!Validation.ValidateExpiryDate(expiryDate))
            {
                MessageBox.Show("Invalid Expiry Date", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!int.TryParse(securityCodeText, out int securityCode) || !Validation.ValidateSecurityCode(securityCodeText))
            {
                MessageBox.Show("Invalid Security Code", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!int.TryParse(postCodeText, out int postCode) || !Validation.ValidatePostCode(postCodeText))
            {
                MessageBox.Show("Invalid Postcode", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                orderData.SetPaymentInformation(new PaymentInformation(name, cardNumber, expiryDate, Convert.ToInt32(securityCodeText), Convert.ToInt32(postCodeText)));
            }



            string address = deliverSAAddress.Text.ToString().Trim();
            string city = deliverSACity.Text.ToString().Trim();
            string state = deliverSAState.Text.ToString().Trim();
            string shippingPostcode = deliverSAPostcode.Text.ToString().Trim();
            string country = deliverSACountry.Text.ToString().Trim();

            if (!Validation.ValidateAddress(address))
            {
                MessageBox.Show("Invalid Address", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!Validation.ValidateCity(city))
            {
                MessageBox.Show("Invalid City", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!Validation.ValidateState(state))
            {
                MessageBox.Show("Invalid State", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!Validation.ValidatePostCode(shippingPostcode))
            {
                MessageBox.Show("Invalid Shipping Postcode", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!Validation.ValidateCountry(country))
            {
                MessageBox.Show("Invalid Country", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                orderData.SetisDelivery(true);
                orderData.SetShippingInformation(new ShippingInformation(address, city, state, shippingPostcode, country));
            }

            Program.store.dataParser.SetCustomerOrderData(orderData);

            this.Hide();

            OrderFinalization orderFinalization = (OrderFinalization)new OrderFinalization().SetFormProperties(this);
            orderFinalization.Show();
            orderFinalization.Focus();
        }

        private void PickupCheckoutButton_Click(object? sender, EventArgs e)
        {
            string name = pickupCardName.Text.ToString().Trim();
            string cardNumber = pickupNumber.Text.ToString().Trim();
            string expiryDate = pickupExpiry.Text.ToString().Trim();
            string securityCodeText = pickupSecurity.Text;
            string postCodeText = pickupPostcode.Text;

            if (!Validation.ValidateNameOnCard(name))
            {
                MessageBox.Show("Invalid Name on Card", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!Validation.ValidateCardNumber(cardNumber))
            {
                MessageBox.Show("Invalid Card Number", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!Validation.ValidateExpiryDate(expiryDate))
            {
                MessageBox.Show("Invalid Expiry Date", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!int.TryParse(securityCodeText, out int securityCode) || !Validation.ValidateSecurityCode(securityCodeText))
            {
                MessageBox.Show("Invalid Security Code", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else if (!int.TryParse(postCodeText, out int postCode) || !Validation.ValidatePostCode(postCodeText))
            {
                MessageBox.Show("Invalid Postcode", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                orderData.SetisDelivery(false);
                orderData.SetPaymentInformation(new PaymentInformation(name, cardNumber, expiryDate, Convert.ToInt32(securityCodeText), Convert.ToInt32(postCodeText)));
            }

            Program.store.dataParser.SetCustomerOrderData(orderData);

            this.Hide();

            OrderFinalization orderFinalization = (OrderFinalization)new OrderFinalization().SetFormProperties(this);
            orderFinalization.Show();
            orderFinalization.Focus();
        }
    }
}
