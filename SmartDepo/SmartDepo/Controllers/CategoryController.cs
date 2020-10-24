using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartDepo.Services.Abstraction;
using SmartDepo.Services.DTO;

namespace SmartDepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        [Route("save")]
        public async Task<CategoryDTO> InsertCategory(CategoryDTO categoryDTO)
        {
            return await _categoryService.InsertCategory(categoryDTO);
        }
    }
}