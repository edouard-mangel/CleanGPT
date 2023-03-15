using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureExample.Application.Interfaces;
using CleanArchitectureExample.Domain;

namespace CleanArchitectureExample.Application;
// CleanArchitectureExample.Application/UseCases/ProductUseCase.cs
public class ProductUseCase : IProductUseCase
{
    private readonly IProductRepository _productRepository;

    public ProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _productRepository.GetProductsAsync();
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _productRepository.GetProductByIdAsync(id);
    }

    public async Task CreateProductAsync(Product product)
    {
        await _productRepository.AddProductAsync(product);
    }
}
