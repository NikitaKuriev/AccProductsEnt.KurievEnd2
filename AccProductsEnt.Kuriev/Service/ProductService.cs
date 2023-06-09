using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;
using Microsoft.CodeAnalysis;

namespace AccProductsEnt.Kuriev.Service
{
    public class  ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
              _context = context;
        }
        public void AddProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products
                .Where(p => p.IsDeleted == false)
                .ToList();
        }

        public List<Product> GetProduct(string productName)
        {
           return _context.Products
                .Where(pr => pr.IsDeleted == false && pr.ProductName == productName)
                .ToList() ;
        }


        public IEnumerable<Product> GetProductsById(int productId)
        {
            return _context.Products
                .Where(pr => pr.IsDeleted == false && pr.Id == productId)
                .ToList();
        }

        public void RemoveProduct(int productId)
        {
            var products = _context.Products
                .Where(product => product.Id == productId)
                .FirstOrDefault();
            products.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<Product> SortDateManufactureProduct()
        {
            return _context.Products
                .Where(pr => pr.IsDeleted == false)
                .OrderBy(pr => pr.DateOfManufacture)
                .ToList();
        }



        public List<Product> SortPriceProduct()
        {
            return _context.Products
               .Where(pr => pr.IsDeleted == false)
               .OrderBy(pr => pr.PricePerPiece)
               .ToList();
        }

        public List<Product> SortProductName()
        {
            return _context.Products
            .Where(pr => pr.IsDeleted == false)
            .OrderBy(pr => pr.ProductName)
            .ToList();
        }

        public void UpdateProduct(int idProduct, Product newProduct) 
        {
            var products = _context.Products
                .Where(product => product.Id == idProduct)
                .FirstOrDefault();
            products.IsDeleted = true;

            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }

       
    }
}
