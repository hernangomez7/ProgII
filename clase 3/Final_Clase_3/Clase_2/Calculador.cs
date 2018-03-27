using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Calculador
    {
        private static int acumulador;
        public Calculador()
        {
            acumulador = 0;
        }
        
        public void acumular(string adicionString)//: void recibirá un binario en formato ASCII y lo acumulará como entero en el atributo acumulador
        {
            acumulador += Conversor.BinarioEntero(adicionString);
        }
        public string getResultadoBinario()//string retornará la variable acumulador convertida a binario.
        {
            return Conversor.EnteroBinario(acumulador);
        }
        public int getResultadoEntero()//int retornará la variable acumulador Siempre que se cargue un binario, deberá realizar la suma en Calculador a través del método acumular.
        {
            return acumulador;
        }


    }
}
