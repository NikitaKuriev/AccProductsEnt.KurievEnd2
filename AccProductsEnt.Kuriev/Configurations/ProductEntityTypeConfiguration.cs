using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id)
                 .HasName("PK_Product_Id");

            builder.Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.Quantity)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(p => p.DateOfManufacture)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(product => product.ImgPath)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.PricePerPiece)
                .IsRequired()
                .HasColumnType("money");

            builder.HasOne(p => p.Workshop)
                .WithMany(workshop => workshop.Products)
                .HasForeignKey(p => p.WorkshopId)
                .HasConstraintName("FK_Products_WorkcshopId_Workshops_Id")
                .OnDelete(DeleteBehavior.NoAction); 

            builder.HasOne(p => p.Storage)
                .WithMany(storage => storage.Products)
                .HasForeignKey(p => p.StorageId)
                .HasConstraintName("FK_Products_StorageId_Storages_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Accounting)
                .WithMany(accounting => accounting.Products)
                .HasForeignKey(p => p.AccountingId)
                .HasConstraintName("FK_Products_AccountingId_Accountings_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Implementation)
                .WithMany(implementation => implementation.Products)
                .HasForeignKey(p => p.ImplementationId)
                .HasConstraintName("FK_Products_ImplementationId_Implementations_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.WriteOff)
                .WithOne(writeOff => writeOff.Product)
                .HasForeignKey<WriteOff>(p => p.ProductId)
                .HasConstraintName("FK_Products_WriteOffId_WriteOffs_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
