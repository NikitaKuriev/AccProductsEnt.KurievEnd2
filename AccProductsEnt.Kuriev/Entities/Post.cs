namespace AccProductsEnt.Kuriev.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }


        public string PostTitle { get; set; }

        public string JobResponsibilities { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
