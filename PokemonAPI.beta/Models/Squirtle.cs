namespace PokemonAPI.beta.Models
{
    public class Squirtle : Pokemon
    {
        public string durezaCaparazon { get; set; }
        public override void evolucionar()
        {
            if (nivel < 16)
            {
                Console.WriteLine("${this.nombre} todavia no está listo para evolucionar, necesita subir ${16-this.nivel} niveles más");
            }
            else if (nivel >= 16)
            {
                Console.WriteLine($"{nombre} está listo!");
                Console.WriteLine($"{nombre} está evolucionando a {evoluciones[0]}");
            }
            else if (nivel >= 36)
            {
                Console.WriteLine($"{nombre} está listo!");
                Console.WriteLine($"{nombre} está evolucionando a {evoluciones[1]}");
            }
        }

        public override string ToString()
        {
            return $"Soy un pokemon {nombre}, mi id es #{idPokemon} soy de tipo {tipoPrincipal.nombreTipo} tengo {capacidadAtaque} puntos de ataque, y la dureza de mi caparazón es {durezaCaparazon}";
        }


    }
;
}


