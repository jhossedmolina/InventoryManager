using System;
using System.Collections.Generic;

namespace InventoryManager.Core.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int Id { get; set; }
        public int IdClient { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public string Description { get; set; } = null!;
        public int IdOrderStatus { get; set; }

        public virtual Client IdClientNavigation { get; set; } = null!;
        public virtual OrderStatus IdOrderStatusNavigation { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
