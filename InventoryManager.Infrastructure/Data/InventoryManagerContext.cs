using System;
using System.Collections.Generic;
using InventoryManager.Core.Entities;
using InventoryManager.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InventoryManager.Infrastructure.Data
{
    public partial class InventoryManagerContext : DbContext
    {
        public InventoryManagerContext()
        {
        }

        public InventoryManagerContext(DbContextOptions<InventoryManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BrandProduct> BrandProducts { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeUser> EmployeeUsers { get; set; } = null!;
        public virtual DbSet<MunicipalityCountry> MunicipalityCountries { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderHistory> OrderHistories { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<ProductHistory> ProductHistories { get; set; } = null!;
        public virtual DbSet<ProductMovement> ProductMovements { get; set; } = null!;
        public virtual DbSet<ProductStock> ProductStocks { get; set; } = null!;
        public virtual DbSet<RoleEmployee> RoleEmployees { get; set; } = null!;
        public virtual DbSet<StateCountry> StateCountries { get; set; } = null!;
        public virtual DbSet<StatusEmployed> StatusEmployeds { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandProductConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeUserConfiguration());
            modelBuilder.ApplyConfiguration(new MunicipalityCountryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductMovementConfiguration());
            modelBuilder.ApplyConfiguration(new ProductStockConfiguration());
            modelBuilder.ApplyConfiguration(new RoleEmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new StateCountryConfiguration());
            modelBuilder.ApplyConfiguration(new StatusEmployedConfiguration());
        }
    }
}