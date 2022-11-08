﻿using Microsoft.AspNetCore.Mvc;
using PokemonAPI.beta.Models;
using PokemonAPI.beta.Services;

namespace PokemonAPI.beta.Controllers
{
    [ApiController]
    [Route("api/entrenador")]
    public class EntrenadoresController : ControllerBase
    {
        DataServices dataServices = new DataServices();

        //todos los entrenadores
        [HttpGet]
        [Route("todos")]
        public List<EntrenadorPokemon> obtenerTodos()
        {
            return dataServices.getEntrenadoresPokemon();
        }

        //por {idEntrenador}
        [HttpGet]
        [Route("{idEntrenador}")]
        public EntrenadorPokemon obtenerPorId(int idEntrenador)
        {
            return dataServices.getEntrenadorById(idEntrenador);
        }

        //{idEntrenador}/pokemon/todos
        [HttpGet]
        [Route("{idEntrenador}/pokemon/todos")]
        public List<Pokemon> obtenerPokemonesDelEntrenador(int idEntrenador)
        {
            EntrenadorPokemon entrenadorSeleccionado = dataServices.getEntrenadorById(idEntrenador);
            return entrenadorSeleccionado.aPokemones;
        }

        //{idEntrenador}/pokemon/{idPokemon}
        [HttpGet]
        [Route("{idEntrenador}/pokemon/{idPokemon}")]
        public Pokemon obtenerPokemonesDelEntrenador(int idEntrenador, int idPokemon)
        {
            Pokemon result = null;
            EntrenadorPokemon entrenadorSeleccionado = dataServices.getEntrenadorById(idEntrenador);
            foreach (Pokemon pokemon in entrenadorSeleccionado.aPokemones)
            {
                if (pokemon.idPokemon == idPokemon)
                {
                    result = pokemon;
                }
            }
            return result;
        }

        ////{idEntrenador}/pokemon/{idPokemon}/entrenar
        [HttpGet]
        [Route("{idEntrenador}/pokemon/{idPokemon}/entrenar")]
        public dynamic entrenarPokemon(int idEntrenador, int idPokemon)
        {
            Pokemon result = null;
            EntrenadorPokemon entrenadorSeleccionado = dataServices.getEntrenadorById(idEntrenador);
            foreach (Pokemon pokemon in entrenadorSeleccionado.aPokemones)
            {
                if (pokemon.idPokemon == idPokemon)
                {
                    result = pokemon;
                }
            }
            result.entrenar();

            if (result != null)
            {
                return new
                {
                    pokemon = result,
                    mensaje = $"{result.nombre} completo su entrenamiento",
                    result.nivel
                };
            }
            else
            {
                return new
                {
                    pokemon = result,
                    mensaje = "Ocurrió un error"
                };
            }
        }
    }
}
