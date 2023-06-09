using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IProviderService
    {
        public void AddProvider(Provider provider);
        public List<Provider> GetAllProviders();
    }
}
