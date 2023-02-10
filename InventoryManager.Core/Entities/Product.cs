﻿using System;
using System.Collections.Generic;

namespace InventoryManager.Core.Entities
{
    public partial class Product
    {
        public Product()
        {
            ProductStocks = new HashSet<ProductStock>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int IdProductCategory { get; set; }

        public virtual ProductCategory IdProductCategoryNavigation { get; set; } = null!;
        public virtual ICollection<ProductStock> ProductStocks { get; set; }
    }
}
