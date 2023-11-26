namespace PokemonReviewApp.Api.Models;

public abstract class EntityBase
{
    public Guid Id { get; set; } = new();
    public Status Status { get; set; }
    public DateTime CraetedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; }
}

public enum Status : byte
{
    InActive = 0,
    Active = 1
}