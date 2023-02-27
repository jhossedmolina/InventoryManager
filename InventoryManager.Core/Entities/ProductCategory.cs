namespace InventoryManager.Core.Entities
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int IdBrandProduct { get; set; }

        public virtual BrandProduct IdBrandProductNavigation { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
