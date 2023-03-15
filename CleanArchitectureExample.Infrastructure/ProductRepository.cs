using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureExample.Application;
using CleanArchitectureExample.Domain;

namespace CleanArchitectureExample.Infrastructure;

public class ProductRepository : IProductRepository
{
    // Simulate a data source
    private static readonly List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Price = 10.99m },
        new Product { Id = 2, Name = "Product 2", Price = 5.99m },
    };

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await Task.FromResult(_products);
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await Task.FromResult(_products.FirstOrDefault(p => p.Id == id));
    }
}
