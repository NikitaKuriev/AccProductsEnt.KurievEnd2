using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IOrderService
    {
        public void AddOrder(Order newOrder);
        public List<Order> GetOrdersAll();
    }
}
