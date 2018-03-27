using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_2
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
            Console.Title = "Sin usuario";
            string usuario = "";
            string titulo = "";
            Console.WriteLine("escriba el nombre de usuario 1");
            usuario = Console.ReadLine();
            Calculador CalculadorUno = new Calculador(usuario);
            Console.Clear();
            Console.WriteLine("escriba el nombre de usuario 2");
            usuario = Console.ReadLine();
            Calculador CalculadorDos = new Calculador(usuario);
            Console.Clear();
            Console.WriteLine("escriba el nombre de usuario 3");
            usuario = Console.ReadLine();
            Calculador CalculadorTres = new Calculador(usuario);
            Console.Clear();
            int usuarioActual = 0;
            int key;
            bool continuar = true;
            string stringIngre="";
            //string valor;
            do
            {
                // Menú
                //Console.ForegroundColor = ConsoleColor.Gray;
                // if (usuarioActual == 0) titulo += CalculadorUno.getUsuario();
                if (usuarioActual == 0) titulo = "usuario actual " + CalculadorUno.getUsuario();
                else if (usuarioActual == 1) titulo = "usuario actual " + CalculadorDos.getUsuario();
                else titulo = "usuario actual " + CalculadorTres.getUsuario();
                Console.Title = titulo;// "usuario actual {0}",CalculadorUno.getUsuario;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1 - Convertir de Binario a Entero");
                Console.WriteLine("2 - Convertir de Entero a Binario");
                Console.WriteLine("3 - Mostrar acumulado");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("4 - Cambiar usuario");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("5 - Salir");
                Console.ForegroundColor = ConsoleColor.White;
                // Fin Menú

                // Si el valor ingresa por el usuario NO es válido, fuerzo la iteración,
                // salteando el código que está por debajo
                if(!int.TryParse(Console.ReadKey().KeyChar.ToString(), out key))
                    continue;
                Console.WriteLine("");
                // Según la tecla presionada por el usuario...
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Ingrese un valor Binario ASCII a convertir a Entero: ");
                        stringIngre = Console.ReadLine();
                        Console.WriteLine(Conversor.BinarioEntero(stringIngre));
                        if (usuarioActual == 0) CalculadorUno.acumular(stringIngre);
                        else if (usuarioActual == 1) CalculadorDos.acumular(stringIngre);
                        else CalculadorTres.acumular(stringIngre);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un valor Entero a convertir a Binario ASCII: ");
                        int converso;
                        if (int.TryParse(Console.ReadLine(), out converso))
                            Console.WriteLine(Conversor.EnteroBinario(converso));
                        else
                            Console.WriteLine("¡Valor inválido!");
                        if (usuarioActual == 0) CalculadorUno.acumularInt(converso);
                        else if (usuarioActual == 1) CalculadorDos.acumularInt(converso);
                        else CalculadorTres.acumularInt(converso);
                        Console.ReadKey();
                        break;
                    case 3://mostrar
                           //Console.WriteLine("valor ent:{0}",CalculadorUno.getResultadoBinario());
                        Console.WriteLine("{0} {1}", CalculadorUno.getUsuario(), CalculadorUno.getResultadoEntero());
                        Console.WriteLine("{0} {1}", CalculadorDos.getUsuario(), CalculadorDos.getResultadoEntero());
                        Console.WriteLine("{0} {1}", CalculadorTres.getUsuario(), CalculadorTres.getResultadoEntero());
                        Console.ReadKey();
                        break;
                    case 4://cambiar
                        //Console.WriteLine("valor ent:{0}", CalculadorUno.getResultadoBinario());
                        Console.WriteLine("0_usario {0}", CalculadorUno.getUsuario());
                        Console.WriteLine("1_usario {0}", CalculadorDos.getUsuario());
                        Console.WriteLine("2_usario {0}", CalculadorTres.getUsuario());
                        if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out usuarioActual))
                        {
                            Console.Clear();
                            if (usuarioActual == 0) Console.WriteLine("usario actual {0}", CalculadorUno.getUsuario());
                            else if (usuarioActual == 1) Console.WriteLine("usario actual {0}", CalculadorDos.getUsuario());
                            else Console.WriteLine("usario actual {0}", CalculadorTres.getUsuario());
                            Console.ReadKey();
                        }
                        break;
                    case 5://fuck off
                        Console.WriteLine("valor ent:{0}", CalculadorUno.getResultadoBinario());
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
