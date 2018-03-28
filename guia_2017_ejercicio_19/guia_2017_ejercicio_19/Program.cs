using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_2017_ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringIngresado = "";
            int EnteroIng = 0;
            sumador sumadorUno = new sumador();
            //Console.WriteLine("escribir numero");
            sumadorUno.sumar(42, 42);
            stringIngresado = Console.ReadLine();
            int.TryParse(stringIngresado, out EnteroIng);
            Console.WriteLine("cantidad sumas {0}", sumadorUno.getCantidadSumas());
            Console.ReadKey();
            

        }
    }
}
