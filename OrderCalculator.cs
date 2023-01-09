using System.Diagnostics;
using System.Reflection;

namespace Egzas1017
{
    public class OrderCalculator
    {
        public int PricePerFirstMaterial;
        public int PricePerSecondMaterial;

        public OrderCalculator()
        {}
        public OrderCalculator(int pricePerFirstMaterial, int pricePerSecondMaterial)
        {
            PricePerFirstMaterial = pricePerFirstMaterial;
            PricePerSecondMaterial = pricePerSecondMaterial;
        }
        
        public OrderCalculator(FwModel model)
        {
            var material1Id = model.material1Id;
            var material2Id = model.material2Id;
            var material1usage = model.Material1Usage;
            var material2usage = model.Material2Usage;

            Material1Repository material1Repository = new Material1Repository();
            Material2Repository material2Repository = new Material2Repository();

            /*material1Repository.GetMaterialPrice1byId(material1Id);
            material2Repository.GetMaterialProce2byId(material2Id);*/

            var pricePerFirstMaterial = material1usage * material1Repository.GetMaterialPrice1byId(material1Id);
            var pricePerSecondMaterial = material2usage * material2Repository.GetMaterialProce2byId(material2Id);

        }
        
        /*        public OrderMaterialPrices CalculatePrice()
                {
                    return material1usage * material1Repository.GetMaterialPrice1byId(material1Id);
                    return = material2usage * material2Repository.GetMaterialProce2byId(material2Id);
                }*/
    }
}
