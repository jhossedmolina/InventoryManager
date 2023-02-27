namespace InventoryManager.Core.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeUsers = new HashSet<EmployeeUser>();
        }

        public int Id { get; set; }
        public int DocNumber { get; set; }
        public int IdDocumentType { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int IdRoleEmployee { get; set; }

        public virtual DocumentType IdDocumentTypeNavigation { get; set; } = null!;
        public virtual RoleEmployee IdRoleEmployeeNavigation { get; set; } = null!;
        public virtual ICollection<EmployeeUser> EmployeeUsers { get; set; }
    }
}
