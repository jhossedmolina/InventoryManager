using System;
using System.Collections.Generic;

namespace InventoryManager.Core.Entities
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            OrderHistories = new HashSet<OrderHistory>();
            ProductHistories = new HashSet<ProductHistory>();
        }

        public int Id { get; set; }
        public DateTime UpdateDate { get; set; }
        public int IdOrder { get; set; }
        public string Observations { get; set; } = null!;
        public int IdProductHistory { get; set; }
        public int QuantityProduct { get; set; }

        public virtual Order IdOrderNavigation { get; set; } = null!;
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
        public virtual ICollection<ProductHistory> ProductHistories { get; set; }
    }
}
