namespace Egzas1017
{
    public class OrderList
    {
        public  string ClientName { get; set; }
        public int Id { get; set; }
        public FWModelsCatalogue ModelName { get; set; }
        public string Description { get; set; }
        public int Materia1Usage { get; set; }
        public int Materia2Usage { get; set; }
        public int Height { get; set; }
        public int material1Id { get; set; }
        public int material2Id { get; set; }
        public double PricePerFirstMaterial { get; set; }
        public double PricePerSecondMaterial { get; set; }
        private List<OrderList> Orders { get; set; }

        public OrderList(string klientas, FWModelsCatalogue modelName, string description, int material1Usage, int material2Usage, int height, int material1Id, int material2Id)//OrderListMaterialPrices, double OrderCalculator.pricePerSecondMaterial)
        {
            ClientName = klientas;
            ModelName = modelName;
            Description = description;
            Materia1Usage = material1Usage;
            Materia2Usage = material2Usage;
            Height = height;
            this.material1Id = material1Id;
            this.material2Id = material2Id;
/*            PricePerFirstMaterial = OrderCalculator.pricePerFirstMaterial;
            PricePerSecondMaterial = OrderCalculator.pricePerSecondMaterial;*/

        }
        public OrderList(string klientas, int id, string description, int material1Usage, int material2Usage, int material1Id, int material2Id)//OrderListMaterialPrices, double OrderCalculator.pricePerSecondMaterial)
        {
            ClientName = klientas;
            Id = id;
            Description = description;
            Materia1Usage = material1Usage;
            Materia2Usage = material2Usage;
            this.material1Id = material1Id;
            this.material2Id = material2Id;
            /*            PricePerFirstMaterial = OrderCalculator.pricePerFirstMaterial;
                        PricePerSecondMaterial = OrderCalculator.pricePerSecondMaterial;*/

        }

        public void Save(OrderList oneOrder)
        {
            Orders.Add(oneOrder);
        }
        public OrderList()
        {
        }
    }
}

