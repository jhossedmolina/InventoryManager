using InventoryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManager.Infrastructure.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.DocNumber).HasColumnName("docNumber");

            builder.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");

            builder.Property(e => e.IdDocumentType).HasColumnName("idDocumentType");

            builder.Property(e => e.IdRoleEmployee).HasColumnName("idRoleEmployee");

            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");

            builder.HasOne(d => d.IdDocumentTypeNavigation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdDocumentType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_DocumentType");

            builder.HasOne(d => d.IdRoleEmployeeNavigation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdRoleEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_RoleEmployee");
        }
    }
}
