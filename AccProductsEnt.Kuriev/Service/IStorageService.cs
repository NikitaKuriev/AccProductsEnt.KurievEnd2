using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IStorageService
    {
        public void AddStorage (Storage storage);

        public List<Storage> GetStoragesAll ();

    }
}
