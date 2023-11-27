using Microsoft.AspNetCore.Mvc;

using PokemonReviewApp.Api.Interfaces;

namespace PokemonReviewApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokemonController(IPokemonRepository repo) : ControllerBase
{
    private readonly IPokemonRepository _repo = repo;

    [HttpGet]
    [Route("GetPokemons")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
    public IActionResult GetPokemons()
    {
        return !ModelState.IsValid ? BadRequest(ModelState) : Ok(_repo.GetPokemons());
    }
}