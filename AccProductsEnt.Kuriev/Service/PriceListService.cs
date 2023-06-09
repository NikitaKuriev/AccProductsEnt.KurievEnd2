using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class PriceListService : IPriceListService
    {
        private readonly ApplicationDbContext _context;

        public PriceListService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddPriceList(PriceList newPriceList)
        {
            _context.PriceLists.Add(newPriceList);
            _context.SaveChanges();
        }

        public List<PriceList> GetAllPriceList()
        {
            return _context.PriceLists
                .Where( pr => pr.IsDeleted == false )
                .ToList();
        }
    }
}
