namespace Egzas1017
{
    public class InsModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Material1Usage { get; set; }
        public int Material2Usage { get; set; }
        public int material1Id { get; set; }
        public int material2Id { get; set; }


        public InsModel(int id, string type, string description, int material1Usage, int material2Usage, int material1Id, int material2Id)
        {
            Id = id;
            Type = type;
            Description = description;
            Material1Usage = material1Usage;
            Material2Usage = material2Usage;
            this.material1Id = material1Id;
            this.material2Id = material2Id;

        }

        
    }
}
