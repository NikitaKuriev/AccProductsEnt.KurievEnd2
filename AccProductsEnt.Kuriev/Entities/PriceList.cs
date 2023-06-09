namespace AccProductsEnt.Kuriev.Entities
{
    public class PriceList
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; } // Кчау

        public decimal PricePerPiece { get; set; } //122к

        public int ClientId { get; set; } // Сергей

        public Client Client { get; set; }

    }
}
