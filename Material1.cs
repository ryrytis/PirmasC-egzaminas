namespace Egzas1017
{
    public class Material1
    {
        public int AxCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Material1(int axCode, string itemName, string description, double price)
        {
            AxCode = axCode;
            ItemName = itemName;
            Description = description;
            Price = price;
        }

        
    }
}
