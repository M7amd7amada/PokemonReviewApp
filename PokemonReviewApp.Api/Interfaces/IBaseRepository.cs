namespace PokemonReviewApp.Api.Interfaces;

public interface IBaseRepository<T> where T : class
{
    T GetById(int id);
}