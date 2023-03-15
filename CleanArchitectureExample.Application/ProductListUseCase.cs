using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureExample.Domain;

namespace CleanArchitectureExample.Application;
// CleanArchitectureExample.Application/UseCases/ProductListUseCase.cs
public class ProductListUseCase : IProductListUseCase
{
    private readonly IProductRepository _productRepository;

    public ProductListUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> ExecuteAsync()
    {
        return await _productRepository.GetProductsAsync();
    }
}
