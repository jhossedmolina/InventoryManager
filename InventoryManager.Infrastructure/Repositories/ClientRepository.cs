using InventoryManager.Core.Entities;
using InventoryManager.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Infrastructure.Repositories
{
    public class ClientRepository
    {
        private readonly InventoryManagerContext _context;

        public ClientRepository(InventoryManagerContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            var clients = await _context.Clients.ToListAsync();
            return clients;
        }

        public async Task<Client> GetClient(int id)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);
            return client;
        }

        public async Task PostClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PutClient(Client client)
        {
            var currentClient = await GetClient(client.Id);
            currentClient.DocNumber = client.DocNumber;
            currentClient.IdDocumentType = client.IdDocumentType;
            currentClient.FirstName = client.FirstName;
            currentClient.LastName = client.LastName;
            currentClient.ContactNumber  = client.ContactNumber;
            currentClient.Address = client.Address;
            currentClient.IdMunicipalityCountry = client.IdMunicipalityCountry;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteClient(int id)
        {
            var currentClient = await GetClient(id);
            _context.Clients.Remove(currentClient);

            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
