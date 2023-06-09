namespace AccProductsEnt.Kuriev.Entities
{
    public class Workshop
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public string WorkshopName { get; set;}

        public string ProccesName { get; set; }


        public int RawId { get; set; }


        public Raw Raw { get; set; }
        public ICollection<TechnicalProcesses> TechnicalProcesses { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Staff> Staffs { get; set; }

    }


}
