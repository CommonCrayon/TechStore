namespace Store.Structs
{
    public struct ItemData
    {
        public ItemCategories itemCategory;
        public string itemId;
        public string itemName;
        public double itemPrice;
        public string itemDescription;

        public ItemData(int itemCategories, string itemId, string itemName, double itemPrice, string itemDesc)
        {
            this.itemCategory = (ItemCategories)Enum.ToObject(typeof(ItemCategories), itemCategories); ;
            this.itemId = itemId;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemDescription = itemDesc;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(itemId) && string.IsNullOrEmpty(itemName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
