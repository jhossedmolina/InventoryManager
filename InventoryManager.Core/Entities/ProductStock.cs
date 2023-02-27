namespace InventoryManager.Core.Entities
{
    public partial class ProductStock
    {
        public ProductStock()
        {
            ProductHistories = new HashSet<ProductHistory>();
        }

        public int Id { get; set; }
        public int QuantityProduct { get; set; }
        public int IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; } = null!;
        public virtual ICollection<ProductHistory> ProductHistories { get; set; }
    }
}
