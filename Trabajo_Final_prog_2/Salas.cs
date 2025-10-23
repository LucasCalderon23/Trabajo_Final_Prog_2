using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_prog_2
{
    internal class Salas : Cine
    {
        private int _sala;
        private List<Pelicula> _peliculas;
        

        public int sala
        {
            get { return this._sala; } 
            set { this._sala = value; }
        }

        public List<Pelicula> peliculas
        {
            get { return this._peliculas; }
            set { this._peliculas = value; }
        }

        

        
    }
}
