namespace PokemonReviewApp.Api.Models;

public class Review : EntityBase
{
    public string Title { get; set; } = null!;
    public string Text { get; set; } = null!;
    public int Rating { get; set; }

    // Relationships
    public Reviewer Reviewer { get; set; } = null!;
    public Pokemon Pokemon { get; set; } = null!;
}