using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IRawService
    {
        public void AddRaw(Raw newRaw);

        public void RemoveRaw(string rawName);

        public void UpdateRaw(string rawName , Raw newRaw);

        public Raw GetRaw(string rawName);

        public List<Raw> GetAllRaws();
    }
}
