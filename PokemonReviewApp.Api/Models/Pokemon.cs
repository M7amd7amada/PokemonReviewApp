namespace PokemonReviewApp.Api.Models;

public class Pokemon : EntityBase
{
    public string Name { get; set; } = null!;
    public DateTime BirthDate { get; set; }
}