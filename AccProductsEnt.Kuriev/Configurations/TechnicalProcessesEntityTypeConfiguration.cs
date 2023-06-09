using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class TechnicalProcessesEntityTypeConfiguration : IEntityTypeConfiguration<TechnicalProcesses>
    {
        public void Configure(EntityTypeBuilder<TechnicalProcesses> builder)
        {
            builder.HasKey(tp => tp.Id)
                .HasName("PK_TechnicalProcesses_Id");

            builder.Property(tp => tp.ProcessName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnType("nvarchar");

            builder.Property(tp => tp.TimeOfTheEvent)
                .HasColumnType("Date");

            builder.HasOne(tp => tp.Raw)
                .WithMany(raw => raw.TechnicalProcesses)
                .HasForeignKey(tp => tp.RawId)
                .HasConstraintName("FK_TechnicalProcesses_RawId_Raw_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(tp => tp.Workshop)
               .WithMany(workshop => workshop.TechnicalProcesses)
               .HasForeignKey(tp => tp.WorkshopId)
               .HasConstraintName("FK_TechnicalProcesses_WorkshopId_Workshop_Id")
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
