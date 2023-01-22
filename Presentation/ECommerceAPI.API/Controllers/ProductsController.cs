using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            // await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new(){Id = Guid.NewGuid(), Name = "Product 13", Price = 110, CreatedDate = DateTime.UtcNow, Stock =19},
            //    new(){Id = Guid.NewGuid(), Name = "Product 14", Price = 220, CreatedDate = DateTime.UtcNow, Stock =40},
            //    new(){Id = Guid.NewGuid(), Name = "Product 15", Price = 170, CreatedDate = DateTime.UtcNow, Stock =20},
            //    new(){Id = Guid.NewGuid(), Name = "Product 16", Price = 210, CreatedDate = DateTime.UtcNow, Stock =35}
            //});
            Product product = await _productReadRepository.GetByIdAsync("16f52e73-11a5-48c1-a6da-4d0804045e12",false);
            product.Name = "Product 12";
            await _productWriteRepository.SaveAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
