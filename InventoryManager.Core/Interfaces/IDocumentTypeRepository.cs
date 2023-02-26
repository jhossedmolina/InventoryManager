using InventoryManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.Interfaces
{
    public interface IDocumentTypeRepository
    {
        Task<IEnumerable<DocumentType>> GetDocumentTypes();
        Task<DocumentType> GetDocumentType(int id);
        Task PostDocumentType(DocumentType documentType);
        Task<bool> PutDocumentTypes(DocumentType documentType);
        Task<bool> DeleteDocumentType(int id);
    }
}
