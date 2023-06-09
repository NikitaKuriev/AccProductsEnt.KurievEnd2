using AccProductsEnt.Kuriev.Entities;
using System.Security.Policy;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IPriceListService
    {
        public void AddPriceList(PriceList newPriceList);
        public List<PriceList> GetAllPriceList();
    }
}
