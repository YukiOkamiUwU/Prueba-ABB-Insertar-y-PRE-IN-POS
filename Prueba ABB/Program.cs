using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_ABB
{
    internal class Program
    {static public Arbol arbol=new Arbol();
        static void Main(string[] args)
        {

            int op = 0;
            do
            {
                Console.WriteLine("BIENVENIDO AL PROGRAMA");
                Console.WriteLine("1. Insertar sueldo");
                Console.WriteLine("2.Listar PreOrden");
                Console.WriteLine("3.Listar InOrden");
                Console.WriteLine("4.Listar PosOrden");
                Console.WriteLine("Ingrese opcion: ");
                op=int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:InsetarSueldo(); Console.ReadKey();Console.Clear(); break;
                    case 2: PreOrden(); Console.ReadKey(); Console.Clear(); break;
                    case 3: InOrden(); Console.ReadKey(); Console.Clear(); break;
                    case 4: PosOrden(); Console.ReadKey(); Console.Clear(); break;
                    default:Console.WriteLine("SALISTE"); break;



                }


            } while (op!=4);
            Console.ReadKey();
        }
        static void InsetarSueldo()
        {
            Console.WriteLine("Inserte Sueldo: ");
            int sueldo=int.Parse(Console.ReadLine()) ;

            arbol.Insertar(sueldo);
        }
        static void PreOrden()
        { 
            arbol.PreOrden();
        
        }
        static void InOrden()
        {
            arbol.InOrden();

        }
        static void PosOrden()
        {
            arbol.PosOrden();

        }
       
    }
}
