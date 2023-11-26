namespace PokemonReviewApp.Api.Models;

public class Reviewer : EntityBase
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    // Relationships
    public ICollection<Review>? Reviews { get; set; }
}