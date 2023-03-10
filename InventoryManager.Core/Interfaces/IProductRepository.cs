using InventoryManager.Core.Entities;

namespace InventoryManager.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task PostProduct(Product product);
        Task<bool> PutProduct(Product product);
        Task<bool> DeleteProduct(int id);
    }
}
