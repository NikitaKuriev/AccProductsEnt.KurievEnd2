using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(or => or.Id)
                .HasName("PK_Order_Id");

            builder.Property(or => or.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(or => or.Quantity)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnType("nvarchar");

            builder.Property(or => or.OrdersDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(or => or.Cost)
                .IsRequired()
                .HasColumnType("money");

            builder.HasOne(or => or.Implementation)
                .WithMany(implementation => implementation.Orders)
                .HasForeignKey(or => or.ImplementationId)
                .HasConstraintName("FK_Orders_ImplementationId_Implementations_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(or => or.Client)
                .WithMany(client => client.Orders)
                .HasForeignKey(or => or.ClientId)
                .HasConstraintName("FK_Orders_CliientId_Clients_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
