using System;
using System.Net.Http;
using System.Text.Json;

namespace Trabajo_Final_prog_2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("----- CINE -----");
            Console.WriteLine("----------------");
            try
            {
                HttpClient client = new HttpClient();
                string urlPelis = $"https://jsonreader-5pkg.onrender.com/pelis/";
                string pelis = await client.GetStringAsync(urlPelis);

                Root data = JsonSerializer.Deserialize<Root>(pelis);

                List<Pelicula> listaPeliculas = data.Peliculas;

                List<Salas> salas = new List<Salas>();

                for (int i = 1; i <= 10; i++)
                {
                    salas.Add(new Salas(i));
                }

                Random rnd = new Random();
                foreach (var sala in salas)
                {
                    sala.peliculas = listaPeliculas
                        .OrderBy(x => rnd.Next())  
                        .Take(5)                   
                        .ToList();
                }
                

                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
                while (nombre == string.Empty)
                {
                    Console.Write("Ingrese su nombre: ");
                    nombre = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine($"¡Hola, {nombre}!");
                Console.WriteLine("Elija la opcion que desea realizar");
                Console.WriteLine(" 1- Ver cartelera por sala");
                Console.WriteLine(" 2- Comprar entradas");
                Console.WriteLine(" 0- SALIR");
                string cadena = Console.ReadLine();
                int opcion;
                while (!int.TryParse(cadena, out opcion))
                {
                    Console.WriteLine("Dato ingresado de manera incorrecta!!!!");
                    Console.WriteLine("Elija la opcion que desea realizar");
                    cadena = Console.ReadLine();
                }

                

                switch(opcion)
                {
                    case 1:
                        foreach (var sala in salas)
                        {
                            Console.WriteLine($" Sala {sala.sala}");
                            foreach (var peli in sala.peliculas)
                            {
                                Console.WriteLine($"   - {peli.Nombre} ({peli.Anio}) - {peli.Genero}");
                            }
                            Console.WriteLine("------------------------------");
                        }
                        break;

                    case 2:
                        
                        break;
                }
                


            }

            catch (Exception ex)
            {
                Console.WriteLine($"Se presento un error...{ex.Message}");
            }


            
            
            Console.ReadKey();
        }
    }
}
