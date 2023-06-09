using AccProductsEnt.Kuriev.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccProductsEnt.Kuriev.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {

        public ApplicationDbContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
        
        public DbSet<WriteOff> WriteOffs { get; set; }
        public DbSet<Workshop> Workshops { get; set; }
        public DbSet<TechnicalProcesses> TechnicalProcesses { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Raw> Raws { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Implementation> Implementations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Accounting> Accountings { get; set; }
        public DbSet<AccountCard> AccountCards { get; set; }
    }
}
