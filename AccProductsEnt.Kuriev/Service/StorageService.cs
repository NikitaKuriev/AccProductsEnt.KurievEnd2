using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class StorageService : IStorageService
    {
        private readonly ApplicationDbContext _context;

        public StorageService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddStorage(Storage storage)
        {
            _context.Storages.Add(storage);
            _context.SaveChanges();
        }

        public List<Storage> GetStoragesAll()
        {
            return _context.Storages
                .Where(s => s.IsDeleted == false)
                .ToList();
        }
    }
}
