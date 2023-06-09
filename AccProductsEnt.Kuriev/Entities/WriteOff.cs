namespace AccProductsEnt.Kuriev.Entities
{
    public class WriteOff
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }


        public DateTime WriteOffDate { get; set; }
        public string Cause { get; set; }
        public int  QuntityProduct { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
   

    }
}
