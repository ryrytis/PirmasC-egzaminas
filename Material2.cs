using System.Diagnostics;

namespace Egzas1017
{
    public class Material2
    {
        public int AxCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Hardness { get; set; }
        public double Price { get; set; }

        public Material2(int axCode, string itemName, string description, int hardness, double price)
        {
            AxCode = axCode;
            ItemName = itemName;
            Description = description;
            Hardness = hardness;
            Price = price;
        }


    }
}
