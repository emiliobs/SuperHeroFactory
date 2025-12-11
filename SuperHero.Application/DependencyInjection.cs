using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuperHero.Application.Services;
using SuperHero.Domain.Repositories;
using SuperHero.Domain.UnitOfWorks;
using SuperHero.Infrastructure.Persistence;
using SuperHero.Infrastructure.Repositories;

namespace SuperHero.Application;

// Extension method to add infrastructure services to the IServiceCollection
public static class DependencyInjection
{
    // Adds infrastructure services to the IServiceCollection
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Configure the DbContext to use an in-memory database for simplicity
        //services.AddDbContext<AppDbContext>(options =>
        //    options.UseInMemoryDatabase("SuperHeroDb"));

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Register repositories and unit of work
        services.AddScoped<ISuperHeroRepository, SuperHeroRepository>();

        // Register the UnitOfWork
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        // Register application services
        return services;
    }

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ISuperHeroService, SuperHeroService>();
        return services;
    }
}