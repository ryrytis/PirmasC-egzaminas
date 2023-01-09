namespace Egzas1017
{
    public class Material1Repository
    {
        public List<Material1> materials1 { get; set; }

        public Material1Repository()
        {
            materials1.Add(new Material1(1, "On-Steam", "blue", 5.50));
            materials1.Add(new Material1(2, "ArneDry", "green", 8.66));
            materials1.Add(new Material1(3, "On-Steam", "grey", 5.88));
            materials1.Add(new Material1(4, "Leather", "black", 4.26));
        }
        public List<Material1> Retrieve()
        {
            return materials1;
        }
        public double GetMaterialPrice1byId(int materialAxCode)
        {
            return materials1.SingleOrDefault(x => x.AxCode == materialAxCode).Price;
        }


        public int CalculatePriceFirstMaterial(int material1Quantity, int material1Price)
        {
            return material1Price * material1Quantity;
        }
    }
}
