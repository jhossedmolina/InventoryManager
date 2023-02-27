using AutoMapper;
using InventoryManager.Core.DTOs;
using InventoryManager.Core.Entities;

namespace InventoryManager.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<DocumentType, DocumentTypeDto>();
            CreateMap<DocumentTypeDto, DocumentType>();

            CreateMap<BrandProduct, BrandProductDto>();
            CreateMap<BrandProductDto, BrandProduct>();

            CreateMap<Client, ClientDto>();
            CreateMap<ClientDto, Client>();
        }
    }
}
