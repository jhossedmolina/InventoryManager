using AutoMapper;
using InventoryManager.Core.DTOs;
using InventoryManager.Core.Entities;
using InventoryManager.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productRepository.GetProducts();
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(productsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productRepository.GetProduct(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.PostProduct(product);
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id, ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            product.Id = id;
            await _productRepository.PutProduct(product);
            return Ok(product);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _productRepository.DeleteProduct(id);
            return Ok(result);
        }
    }
}