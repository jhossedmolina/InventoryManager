using InventoryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManager.Infrastructure.Data.Configurations
{
    public class BrandProductConfiguration : IEntityTypeConfiguration<BrandProduct>
    {
        public void Configure(EntityTypeBuilder<BrandProduct> builder)
        {
            builder.ToTable("BrandProduct");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        }
    }
}
