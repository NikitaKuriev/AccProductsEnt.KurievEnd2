using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class ProviderEntityTypeConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(pr => pr.Id)
                .HasName("PK_Provider_Id");

            builder.Property(pr => pr.FullName)
                .IsRequired()
                .HasMaxLength(128)
                .HasColumnType("nvarchar");

            builder.Property(pr => pr.TIN)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(pr => pr.Address)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar");

            builder.Property(pr => pr.NameOfSuppliedRaw)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar");


        }
    }
}
