namespace PokemonReviewApp.Api.Models;

public class Pokemon : EntityBase
{
    public string Name { get; set; } = null!;
    public DateTime BirthDate { get; set; }

    // Relationships
    public ICollection<Review>? Reviews { get; set; }
    public ICollection<PokemonCategory>? PokemonCategories { get; set; }
    public ICollection<PokemonOwner>? PokemonOwners { get; set; }
}