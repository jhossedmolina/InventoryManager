using InventoryManager.Core.Entities;

namespace InventoryManager.Core.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClients();
        Task<Client> GetClient(int id);
        Task PostClient(Client client);
        Task<bool> PutClient(Client client);
        Task<bool> DeleteClient(int id);
    }
}
