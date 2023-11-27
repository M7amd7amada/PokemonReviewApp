namespace PokemonReviewApp.Api.Interfaces;

public interface IPokemonRepository
{
    public IEnumerable<Pokemon> GetPokemons();
}