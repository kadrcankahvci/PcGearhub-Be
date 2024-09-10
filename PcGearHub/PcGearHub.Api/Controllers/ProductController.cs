using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using PcGearHub.Services.ConvertDTO;

namespace PcGearHub.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        // Constructor injection for the ProductService
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/product
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }

        // GET: api/product/5
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            // IQueryable sorgusunu al
            var product = _productService.GetById(id);

            if (product == null)
            {
                return NotFound(); // Ürün bulunamadıysa 404 döner
            }

            return Ok(product); // Ürünü döndürür
        }

        // POST: api/product
        [HttpPost]
        public async Task<ActionResult> CreateProduct([FromBody] ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return BadRequest("Product cannot be null");
            }

           var ab=  await _productService.CreateProductFromDto(productDTO);
            var deneme = Mapper.ToProductDTO(ab);   
            
            return CreatedAtAction(nameof(GetProductById), new { id = deneme.ProductId }, deneme);
        }

        // PUT: api/product/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest("ID mismatch");
            }

            var existingProduct = _productService.GetById(id);
            
            if (existingProduct == null)
            {
                return NotFound();
            }

            await _productService.Update(product);

            return NoContent();
        }

        // DELETE: api/product/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var existingProduct = _productService.GetById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            await _productService.Delete(id);

            return NoContent();
        }
    }
}
