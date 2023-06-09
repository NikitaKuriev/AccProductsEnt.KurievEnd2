using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class ClientSevice : IClientService
    {
        private readonly ApplicationDbContext _context;

        public ClientSevice(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddClient(Client newClient)
        {
            _context.Clients.Add(newClient);
            _context.SaveChanges();
        }

        public List<Client> GetClientsAll()
        {
            return _context.Clients
                .Where(c => c.IsDeleted == false)
                .ToList();
        }
    }
}
