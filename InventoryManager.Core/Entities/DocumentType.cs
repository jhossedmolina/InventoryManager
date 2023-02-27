namespace InventoryManager.Core.Entities
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Clients = new HashSet<Client>();
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
