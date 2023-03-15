using CleanArchitectureExample.Application;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureExample.Web.Controllers;
// CleanArchitectureExample/Controllers/ProductsController.cs
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductListUseCase _productListUseCase;

    public ProductsController(IProductListUseCase productListUseCase)
    {
        _productListUseCase = productListUseCase;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _productListUseCase.ExecuteAsync();
        return Ok(products);
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _productListUseCase.GetProductByIdAsync(id);
        if (product == null) {
            return NotFound();
        }

        return Ok(product);
    }
}
