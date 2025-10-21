using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Trabajo_Final_prog_2
{
    public class Pelicula
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("año")]
        public int Anio { get; set; }

        [JsonPropertyName("duracion")]
        public string Duracion { get; set; } 

        [JsonPropertyName("genero")]
        public string Genero { get; set; }

        [JsonPropertyName("valoracion")]
        public double Valoracion { get; set; }

        [JsonPropertyName("actores_principales")]
        public List<string> ActoresPrincipales { get; set; }
    }

    
    public class Root
    {
        [JsonPropertyName("peliculas")]
        public List<Pelicula> Peliculas { get; set; } 
    }

}
