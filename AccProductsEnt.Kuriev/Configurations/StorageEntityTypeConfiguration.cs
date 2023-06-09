using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class StorageEntityTypeConfiguration : IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            builder.HasKey(st => st.Id)
                .HasName("PK_Storage_Id");

            builder.Property(st => st.StorageName)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarchar");

            builder.Property(st => st.ReceiptDate)
                .IsRequired()
                .HasColumnType("date");

    
        }
    }
}
