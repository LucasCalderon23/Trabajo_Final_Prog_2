using System.Text.Json;
using System.Net.Http;

namespace Trabajo_Final_prog_2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                HttpClient client = new HttpClient();
                string urlPelis = $"https://jsonreader-5pkg.onrender.com/pelis/";
                string pelis = await client.GetStringAsync(urlPelis);

                Root data = JsonSerializer.Deserialize<Root>(pelis);

                List<Pelicula> pelicula = data.Peliculas;

                foreach (Pelicula p in pelicula)
                {
                    Console.WriteLine($"ID: {p.Id}");
                    Console.WriteLine($"Nombre: {p.Nombre}");
                    Console.WriteLine($"Año: {p.Anio}");
                    Console.WriteLine($"Duración: {p.Duracion}");
                    Console.WriteLine($"Género: {p.Genero}");
                    Console.WriteLine($"Valoración: {p.Valoracion}");
                    Console.WriteLine("----------------------");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Se presento un error...{ex.Message}");
            }
           


            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("***** BIENVENIDO A UTNCINEMA *****");
            //Console.WriteLine("-----------------------------------");
            //int opcion;
            //Console.WriteLine("Ingrese el Genero que desea ver: ");
            //Console.WriteLine("1- ACCION.");
            //Console.WriteLine("2- DRAMA.");
            //Console.WriteLine("3- COMEDIA.");
            //Console.WriteLine("4- THRILLER.");
            //Console.WriteLine("5- TERROR.");
            //string aux = Console.ReadLine();
            //while (!int.TryParse(aux, out opcion))
            //{
            //    Console.WriteLine("OPCION INCORRECTA!!! INGRESE NUEVAMENTE...");
            //    Console.Write("Ingrese el Genero que desea ver: ");
            //    aux = Console.ReadLine();
            //}

            //switch (opcion)
            //{
            //    case 1:
            //        //Accion
            //        Console.WriteLine("#### GENERO ACCION ####");
            //        break;

            //    case 2:
            //        //Drama
            //        Console.WriteLine("#### GENERO DRAMA ####");
            //        break;

            //    case 3:
            //        //Comedia
            //        Console.WriteLine("#### GENERO COMEDIA ####");
            //        break;

            //    case 4:
            //        //Thriller
            //        Console.WriteLine("#### GENERO THRILLER ####");
            //        break;

            //    case 5:
            //        //Terror
            //        Console.WriteLine("#### GENERO TERROR ####");
            //        break;
            //    default:
            //        Console.WriteLine("Opcion incorrecta");
            //        break;
            //}
            //Console.WriteLine("GRACIAS POR VENIR, VUELVA PRONTO ;)");
            Console.ReadKey();
        }
    }
}
