using InventoryManager.Core.Entities;
using InventoryManager.Core.Interfaces;
using InventoryManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly InventoryManagerContext _context;
        public DocumentTypeRepository(InventoryManagerContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DocumentType>> GetDocumentTypes()
        {
            var documentTypes = await _context.DocumentTypes.ToListAsync();

            return documentTypes;
        }

        public async Task<DocumentType>  GetDocumentType(int id)
        {
            var documentType = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Id == id);

            return documentType;
        }

        public async Task PostDocumentType(DocumentType documentType)
        {
            _context.DocumentTypes.Add(documentType);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PutDocumentTypes(DocumentType documentType)
        {
            var currentDocumentType = await GetDocumentType(documentType.Id);
            currentDocumentType.Name = documentType.Name;
            currentDocumentType.Code = documentType.Code;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteDocumentType(int id)
        {
            var currentDocumentType = await GetDocumentType(id);
            _context.DocumentTypes.Remove(currentDocumentType);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
