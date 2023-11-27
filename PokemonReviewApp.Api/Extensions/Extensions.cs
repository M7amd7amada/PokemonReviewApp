using Microsoft.EntityFrameworkCore;

using PokemonReviewApp.Api.Data;
using PokemonReviewApp.Api.Interfaces;
using PokemonReviewApp.Api.Repositories;

namespace PokemonReviewApp.Api.Extensions;

public static class Extensions
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        string conneectionString = builder.Configuration
            .GetConnectionString("SqlServerConnectionString")!;

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddTransient<SeedData>();
        builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
        builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(conneectionString));
    }

    public static void UseSeedData(this IHost app)
    {
        var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

        using var scope = (scopedFactory
            ?? throw new ArgumentNullException(nameof(scopedFactory))).CreateScope();
        var service = scope.ServiceProvider.GetService<SeedData>();
        (service ?? throw new ArgumentNullException(nameof(service))).Seed();
    }
}