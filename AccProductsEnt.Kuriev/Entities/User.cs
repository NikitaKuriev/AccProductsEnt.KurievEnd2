using Microsoft.AspNetCore.Identity;

namespace AccProductsEnt.Kuriev.Entities
{
    public class User : IdentityUser<int>
    {
        public bool IsDeleted { get; set; }
    }
}
