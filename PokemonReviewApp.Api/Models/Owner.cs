namespace PokemonReviewApp.Api.Models;

public class Owner : EntityBase
{
    public string Name { get; set; } = null!;
    public string Gym { get; set; } = null!;

    // Relationships
    public Country? Country { get; set; }
    public ICollection<PokemonOwner>? PokemonOwners { get; set; }
}