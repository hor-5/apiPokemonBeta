using Microsoft.AspNetCore.Mvc;
using PokemonAPI.beta.Models;
using PokemonAPI.beta.Services;

namespace PokemonAPI.beta.Controllers
{
    [ApiController]
    [Route("api/tipos-pokemon")]
    public class TipoPokemonController : ControllerBase
    {

        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<Tipo> obtenerTodos()
        {
            return dataServices.getTipos();
        }

    }
}
