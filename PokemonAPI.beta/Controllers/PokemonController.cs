using Microsoft.AspNetCore.Mvc;
using PokemonAPI.beta.Models;
using PokemonAPI.beta.Services;

namespace PokemonAPI.beta.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<Pokemon> obtenerTodos()
        {
            return dataServices.getPokemones();
        }

        [HttpGet]
        [Route("{id}")]
        public Pokemon obtenerPorId(int id)
        {
            return dataServices.getPokemonById(id);
        }
    }
}
