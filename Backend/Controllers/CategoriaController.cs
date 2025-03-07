using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Services;

namespace PruebaTecnica.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CategoriaController : Controller
    {
        private readonly CategoriaService _categoryService;

        public CategoriaController(CategoriaService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategorias()
        {
            var productos = await _categoryService.GetProductosAsync();
            if (productos != null)
            {
                return Ok(productos);
            }
            else
            {
                return BadRequest("No existen productos");
            }
        }

        [HttpPost("UpdateCategory")]
        public async Task<IActionResult> UpdateCategoria(Categoria category)
        {
            await _categoryService.UpdateProductAsync(category);
            return Ok("Base de Datos Actualizada");

        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategoria(Categoria category)
        {
            await _categoryService.AddProductAsync(category);
            return Ok("Creacion Correcta");
        }

        [HttpPost("DeleteCategory")]
        public async Task<IActionResult> DeleteCategoria(int id)
        {
            await _categoryService.DeleteProductAsync(id);
            return Ok("Borrado Correcto");
        }
    }
}
