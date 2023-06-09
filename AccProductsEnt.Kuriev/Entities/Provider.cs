namespace AccProductsEnt.Kuriev.Entities
{
    public class Provider
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }


        public string FullName { get; set; }

        public int TIN { get; set; }

        public string Address { get; set; }

        public string NameOfSuppliedRaw { get; set; }

 

        public ICollection<Raw> Raws { get; set; }
    }
}
