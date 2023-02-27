namespace InventoryManager.Core.Entities
{
    public partial class MunicipalityCountry
    {
        public MunicipalityCountry()
        {
            Clients = new HashSet<Client>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdStateCountry { get; set; }

        public virtual StateCountry IdStateCountryNavigation { get; set; } = null!;
        public virtual ICollection<Client> Clients { get; set; }
    }
}
