using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class StaffService : IStaffService
    {
        private readonly ApplicationDbContext _context;

        public StaffService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddStaff(Staff newStaff)
        {
            _context.Staffs.Add(newStaff);
            _context.SaveChanges();
        }

        public Staff GetStaff(string staffName )
        {
            return _context.Staffs
              .Where(staff => staff.FullName == staffName && staff.IsDeleted == false)
              .FirstOrDefault();
        }

        public List<Staff> GetStaffAll()
        {
            return _context.Staffs
                .Where(s => s.IsDeleted == false)
                .ToList();
        }

        public void RemoveStaff(string staffName)
        {
            var staffs = _context.Staffs
                 .Where(staff => staff.FullName == staffName)
                 .FirstOrDefault();
            staffs.IsDeleted = true;
            _context.SaveChanges();
        }

        public void UpdateStaff(string staffName, Staff newStaff)
        {
            var staffs = _context.Staffs
                .Where(staff => staff.FullName == staffName)
                .FirstOrDefault();
            staffs = newStaff;
            _context.SaveChanges();
        }

       
    }
}
