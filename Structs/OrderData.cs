namespace Store.Structs
{
    public struct OrderData
    {
        //dataset: //userid,orderid,price,quantity,orderComplete,isDelivery,streetAddress,city,state,postcode,country,itemid,itemquantity

        public int orderId;
        public double price;
        public int quantity;
        public bool orderComplete = false;

        public UserData userData;

        public List<CustomerCartItem> customerCartItems = new List<CustomerCartItem>();

        public bool isDelivery = true;
        public PaymentInformation paymentInformation;
        public ShippingInformation shippingInformation;

        public OrderData(UserData userData, int orderId, double price, int quantity, bool orderComplete, bool isDelivery, PaymentInformation paymentInformation, ShippingInformation shippingInformation, List<CustomerCartItem> customerCartItems)
        {
            this.userData = userData;
            this.orderId = orderId;
            this.price = price;
            this.quantity = quantity;
            this.orderComplete = orderComplete;
            this.isDelivery = isDelivery;
            this.paymentInformation = paymentInformation;
            this.shippingInformation = shippingInformation;
            this.customerCartItems = customerCartItems;

        }

        public OrderData(int orderId, UserData user, double price, int quantity, List<CustomerCartItem> customerCartItems)
        {
            this.orderId = orderId;
            this.userData = user;
            this.price = price;
            this.quantity = quantity;

            this.customerCartItems = customerCartItems;

            this.paymentInformation = new PaymentInformation();
            this.shippingInformation = new ShippingInformation();
        }

        public void SetPaymentInformation(PaymentInformation paymentInformation)
        {
            this.paymentInformation = paymentInformation;
        }

        public void SetShippingInformation(ShippingInformation shippingInformation)
        {
            this.shippingInformation = shippingInformation;
        }

        public void SetisDelivery(bool isDelivery)
        {
            this.isDelivery = isDelivery;
        }
    }
}
