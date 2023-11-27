using PokemonReviewApp.Api.Data;
using PokemonReviewApp.Api.Interfaces;

namespace PokemonReviewApp.Api.Repositories;

public class PokemonRepository(AppDbContext context) : IPokemonRepository
{
    private readonly AppDbContext _context = context;

    public IEnumerable<Pokemon> GetPokemons()
    {
        return _context.Pokemons.OrderBy(p => p.Id).ToList();
    }
}