namespace AccProductsEnt.Kuriev.Entities
{
    public class Implementation
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }


        public DateTime ImplementationDate { get; set; }

        public decimal Price { get; set; }

        public int StorageId { get; set; }


        public Storage Storage { get; set; }
        public ICollection<Product> Products { get; set;}

        public ICollection<Staff> Staffs { get; set;}

        public ICollection<Order> Orders { get; set;}
    }
}
