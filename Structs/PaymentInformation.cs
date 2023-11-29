namespace Store.Structs
{
    public struct PaymentInformation
    {
        public string name;
        public string number;
        public string expiryDate;
        public int securityCode;
        public int postCode;

        public PaymentInformation(string name, string number, string expiryDate, int securityCode, int postCode)
        {
            this.name = name;
            this.number = number;
            this.expiryDate = expiryDate;
            this.securityCode = securityCode;
            this.postCode = postCode;
        }
    }
}
