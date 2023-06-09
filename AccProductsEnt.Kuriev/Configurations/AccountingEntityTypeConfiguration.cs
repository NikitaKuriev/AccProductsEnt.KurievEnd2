using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class AccountingEntityTypeConfiguration : IEntityTypeConfiguration<Accounting>
    {
        public void Configure(EntityTypeBuilder<Accounting> builder)
        {
            builder.HasKey(acc => acc.Id)
                .HasName("PK_Accounting_");

            builder.Property(acc => acc.WaybillId)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(acc => acc.PriceProduct)
                .IsRequired()
                .HasColumnType("money");
        }
    }
}
