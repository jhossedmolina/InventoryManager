using InventoryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManager.Infrastructure.Data.Configurations
{
    public class RoleEmployeeConfiguration : IEntityTypeConfiguration<RoleEmployee>
    {
        public void Configure(EntityTypeBuilder<RoleEmployee> builder)
        {
            builder.ToTable("RoleEmployee");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property(e => e.Code)
                .HasMaxLength(5)
                .HasColumnName("code")
                .IsFixedLength();

            builder.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("name");
        }
    }
}
