namespace PokemonAPI.beta.Models
{
    public class Pikachu : Pokemon
    {
        public string nivelDeEstabilidad { get; set; }
        public override void getEvoluciones()
        {
            Console.WriteLine($"la unica evolucion para $nombre es {evoluciones[0]}");
        }
        public override void evolucionar()
        {
            if (nivel < 30)
            {
                Console.WriteLine($"{nombre} todavia no está listo para evolucionar, necesita subir {30 - nivel} niveles más");
            }
            else if (nivel >= 30)
            {
                Console.WriteLine($"{nombre} está listo!");
                Console.WriteLine($"{nombre} está evolucionando a {evoluciones[0]}");
            }
        }

        public override string ToString()
        {
            return $"Soy un pokemon {nombre}, mi id es #{idPokemon} soy de tipo {tipoPrincipal.nombreTipo}, y mi estabilidad ahora es {nivelDeEstabilidad}";
        }

    }
}
