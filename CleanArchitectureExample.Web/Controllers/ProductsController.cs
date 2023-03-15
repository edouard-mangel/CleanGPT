using CleanArchitectureExample.Application.Interfaces;
using CleanArchitectureExample.Domain;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureExample.Web.Controllers;
// CleanArchitectureExample/Controllers/ProductsController.cs
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductUseCase _productUseCase;

    public ProductsController(IProductUseCase productUseCase)
    {
        _productUseCase = productUseCase;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _productUseCase.GetProductsAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _productUseCase.GetProductByIdAsync(id);
        if (product == null) {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product product)
    {
        await _productUseCase.CreateProductAsync(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }
}
