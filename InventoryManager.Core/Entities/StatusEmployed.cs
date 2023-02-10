using System;
using System.Collections.Generic;

namespace InventoryManager.Core.Entities
{
    public partial class StatusEmployed
    {
        public StatusEmployed()
        {
            EmployeeUsers = new HashSet<EmployeeUser>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<EmployeeUser> EmployeeUsers { get; set; }
    }
}
