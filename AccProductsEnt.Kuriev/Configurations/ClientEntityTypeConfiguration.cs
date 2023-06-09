using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class ClientEntityTypeConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(cl => cl.Id)
                .HasName("PK_Client_Id");

            builder.Property(cl => cl.FullName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(cl => cl.TIN)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar");

            builder.HasOne(cl => cl.PriceList)
                .WithOne(priceList => priceList.Client)
                .HasForeignKey<PriceList>(cl => cl.ClientId)
                .HasConstraintName("FK_Clients_PriceListId_PriceLists_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
