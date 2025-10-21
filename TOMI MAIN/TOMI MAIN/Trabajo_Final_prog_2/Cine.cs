using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trabajo_Final_prog_2
{
    
    public class Cine
    {
        //propiedades
        private List<Pelicula> _Cartelera;
        private List<Sala> _Salas;



        //constructor
        public Cine()
        {
            this.Cartelera = new List<Pelicula>();
            this.Salas = new List<Sala>();
        }

        public Cine(List<Pelicula> cartelera, List<Sala> salas )
        {
            this.Cartelera = cartelera;
            this.Salas = salas;
        }

        //metodos de propiedad
        public List<Pelicula> Cartelera
        {
            get { return this._Cartelera; }
            set { this._Cartelera = value; }
        }

       
        public List<Sala> _Salas
        {
            get { return this._Salas; }
            set { this._Salas = value; }
        }
        public void AgregarPelicula(Pelicula p)
        {
            _Cartelera.Add(p);
        }
        public void AgregarSala(Sala s)
        {
            _Salas.Add(s);
        }
        public void MostrarCartelera()
        {
            Console.WriteLine($"Cartelera del cine {Nombre}:");
            foreach (var peli in _Cartelera)
            {
                Console.WriteLine($"- {peli.Titulo} ({peli.Genero})");
            }
        }

    }
}
