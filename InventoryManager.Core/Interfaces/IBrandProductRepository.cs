using InventoryManager.Core.Entities;

namespace InventoryManager.Core.Interfaces
{
    public interface IBrandProductRepository
    {
        Task<IEnumerable<BrandProduct>> GetBrandProducts();
        Task<BrandProduct> GetBrandProduct(int id);
        Task PostBrandProduct(BrandProduct brandProduct);
        Task<bool> PutBrandProduct(BrandProduct brandProduct);
        Task<bool> DeleteBrandProduct(int id);
    }
}
