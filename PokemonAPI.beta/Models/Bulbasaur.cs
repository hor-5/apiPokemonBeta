namespace PokemonAPI.beta.Models
{
    public class Bulbasaur : Pokemon
    {
        public int tamanioSemilla { get; set; }
        public override void evolucionar()
        {
            if (nivel < 16)
            {
                Console.WriteLine($"{nombre} todavia no está listo para evolucionar, necesita subir {16 - nivel} niveles más");
            }
            else if (nivel >= 16)
            {
                Console.WriteLine($"{nombre} está listo!");
                Console.WriteLine($"{nombre} está evolucionando a {evoluciones[0]}");
            }
            else if (nivel >= 32)
            {
                Console.WriteLine($"{nombre} está listo!");
                Console.WriteLine($"{nombre} está evolucionando a {evoluciones[1]}");
            }
        }
        public override string ToString()
        {
            return $"Soy un pokemon {nombre}, mi id es #{idPokemon} soy de tipo {tipoPrincipal.nombreTipo} y {tipoSecundario.nombreTipo}, mis evoluciones son {evoluciones[0]} y {evoluciones[1]} y mi semilla es de tamaño {tamanioSemilla}";
        }


    }
;
}

