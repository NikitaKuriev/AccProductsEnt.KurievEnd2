using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class AccountCardEntityTypeConfiguration : IEntityTypeConfiguration<AccountCard>
    {
        public void Configure(EntityTypeBuilder<AccountCard> builder)
        {
            builder.HasKey(card => card.Id)
                .HasName("PK_AccountCard_Id");

            builder.Property(card => card.Name)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar");

            builder.Property(card => card.ReseiptDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(card => card.ImplementationDate)
               .IsRequired()
               .HasColumnType("date");

            builder.Property(card => card.Remainder)
                .HasColumnType("integer");

            builder.Property(card => card.Implemented)
                .HasColumnType("integer");

            builder.HasOne(card => card.Storage)
                .WithOne(storage => storage.AccountCard)
                .HasForeignKey<Storage>(card => card.AccountCardId)
                .HasConstraintName("FK_AccountCards_StorageId_Storages_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
