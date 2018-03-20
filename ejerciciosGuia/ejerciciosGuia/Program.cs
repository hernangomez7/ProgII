using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosGuia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado[5];
            string stringIngresado;
            //do(int.tryParse(palabra,out aux))
            

            Console.WriteLine("Escriba un numero ");
            stringIngresado = Console.ReadLine();
            numeroIngresado = int.Parse(stringIngresado);

            //Console.WriteLine("{0} ", numeroIngresado);

            Console.ReadKey();
        }
    }
}
