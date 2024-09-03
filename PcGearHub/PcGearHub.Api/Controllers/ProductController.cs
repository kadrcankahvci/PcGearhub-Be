using Microsoft.AspNetCore.Mvc;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.Interfaces;

namespace PcGearHub.Api.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
