namespace AccProductsEnt.Kuriev.Entities
{
    public class Storage
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }


        public string StorageName { get; set; }

        public DateTime ReceiptDate { get; set; }


        public int AccountCardId { get; set; }


        public AccountCard AccountCard { get; set; }
        public ICollection<Product> Products { get; set;}
        public ICollection<Staff> Staffs { get; set;}
        public ICollection<Implementation> Implementations { get; set; }

      

    }
}
