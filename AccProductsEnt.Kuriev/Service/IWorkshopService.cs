using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IWorkshopService
    {
        public void AddWorkshop(Workshop workshop);
        public List<Workshop> GetAllWorkshop();

    }
}
