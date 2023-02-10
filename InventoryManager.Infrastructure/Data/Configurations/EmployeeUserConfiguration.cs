﻿using InventoryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManager.Infrastructure.Data.Configurations
{
    public class EmployeeUserConfiguration : IEntityTypeConfiguration<EmployeeUser>
    {
        public void Configure(EntityTypeBuilder<EmployeeUser> builder)
        {
            builder.ToTable("EmployeeUser");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property(e => e.IdEmployee).HasColumnName("idEmployee");

            builder.Property(e => e.IdStatusEmployed).HasColumnName("idStatusEmployed");

            builder.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");

            builder.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");

            builder.HasOne(d => d.IdEmployeeNavigation)
                .WithMany(p => p.EmployeeUsers)
                .HasForeignKey(d => d.IdEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeUser_Employee");

            builder.HasOne(d => d.IdStatusEmployedNavigation)
                .WithMany(p => p.EmployeeUsers)
                .HasForeignKey(d => d.IdStatusEmployed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeUser_StatusEmployed");
        }
    }
}
