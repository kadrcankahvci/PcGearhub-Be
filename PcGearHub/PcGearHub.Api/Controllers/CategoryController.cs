using Microsoft.AspNetCore.Mvc;
using PcGearHub.Services.Interfaces;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Implements;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.ConvertDTO;

[Route("api/[controller]/[action]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }    
    [HttpGet]
    public async Task<ActionResult<List<Category>>> GetAllCategories()
    {
        var users = await _categoryService.GetAll();

        return Ok(users);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var category = await _categoryService.GetById(id);

        if (category == null)
        {
            return NotFound();
        }

        return Ok(category);
    }
    [HttpPost]
    public async Task<ActionResult<Category>> CreateCategory([FromBody] CategoryDTO categoryDto)
    {
        if (categoryDto == null)
        {
            return BadRequest("Category data is null");
        }

        // Kategori oluşturma
        var createdCategory = await _categoryService.CreateCategory(categoryDto);      

        return CreatedAtAction(nameof(GetCategoryById), new { id = createdCategory.CategoryId }, createdCategory);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCategory(int id)
    {
      var  category =  await _categoryService.GetById(id);
        if (category == null)
        {
            return NotFound();
        }

        await _categoryService.Delete(id);

        return NoContent();
    }
}
