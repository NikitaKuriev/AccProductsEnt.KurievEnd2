using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Numerics;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class StaffEntityTypeConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(staff => staff.Id)
                .HasName("PK_Staff_Id");

            builder.Property(staff => staff.FullName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nvarchar");

            builder.Property(staff => staff.Experience)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(staff => staff.Wage)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(staff => staff.Address)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar");

            builder.Property(staff => staff.Phone)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar");

            builder.HasOne(staff => staff.Workshop)
                .WithMany(workshop => workshop.Staffs)
                .HasForeignKey(staff =>staff.WorkshopId)
                .HasConstraintName("FK_Staffs_WorkshopId_Workshops_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(staff => staff.Storage)
                .WithMany(storage => storage.Staffs)
                .HasForeignKey(staff => staff.StorageId)
                .HasConstraintName("FK_Staffs_StorageId_Storages_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(staff => staff.Accounting)
                .WithMany(accounting => accounting.Staffs)
                .HasForeignKey(staff => staff.AccountingId)
                .HasConstraintName("FK_Staffs_AccountingId_Accountings_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(staff => staff.Implementation)
                .WithMany(implementation => implementation.Staffs)
                .HasForeignKey(staff => staff.ImplementationId)
                .HasConstraintName("FK_Staffs_ImplementationId_Implementations_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(staff => staff.Post)
                .WithOne(post => post.Staff)
                .HasForeignKey<Post>(staff => staff.StaffId)
                .HasConstraintName("FK_Staffs_PostId_Posts_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
