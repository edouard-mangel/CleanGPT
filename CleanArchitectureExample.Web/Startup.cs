using CleanArchitectureExample.Application;
using CleanArchitectureExample.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CleanArchitectureExample.Web;

// CleanArchitectureExample/Startup.cs
public class Startup
{

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddControllers();
    }
}