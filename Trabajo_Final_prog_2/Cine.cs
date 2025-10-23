using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_prog_2
{
    internal abstract class Cine
    {
        private List<Salas> _salas; 

        public List<Salas> Salas
        {
            get { return this._salas; } 
            set { this._salas = value; }
        }

        public abstract double PrecioEntrada
        {
            get;
        }
    }
}
