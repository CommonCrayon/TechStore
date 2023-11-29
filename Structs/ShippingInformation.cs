namespace Store.Structs
{
    public struct ShippingInformation
    {
        public string streetAddress;
        public string city;
        public string state;
        public string postCode;
        public string country;

        public ShippingInformation(string streetAdress, string city, string state, string postCode, string country)
        {
            this.streetAddress = streetAdress;
            this.city = city;
            this.state = state;
            this.postCode = postCode;
            this.country = country;
        }
    }
}
