using Microsoft.AspNetCore.Mvc;
using PcGearHub.Services.Interfaces;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Implements;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetAllCategories")]
    public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetAllCategories()
    {
        var categories = await _categoryService.GetAll();
        return Ok(categories);
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
