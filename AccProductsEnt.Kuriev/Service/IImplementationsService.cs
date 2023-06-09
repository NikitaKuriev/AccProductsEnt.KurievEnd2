using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IImplementationsService
    {
        public void AddImplementations(Implementation newImplementation);
        public List<Implementation> GetImplementationsAll();
    }
}
