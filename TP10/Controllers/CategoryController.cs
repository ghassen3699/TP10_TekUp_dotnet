using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;
using TP10.Repositories;

namespace TP10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryInterface categoryInterface;
        public CategoryController(ICategoryInterface
       categoryInterface)
        {
            this.categoryInterface = categoryInterface;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var cat = await categoryInterface.GetAllCategories();
            return Ok(cat);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewCategory(Categorie
       category)
        {
            var cat = await
           categoryInterface.CreateCategory(category); return Ok(cat);
        }
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateCategory(int id,
       Categorie category)
        {
            if (!ModelState.IsValid) return BadRequest();
            var cat = await categoryInterface.EditCategory(id,
           category); return Ok(cat);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var cat = await categoryInterface.DeleteCategory(id);
            return Ok(cat);
        }
    }
}