using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using PcGearHub.Services.ConvertDTO;
using PcGearHub.Services.Implements;

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
        public async Task<ActionResult<List<ProductDTO>>> GetAllProducts()
        {
            var products = await _productService.GetAll();
            var productDTOs = products.Select(Mapper.ToProductDTO).ToList();

            return Ok(productDTOs);
        }


        // GET: api/product/5

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _productService.GetById(id);
            var dto = Mapper.ToProductDTO(product);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(dto);
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
        [HttpPut]
        public async Task<ActionResult> UpdateProduct([FromBody] ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return BadRequest("Invalid product data.");
            }

           
            var existingProduct = await _productService.UpdateProduct(productDTO);
            if (existingProduct == null)
            {
                return NotFound("Product not found.");
            }

            return Ok(existingProduct);
        }

        // DELETE: api/product/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var existingProduct = await _productService.GetById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            await _productService.Delete(id);

            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> SearchProducts([FromQuery] string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Search query cannot be empty.");
            }

            // Perform search using service layer
            var products = await _productService.SearchByQuery(query);

            if (products.Count == 0)
            {
                return NotFound("No products found.");
            }

            var productDTOs = products.Select(Mapper.ToProductDTO).ToList();
            return Ok(productDTOs);
        }
    }
}
