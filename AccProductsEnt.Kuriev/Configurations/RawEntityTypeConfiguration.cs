using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class RawEntityTypeConfiguration : IEntityTypeConfiguration<Raw>
    {
        public void Configure(EntityTypeBuilder<Raw> builder)
        {
            builder.HasKey(raw => raw.Id)
                .HasName("PK_Raws_Id");

            builder.Property(raw => raw.RawName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnType("nvarchar");

            builder.Property(raw => raw.Quantity)
                .IsRequired()
                .HasColumnType("INTEGER");

           

            builder.Property(raw => raw.PriceRaw)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(raw => raw.ReceiptDate)
                .IsRequired()
                .HasColumnType("Date");

            builder.HasOne(raw => raw.Provider)
                .WithMany(provider => provider.Raws)
                .HasForeignKey(raw => raw.ProviderId)
                .HasConstraintName("FK_Raws_ProviderId_Provider_Id")
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
