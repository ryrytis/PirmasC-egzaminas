namespace Egzas1017
{
    public class FwModel
    {
        public int Id { get; set; }
        public FWModelsCatalogue ModelName { get; set; }
        public string Description { get; set; }
        public int Material1Usage { get; set; }
        public int Material2Usage { get; set; }
        public int Height { get; set; }
        public int material1Id { get; set; }
        public int material2Id { get; set; }
  
        public FwModel(int id, FWModelsCatalogue modelName, string description, int material1Usage, int material2Usage, int height, int material1Id, int material2Id)
        {
            Id = id;
            ModelName = modelName;
            Description = description;
            Material1Usage = material1Usage;
            Material2Usage = material2Usage;
            Height = height;
            this.material1Id = material1Id;
            this.material2Id = material2Id;
        }

    }
}
