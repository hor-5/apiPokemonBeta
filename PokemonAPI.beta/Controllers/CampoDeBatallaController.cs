using Microsoft.AspNetCore.Mvc;
using PokemonAPI.beta.Models;
using PokemonAPI.beta.Services;

namespace PokemonAPI.beta.Controllers
{
    [ApiController]
    [Route("api/campos-de-batalla")]
    public class CampoDeBatallaController : ControllerBase
    {
        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<CampoDeBatalla> obtenerTodos()
        {
            return dataServices.getCamposDeBatalla();
        }

        [HttpGet]
        [Route("{id}")]
        public CampoDeBatalla obtenerPorId(int id)
        {
            return dataServices.getCampoDeBatallaPorId(id);
        }


        [HttpGet]
        [Route("{id}/batalla")]
        public ResultadoBatalla obtenePorId(int id)
        {
            CampoDeBatalla campoDeBatalla = dataServices.getCampoDeBatallaPorId(id);
            return dataServices.getResultadoDeBatalla(campoDeBatalla);
        }

        //seleccionar pokemones para la batalla ?
        //{idCampoBatalla}/pokemones/todos ?¿
        //{idCampoBatalla}/pokemones/agregar ?¿
        //{idCampoBatalla}/pokemones/limpiar ?¿
    }
}
