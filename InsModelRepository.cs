namespace Egzas1017
{
    public class InsModelRepository
    {
       public List<InsModel> insModels { get; set; } = new List<InsModel>();

        public InsModelRepository()
        {
            insModels.Add(new InsModel(2, "full", "description1", 5, 6, 2, 4));
            insModels.Add(new InsModel(3, "3/4", "description2", 2, 2, 1, 1));
            insModels.Add(new InsModel(4, "Full lenght", "description3", 9, 9, 3, 1));
            insModels.Add(new InsModel(4, "Full lenght", "description4", 4, 8, 2, 2));
        }


        public List<InsModel> Retrieve()
        {
            return insModels;
        }
        public InsModel RetrieveIds(int insModelId)
        {
            return insModels.SingleOrDefault(x => x.Id == insModelId);
        }
    }
}
