namespace Egzas1017
{
    public class OrderMaterialPrices
    {
        public int PricePerFirstMaterial { get; set; }
        public int PricePerSecondMaterial { get; set; }
        
        public OrderMaterialPrices(double pricePerFirstMaterial, double pricePerSecondMaterial)
        {
           PricePerFirstMaterial = PricePerFirstMaterial;
           PricePerSecondMaterial = PricePerSecondMaterial;
        }

        
    }
}
