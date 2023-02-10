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
        }
    }
}
