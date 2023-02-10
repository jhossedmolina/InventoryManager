using InventoryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManager.Infrastructure.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.IdOrder).HasColumnName("idOrder");

            builder.Property(e => e.IdProductHistory).HasColumnName("idProductHistory");

            builder.Property(e => e.Observations)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("observations");

            builder.Property(e => e.QuantityProduct).HasColumnName("quantityProduct");

            builder.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");

            builder.HasOne(d => d.IdOrderNavigation)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Order");
        }
    }
}
