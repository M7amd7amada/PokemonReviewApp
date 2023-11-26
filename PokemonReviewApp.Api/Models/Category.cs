namespace PokemonReviewApp.Api.Models;

public class Category : EntityBase
{
    public string Name { get; set; } = null!;

    // Relationships
    public ICollection<PokemonCategory>? PokemonCategories { get; set; }
}