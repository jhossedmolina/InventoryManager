using InventoryManager.Core.Entities;
using InventoryManager.Core.Interfaces;
using InventoryManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryManagerContext _context;

        public ProductRepository(InventoryManagerContext context)
        {
            _context = context;
        }

        public async Task <IEnumerable<Product>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }

        public async Task PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
    }
}
