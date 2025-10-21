using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_prog_2
{
    public  class Asiento
    {
        string _Fila;
        int _Numero;

        public string Fila
        {
            get{return this._Fila;}
            set { this._Fila = value; }
        }

        public int Numero
        { 
          get{return this._Numero;}
          set { this._Numero = value; }
        }

        public Asiento(string fila, int numero)
        {
            _Fila = fila;
            _Numero = numero;
        }


    }

}
