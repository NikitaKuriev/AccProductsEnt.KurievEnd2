using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IClientService
    {
        public void AddClient(Client newClient);
        public List<Client> GetClientsAll();
    }
}
