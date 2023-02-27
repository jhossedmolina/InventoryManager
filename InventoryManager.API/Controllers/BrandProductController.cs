using AutoMapper;
using InventoryManager.Core.DTOs;
using InventoryManager.Core.Entities;
using InventoryManager.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandProductController : ControllerBase
    {
        private readonly IBrandProductRepository _brandProductRepository;
        private readonly IMapper _mapper;

        public BrandProductController(IBrandProductRepository brandProductRepository, IMapper mapper)
        {
            _brandProductRepository = brandProductRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetBrandProducts()
        {
            var brandProducts = await _brandProductRepository.GetBrandProducts();
            var brandProductsDto = _mapper.Map<IEnumerable<BrandProductDto>>(brandProducts);
            return Ok(brandProductsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandProduct(int id)
        {
            var brandProduct = await _brandProductRepository.GetBrandProduct(id);
            var brandProductDto = _mapper.Map<BrandProductDto>(brandProduct);
            return Ok(brandProductDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostBrandProduct(BrandProductDto brandProductDto)
        {
            var brandProduct = _mapper.Map<BrandProduct>(brandProductDto);
            await _brandProductRepository.PostBrandProduct(brandProduct);
            return Ok(brandProduct);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrandProduct(int id, BrandProductDto brandProductDto)
        {
            var brandProduct = _mapper.Map<BrandProduct>(brandProductDto);
            brandProduct.Id = id;
            await _brandProductRepository.PutBrandProduct(brandProduct);
            return Ok(brandProduct);
        }

        [HttpDelete]  
        public async Task<IActionResult> DeleteBrandProduct(int id)
        {
            var result = await _brandProductRepository.DeleteBrandProduct(id);
            return Ok(result);
        }
    }
}
