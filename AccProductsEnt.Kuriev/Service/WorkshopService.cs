using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class WorkshopService : IWorkshopService
    {
        private readonly ApplicationDbContext _context;

        public WorkshopService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddWorkshop(Workshop workshop)
        {
            _context.Workshops.Add(workshop);
            _context.SaveChanges();
        }

        public List<Workshop> GetAllWorkshop()
        {
            return _context.Workshops
                .Where(w => w.IsDeleted == false)
                .ToList();
        }
    }
}
