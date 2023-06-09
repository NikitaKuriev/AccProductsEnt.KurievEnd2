using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class AccountCardService : IAccountCardService
    {
        private readonly ApplicationDbContext _context;

        public AccountCardService(ApplicationDbContext context)
        {
            _context = context;
        }

      

        public void AddAccountCard(AccountCard newAccountCard)
        {
            _context.AccountCards.Add(newAccountCard);
            _context.SaveChanges();
        }

        public List<AccountCard> GetAccountCardsAll()
        {
            return _context.AccountCards
                .Where(ac => ac.IsDeleted == false)
                .ToList();
        }
    }
}
