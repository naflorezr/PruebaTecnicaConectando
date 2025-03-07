using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.DbConnection;
using PruebaTecnica.Models;
using PruebaTecnica.Services;

namespace PruebaTecnica.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ProductoController : ControllerBase
{

    private readonly ProductService _productService;

    public ProductoController(ProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("GetProduct")]
    public async Task<IActionResult> GetProductos()
    {
        var productos = await _productService.GetProductosAsync();
        if (productos != null)
        {
            return Ok(productos);
        }
        else
        {
            return BadRequest("No existen productos");
        }
    }

    [HttpPost("UpdateProduct")]
    public async Task<IActionResult> UpdateProductos(Producto product)
    {
        await _productService.UpdateProductAsync(product);
        return Ok("Base de Datos Actualizada");

    }

    [HttpPost("CreateProduct")]
    public async Task<IActionResult> CreateProductos(Producto product)
    {
        await _productService.AddProductAsync(product);
        return Ok("Creacion Correcta");
    }

    [HttpPost("DeleteProduct")]
    public async Task<IActionResult> DeleteProductos(int id)
    {
        await _productService.DeleteProductAsync(id);
        return Ok("Borrado Correcto");
    }
}
