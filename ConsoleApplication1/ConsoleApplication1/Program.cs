using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int NumberRattle = 45;
            bool entroFlag = false;
            List<int>nombre= new List<int>();
            //Console.Write("{0},{1}+{0}", 4, NumberRattle);
            nombre.Add(1);
            nombre.Add(2);
            nombre.Add(3);
            nombre.Add(4);

           
            /*for (int i=0; i < nombre.Count; i++) {
                nombre.Add(i);
            }
            Console.Write("{0}", auxNombre);*/
            for (int i=0; i < nombre.Count; i++) {
                Console.WriteLine("numero: {0}", nombre[i]);
                if (entroFlag == false)
                {
                    nombre.Remove(nombre[0]);
                    entroFlag = true;
                } 
            }
            Console.ReadKey();
        }
    }
}
