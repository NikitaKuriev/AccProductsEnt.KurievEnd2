using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class TechnicalProcessesService : ITechnicalProcessesService
    {
        private readonly ApplicationDbContext _context;

        public TechnicalProcessesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddTechnicalProcesses(TechnicalProcesses technicalProcesses)
        {
            _context.TechnicalProcesses.Add(technicalProcesses);
            _context.SaveChanges();
                
        }
    }
}
