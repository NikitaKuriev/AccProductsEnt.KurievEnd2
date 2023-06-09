namespace AccProductsEnt.Kuriev.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }


        public string FullName { get; set; }

        public string TIN { get; set; }


        public ICollection<Order> Orders { get; set; }

        public PriceList PriceList { get; set; }
    }
}
