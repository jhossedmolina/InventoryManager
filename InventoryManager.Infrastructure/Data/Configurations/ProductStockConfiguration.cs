using InventoryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManager.Infrastructure.Data.Configurations
{
    public class ProductStockConfiguration : IEntityTypeConfiguration<ProductStock>
    {
        public void Configure(EntityTypeBuilder<ProductStock> builder)
        {
            builder.ToTable("ProductStock");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.IdProduct).HasColumnName("idProduct");

            builder.Property(e => e.QuantityProduct).HasColumnName("quantityProduct");

            builder.HasOne(d => d.IdProductNavigation)
                .WithMany(p => p.ProductStocks)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductStock_Product");
        }
    }
}
