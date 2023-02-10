using System;
using System.Collections.Generic;

namespace InventoryManager.Core.Entities
{
    public partial class ProductMovement
    {
        public ProductMovement()
        {
            ProductHistories = new HashSet<ProductHistory>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<ProductHistory> ProductHistories { get; set; }
    }
}
