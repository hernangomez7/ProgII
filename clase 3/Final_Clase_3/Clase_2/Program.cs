using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {
        /// <summary>
        /// Conversor de Binario ASCII a Entero y biceversa
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Calculador CalcuObj = new Calculador();
            Console.Title = "Ejercicio Clase 2";
            int key;
            bool continuar = true;
            string stringIngre="";
            //string valor;
            do
            {
                // Menú
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1 - Convertir de Binario a Entero");
                Console.WriteLine("2 - Convertir de Entero a Binario");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Salir");
                Console.ForegroundColor = ConsoleColor.White;
                // Fin Menú

                // Si el valor ingresa por el usuario NO es válido, fuerzo la iteración,
                // salteando el código que está por debajo
                if(!int.TryParse(Console.ReadKey().KeyChar.ToString(), out key))
                    continue;
                Console.WriteLine("");
                // Según la tecla presionada por el usuario...
                switch(key)
                {
                    case 1:
                        Console.WriteLine("Ingrese un valor Binario ASCII a convertir a Entero: ");
                        stringIngre = Console.ReadLine();
                        Console.WriteLine(Conversor.BinarioEntero(stringIngre));
                        CalcuObj.acumular(stringIngre);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un valor Entero a convertir a Binario ASCII: ");
                        int converso;
                        if (int.TryParse(Console.ReadLine(), out converso))
                            Console.WriteLine(Conversor.EnteroBinario(converso));
                        else
                            Console.WriteLine("¡Valor inválido!");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("valor ent:{0}",CalcuObj.getResultadoBinario());
                        Console.ReadKey();
                        continuar = false;
                        break;
                }
                Console.Clear();
            } while(continuar);
        }

        /// <summary>
        /// Si compro 3 o más camisas, deberá retornar un descuento del 20%.
        /// Sino, el descuento será del 10%.
        /// Documentar cada método, estructura repetitiva y cualquier parte del código
        /// que su lectura pudiera prestarse a confusión, según estándares dados en clase
        /// (https://msdn.microsoft.com/es-es/library/ff926074.aspx).
        /// </summary>
        /// <param name="precio">Valor de las camisas</param>
        /// <param name="camisas">Cantidad de camisas</param>
        /// <returns></returns>
        private static string documentame(float precio, int camisas)
        {
            if (camisas >= 3)
            {
                // Calcular descuento del 20%
                float a = (precio * 20) / 100;
                // Aplicar descuento
                float b = precio - a;
                return "DESCUENTO 20% PRECIO ES:  " + b;
            }
            else
            {
                // Calcular descuento del 10%
                float a = (precio * 10) / 100;
                // Aplicar descuento
                float b = precio - a;
                return "DESCUENTO 10% PRECIO ES:  " + b;
            }
        }
    }
}
