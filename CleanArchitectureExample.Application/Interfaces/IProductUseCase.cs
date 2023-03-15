using CleanArchitectureExample.Domain;

namespace CleanArchitectureExample.Application.Interfaces;

public interface IProductUseCase
{
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetProductByIdAsync(int id);
    Task CreateProductAsync(Product product);
}