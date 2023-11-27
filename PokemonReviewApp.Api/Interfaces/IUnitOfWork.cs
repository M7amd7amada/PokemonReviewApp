namespace PokemonReviewApp.Api.Interfaces;

public interface IUnitOfWork
{
    public IBaseRepository<Category> Categories { get; }
    public IBaseRepository<Country> Countries { get; }
    public IBaseRepository<Owner> Owners { get; }
    public IBaseRepository<Pokemon> Pokemons { get; }
    public IBaseRepository<PokemonCategory> PokemonCategories { get; }
    public IBaseRepository<PokemonOwner> PokemonOwners { get; }
    public IBaseRepository<Review> Reviews { get; }
    public IBaseRepository<Reviewer> Reviewers { get; }

    public int Complete();
}