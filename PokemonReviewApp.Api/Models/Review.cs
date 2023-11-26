namespace PokemonReviewApp.Api.Models;

public class Review : EntityBase
{
    public string Title { get; set; } = null!;
    public string Text { get; set; } = null!;

    // Relationships
    public Reviewer Reviewer { get; set; } = null!;
    public Pokemon Pokemon { get; set; } = null!;
}