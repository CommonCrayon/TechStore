namespace Store.Structs
{
    public struct CustomerCartItem
    {
        public int itemid;
        public int itemQuantity;

        public CustomerCartItem(int itemid, int itemQuantity)
        {
            this.itemid = itemid;
            this.itemQuantity = itemQuantity;
        }
    }
}
