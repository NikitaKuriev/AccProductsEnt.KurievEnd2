using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IAccountingService
    {
        public void AddAccounting(Accounting newAccounting);
        public List<Accounting> GetAllAccounts();
    }
}
