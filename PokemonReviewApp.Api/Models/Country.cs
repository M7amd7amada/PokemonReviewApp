namespace PokemonReviewApp.Api.Models;

public class Country : EntityBase
{
    public string Name { get; set; } = null!;

    // Relationships
    public ICollection<Owner>? Owners { get; set; }
}