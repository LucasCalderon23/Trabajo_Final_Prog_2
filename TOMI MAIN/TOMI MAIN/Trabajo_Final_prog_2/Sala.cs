using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trabajo_Final_prog_2
{
    abstract class Sala
    {
        int _nroSala;
        int _Capacidad;
        public List<Asiento> Asientos = new List<Asiento>();

        public int nroSala
        {
            get { return this._nroSala; }
            set { this._nroSala = value; }
        }

        public int Capacidad
        {
            get { return this._Capacidad; }
            set { this._Capacidad = value; }
        }

        public Sala(int sala, int capacidad) 
        {
            _nroSala = sala;
            _Capacidad = capacidad;
            
            

        }



    }
}
