using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_ABB
{
    internal class Nodo
    {
        public int dato;
        public Nodo izq;
        public Nodo der;
        public Nodo (int dato)
        {
            izq = null;
            der = null;
            this.dato = dato;
        }

    }
}
