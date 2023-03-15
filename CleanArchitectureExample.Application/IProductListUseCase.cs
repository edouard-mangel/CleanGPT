using CleanArchitectureExample.Domain;

namespace CleanArchitectureExample.Application;

public interface IProductListUseCase
{
    Task<IEnumerable<Product>> ExecuteAsync();
}