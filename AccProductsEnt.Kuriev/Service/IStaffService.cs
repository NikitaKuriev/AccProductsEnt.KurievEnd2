using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IStaffService
    {
        public void AddStaff(Staff newStaff);

        public void RemoveStaff(string staffName);

        public void UpdateStaff(string staffName, Staff newStaff);

        public Staff GetStaff(string staffName);

        public List<Staff> GetStaffAll();
    }
}
