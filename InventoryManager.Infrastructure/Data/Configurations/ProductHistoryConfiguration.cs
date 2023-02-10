using InventoryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManager.Infrastructure.Data.Configurations
{
    public class ProductHistoryConfiguration : IEntityTypeConfiguration<ProductHistory>
    {
        public void Configure(EntityTypeBuilder<ProductHistory> builder)
        {
            builder.ToTable("ProductHistory");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.IdOrderDetail).HasColumnName("idOrderDetail");

            builder.Property(e => e.IdProduct).HasColumnName("idProduct");

            builder.Property(e => e.IdProductMovement).HasColumnName("idProductMovement");

            builder.Property(e => e.IdProductStock).HasColumnName("idProductStock");

            builder.Property(e => e.QuantityProduct).HasColumnName("quantityProduct");

            builder.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");

            builder.HasOne(d => d.IdOrderDetailNavigation)
                .WithMany(p => p.ProductHistories)
                .HasForeignKey(d => d.IdOrderDetail)
                .HasConstraintName("FK_InventoryMaterial_OrderDetails");

            builder.HasOne(d => d.IdProductMovementNavigation)
                .WithMany(p => p.ProductHistories)
                .HasForeignKey(d => d.IdProductMovement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductHistory_ProductMovement");

            builder.HasOne(d => d.IdProductStockNavigation)
                .WithMany(p => p.ProductHistories)
                .HasForeignKey(d => d.IdProductStock)
                .HasConstraintName("FK_InventoryMaterial_MaterialStock");
        }
    }
}
