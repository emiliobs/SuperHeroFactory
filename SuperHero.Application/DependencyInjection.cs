using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuperHero.Application.Services;
using SuperHero.Domain.Repositories;
using SuperHero.Domain.UnitOfWorks;
using SuperHero.Infrastructure.Persistence;
using SuperHero.Infrastructure.Repositories;

namespace SuperHero.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("SuperHeroDb"));

        services.AddScoped<ISuperHeroRepository, SuperHeroRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}