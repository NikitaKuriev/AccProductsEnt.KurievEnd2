using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Pages;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IProductService
    {
        public void AddProduct (Product newProduct);

        public void RemoveProduct (string productName);

        public void UpdateProduct (string productName,Product newProduct);

        public List<Product> GetProduct (string productName);
        public List<Product> SortProductName();
        public List<Product> SortPriceProduct();
        public List<Product> SortDateManufactureProduct();
        public List<Product> GetAllProducts ();
    }
}
