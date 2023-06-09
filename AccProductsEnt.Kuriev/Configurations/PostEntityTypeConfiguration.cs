using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(post => post.Id)
                .HasName("PK_Post_Id");

            builder.Property(post => post.PostTitle)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(post => post.JobResponsibilities)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar");


        }
    }
}
