namespace AccProductsEnt.Kuriev.Entities
{
    public class Staff
    {
        public int Id { get; set; }
        public bool  IsDeleted { get; set; }



        public string FullName { get; set; }

        public int Experience { get; set; }

        public decimal Wage { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }


        public int WorkshopId { get; set; }
        public int StorageId { get; set; }
        public int AccountingId { get; set; }
        public int ImplementationId { get; set; }

        public Workshop Workshop { get; set; }
        public Storage Storage { get; set; }
        public Accounting Accounting { get; set; }
        public Implementation Implementation { get; set; }
        public Post Post { get; set; }
    }
}
