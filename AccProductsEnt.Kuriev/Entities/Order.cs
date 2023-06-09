namespace AccProductsEnt.Kuriev.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }

        public string Quantity { get; set; }

        public DateTime OrdersDate { get; set; }

        public decimal Cost { get; set; }

        public int ImplementationId { get; set; }
        public int ClientId { get; set; }

        public Implementation Implementation { get; set; }
        public Client Client { get; set; }

    }
}
