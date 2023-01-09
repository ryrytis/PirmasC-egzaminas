namespace Egzas1017
{
    public class Material2Repository
    {
        public List<Material2> materials2 { get; set; }

        public Material2Repository()
        {
            materials2.Add(new Material2(1, "EVA45", "black", 45, 5.50));
            materials2.Add(new Material2(2, "EVA35", "black", 35, 4.50));
            materials2.Add(new Material2(3, "EVA55", "black", 55, 7.50));
            materials2.Add(new Material2(4, "EVA35/55", "black", 0, 9.95));

        }
        public List<Material2> Retrieve()
        {
            return materials2;
        }
        public double GetMaterialProce2byId(int materialAxCode)
        {
            return materials2.SingleOrDefault(x => x.AxCode == materialAxCode).Price;
        }

        public int CalculatePriceSecondMaterial(int material2Quantity, int material2Price)
        {
            return material2Price * material2Quantity;
        }
    }
}
