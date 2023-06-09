namespace AccProductsEnt.Kuriev.Entities
{
    public class AccountCard
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }


        public string Name { get; set; }

        public DateTime ReseiptDate { get; set; }
         
        public DateTime ImplementationDate { get; set; }

        public int Implemented { get; set; }

        public int Remainder { get; set; }


        public Storage Storage { get; set; }
    }
}
