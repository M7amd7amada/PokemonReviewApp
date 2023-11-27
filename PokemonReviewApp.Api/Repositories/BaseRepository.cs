using PokemonReviewApp.Api.Data;
using PokemonReviewApp.Api.Interfaces;

namespace PokemonReviewApp.Api.Repositories;

public class BaseRepository<T>(AppDbContext context) : IBaseRepository<T> where T : class
{
    protected readonly AppDbContext _context = context;

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id)
            ?? throw new ArgumentNullException(nameof(GetById));
    }
}