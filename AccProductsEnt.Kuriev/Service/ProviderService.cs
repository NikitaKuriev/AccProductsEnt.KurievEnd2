using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class ProviderService : IProviderService
    {
        private readonly ApplicationDbContext _context;

        public ProviderService(ApplicationDbContext context)
        {
            _context = context;
        }



        public void AddProvider(Provider newProvider)
        {
            _context.Providers.Add(newProvider);
            _context.SaveChanges();
        }

        public List<Provider> GetAllProviders()
        {
            return _context.Providers
                .Where(p => p.IsDeleted == false)
                .ToList();
        }
    }
}
