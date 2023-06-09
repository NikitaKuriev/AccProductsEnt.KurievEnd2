using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class ImplementationEntityTypeConfiguration : IEntityTypeConfiguration<Implementation>
    {
        public void Configure(EntityTypeBuilder<Implementation> builder)
        {
            builder.HasKey(imp =>imp.Id)
                .HasName("PK_Implementation_Id");

            builder.Property(imp => imp.ImplementationDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(imp => imp.Price)
                .IsRequired()
                .HasColumnType("money");

            builder.HasOne(imp => imp.Storage)
                .WithMany(storage => storage.Implementations)
                .HasForeignKey(imp => imp.StorageId)
                .HasConstraintName("FK_Implementations_StorageId_Storages_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
