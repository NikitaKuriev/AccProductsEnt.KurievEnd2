namespace AccProductsEnt.Kuriev.Entities
{
    public class Raw
    {
        public int  Id { get; set; }

        public bool IsDeleted { get; set; }


        public string RawName { get; set; }

        public int Quantity { get; set; }

        public decimal PriceRaw { get; set; }

        public DateTime ReceiptDate { get; set; }


        public int ProviderId { get; set; }


        public Provider Provider { get; set; }
        public ICollection<TechnicalProcesses> TechnicalProcesses { get; set; }
        public ICollection<Workshop> Workshops { get; set; }
    }
}
