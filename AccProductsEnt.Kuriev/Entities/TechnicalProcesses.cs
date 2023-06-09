namespace AccProductsEnt.Kuriev.Entities
{
    public class TechnicalProcesses
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string ProcessName { get; set; }
        public DateTime TimeOfTheEvent { get; set; }


        public int RawId { get; set; }
        public int WorkshopId { get; set; }

        public Raw Raw { get; set; }
        public Workshop Workshop { get; set; }
    }
}
