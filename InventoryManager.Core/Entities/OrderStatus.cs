namespace InventoryManager.Core.Entities
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            OrderHistories = new HashSet<OrderHistory>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
