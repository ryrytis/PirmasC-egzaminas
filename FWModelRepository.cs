namespace Egzas1017
{
    public class FWModelRepository
    {
        public List<FwModel> fwModels { get; set; } = new List<FwModel>();

        public FWModelRepository()
        {
            fwModels.Add(new FwModel(1, FWModelsCatalogue.Roma, "winter boots", 10, 30, 250, 2, 3));
            fwModels.Add(new FwModel(2, FWModelsCatalogue.Milan, "sandals", 5, 15, 70, 3, 4));
            fwModels.Add(new FwModel(3, FWModelsCatalogue.Paris, "sandals", 7, 18, 70, 1, 1));
            fwModels.Add(new FwModel(4, FWModelsCatalogue.Viena, "summer shoes", 14, 25, 170, 3, 2));
        }
        public List<FwModel> Retrieve()
        {
            return fwModels;
        }
        public FwModel RetrieveIds(int fwModelId)
        {
            return fwModels.SingleOrDefault(x => x.Id == fwModelId);
        }
    }
}
