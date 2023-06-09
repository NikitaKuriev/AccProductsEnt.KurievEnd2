using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class ImplementationsService : IImplementationsService
    {
        private readonly ApplicationDbContext _context;

        public ImplementationsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddImplementations(Implementation newImplementation)
        {
            _context.Implementations.Add(newImplementation);
            _context.SaveChanges();
        }

        public List<Implementation> GetImplementationsAll()
        {
           return _context.Implementations
                .Where(i => i.IsDeleted == false)
                .ToList();
        }
    }
}
