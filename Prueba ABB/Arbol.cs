using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_ABB
{
    internal class Arbol
    {
        int dato = 0;
        Nodo raiz=null; 

        public void Insertar(int info) 
        {
            Nodo nuevo = new Nodo(info);
            //nuevo.dato= info;
            nuevo.izq = null;
            nuevo.der = null;
            if(raiz==null)
            {
                raiz= nuevo;
            }else 
            {
                Nodo ant = null; 
                Nodo valor = raiz;
                while(valor!=null) 
                {
                    ant= valor;
                    if(info < valor.dato) valor =valor.izq;
                    else valor = valor.der; 

                }
                if (info < ant.dato) ant.izq = nuevo;
                else ant.der = nuevo;
            }
        }

        private void PreOrden(Nodo valor) //R I D 
        {
            if(valor!=null) 
            {
                Console.WriteLine(valor.dato+" ");//raiz
                PreOrden(valor.izq);//Izq
                PreOrden(valor.der);//Der
            }
        }
        public void PreOrden() 
        {
            if (raiz == null) Console.WriteLine("EL ARBOL ESTA VACIO");
            else PreOrden(raiz);
            Console.WriteLine();
        }
        private void InOrden(Nodo valor) //I R D 
        {
            if (valor != null)
            {
                PreOrden(valor.izq);//Izq
                Console.WriteLine(valor.dato + " ");//raiz

                PreOrden(valor.der);//Der
            }
        }
        public void InOrden()
        {
            if (raiz == null) Console.WriteLine("EL ARBOL ESTA VACIO");

            else InOrden(raiz);
            Console.WriteLine();
        }
        private void PosOrden(Nodo valor) //I D R 
        {
            if (valor != null)
            {
                PreOrden(valor.izq);//Izq
                PreOrden(valor.der);//Der
                Console.WriteLine(valor.dato + " ");//raiz

            }
        }
        public void PosOrden()
        {
            if (raiz == null) Console.WriteLine("EL ARBOL ESTA VACIO");

            else PosOrden(raiz);
            Console.WriteLine();
        }
    }
}
