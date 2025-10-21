namespace Trabajo_Final_prog_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("***** BIENVENIDO A UTNCINEMA *****");
            Console.WriteLine("-----------------------------------");
            int opcion;
            Console.WriteLine("Ingrese el Genero que desea ver: ");
            Console.WriteLine("1- ACCION.");
            Console.WriteLine("2- DRAMA.");
            Console.WriteLine("3- COMEDIA.");
            Console.WriteLine("4- THRILLER.");
            Console.WriteLine("5- TERROR.");
            string aux = Console.ReadLine();
            while (!int.TryParse(aux, out opcion))
            {
                Console.WriteLine("OPCION INCORRECTA!!! INGRESE NUEVAMENTE...");
                Console.Write("Ingrese el Genero que desea ver: ");
                aux = Console.ReadLine();
            }

            switch (opcion)
            {
                case 1:
                    //Accion
                    Console.WriteLine("#### GENERO ACCION ####");
                    break;

                case 2:
                    //Drama
                    Console.WriteLine("#### GENERO DRAMA ####");
                    break;

                case 3:
                    //Comedia
                    Console.WriteLine("#### GENERO COMEDIA ####");
                    break;

                case 4:
                    //Thriller
                    Console.WriteLine("#### GENERO THRILLER ####");
                    break;

                case 5:
                    //Terror
                    Console.WriteLine("#### GENERO TERROR ####");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
            Console.WriteLine("GRACIAS POR VENIR, VUELVA PRONTO ;)");
            Console.ReadKey();
        }
    }
}
