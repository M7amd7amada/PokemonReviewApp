namespace PokemonReviewApp.Api.Models;

public class PokemonCategory
{
    public Guid PokemonId { get; set; }
    public Guid CategoryId { get; set; }
    public Pokemon Pokemon { get; set; } = null!;
    public Category Category { get; set; } = null!;
}