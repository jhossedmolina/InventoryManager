using System;
using System.Collections.Generic;

namespace InventoryManager.Core.Entities
{
    public partial class RoleEmployee
    {
        public RoleEmployee()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
