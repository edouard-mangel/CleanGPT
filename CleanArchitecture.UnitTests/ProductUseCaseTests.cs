using CleanArchitectureExample.Application.Interfaces;
using CleanArchitectureExample.Application;
using CleanArchitectureExample.Domain;
using Moq;

namespace CleanArchitecture.UnitTests;
// CleanArchitectureExample.Tests/ProductUseCaseTests.cs
public class ProductUseCaseTests
{
    [Fact]
    public async Task CreateProduct_ShouldAddNewProduct()
    {
        // Arrange
        var mockRepo = new Mock<IProductRepository>();
        var useCase = new ProductUseCase(mockRepo.Object);
        var newProduct = new Product { Id = 3, Name = "New Product", Price = 10.0M };

        // Act
        await useCase.CreateProductAsync(newProduct);

        // Assert
        mockRepo.Verify(repo => repo.AddProductAsync(newProduct), Times.Once);
    }
}
