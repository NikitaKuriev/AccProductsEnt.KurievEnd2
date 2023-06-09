using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class WriteOffEntityTypeConfiguration : IEntityTypeConfiguration<WriteOff>
    {
        public void Configure(EntityTypeBuilder<WriteOff> builder)
        {
            builder.HasKey(wo => wo.Id)
                .HasName("PK_WriteOffs_Id");

            builder.Property(wo => wo.WriteOffDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(wo => wo.Cause)
                .IsRequired()
                .HasColumnType("nvarchar");

            builder.Property(wo => wo.QuntityProduct)
                .IsRequired()
                .HasColumnType("integer");


        }
    }
}
