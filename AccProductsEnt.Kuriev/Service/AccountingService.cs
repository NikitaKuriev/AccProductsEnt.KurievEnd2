using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class AccountingService : IAccountingService
    {
        private readonly ApplicationDbContext _context;

        public AccountingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddAccounting(Accounting accounting)
        {
            _context.Accountings.Add(accounting);
            _context.SaveChanges();
        }

        public List<Accounting> GetAllAccounts()
        {
          return _context.Accountings
                .Where(ac => ac.IsDeleted == false)
                .ToList();

        }
    }
}
