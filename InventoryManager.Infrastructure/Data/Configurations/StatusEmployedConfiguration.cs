using InventoryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManager.Infrastructure.Data.Configurations
{
    public class StatusEmployedConfiguration : IEntityTypeConfiguration<StatusEmployed>
    {
        public void Configure(EntityTypeBuilder<StatusEmployed> builder)
        {
            builder.ToTable("StatusEmployed");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("code");

            builder.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("name");
        }
    }
}
