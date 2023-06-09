using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Pages;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IProductService
    {
        public void AddProduct (Product newProduct);

        public void RemoveProduct (int productId);

        public void UpdateProduct (int productId,Product newProduct);

        public List<Product> GetProduct (string productName);
        public List<Product> SortProductName();
        public List<Product> SortPriceProduct();
        public List<Product> SortDateManufactureProduct();
        public List<Product> GetAllProducts ();
        public IEnumerable<Product> GetProductsById(int productId);

    }
}
