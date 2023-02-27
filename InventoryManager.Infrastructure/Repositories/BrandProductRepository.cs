using InventoryManager.Core.Entities;
using InventoryManager.Core.Interfaces;
using InventoryManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Infrastructure.Repositories
{
    public class BrandProductRepository: IBrandProductRepository
    {
        private readonly InventoryManagerContext _context;
        public BrandProductRepository(InventoryManagerContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BrandProduct>> GetBrandProducts()
        {
            var brandProducts = await _context.BrandProducts.ToListAsync();

            return brandProducts;
        }

        public async Task<BrandProduct> GetBrandProduct(int id)
        {
            var brandProduct = await _context.BrandProducts.FirstOrDefaultAsync(x => x.Id == id);

            return brandProduct;
        }

        public async Task PostBrandProduct(BrandProduct brandProduct)
        {
            _context.BrandProducts.Add(brandProduct);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PutBrandProduct(BrandProduct brandProduct)
        {
            var currentBrandProduct = await GetBrandProduct(brandProduct.Id);
            currentBrandProduct.Name = brandProduct.Name;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteBrandProduct(int id)
        {
            var currentBrandProduct = await GetBrandProduct(id);
            _context.BrandProducts.Remove(currentBrandProduct);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
