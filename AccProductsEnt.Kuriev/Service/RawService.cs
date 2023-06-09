using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class RawService : IRawService
    {
        private readonly ApplicationDbContext _context;

        public RawService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddRaw(Raw newRaw)
        {
            _context.Raws.Add(newRaw);
            _context.SaveChanges();
        }

        public List<Raw> GetAllRaws()
        {
            return _context.Raws
                .Where(r => r.IsDeleted == false)
                .ToList();
        }

        public Raw GetRaw(string rawName)
        {
            return _context.Raws
              .Where(raw => raw.RawName == rawName && raw.IsDeleted == false)
              .FirstOrDefault();
        }

        public void RemoveRaw(string rawName)
        {
            var raw = _context.Raws
               .Where(raw => raw.RawName == rawName)
               .FirstOrDefault();
            raw.IsDeleted = true;
            _context.SaveChanges();
        }

        public void UpdateRaw(string rawName,Raw newRaw )
        {
            var raw = _context.Raws
                .Where(raw => raw.RawName == rawName)
                .FirstOrDefault();
            raw = newRaw;
            _context.SaveChanges();
        }
    }
}
