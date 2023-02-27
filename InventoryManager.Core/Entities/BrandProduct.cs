namespace InventoryManager.Core.Entities
{
    public partial class BrandProduct
    {
        public BrandProduct()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
