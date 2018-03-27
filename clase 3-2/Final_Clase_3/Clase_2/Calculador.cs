using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_2
{
    class Calculador
    {
        private int acumulador;
        private string usuario;
        public Calculador( string usuario)
        {
            this.acumulador = 0;
            this.usuario = usuario;
        }
        
        public void acumular(string adicionString)//: void recibirá un binario en formato ASCII y lo acumulará como entero en el atributo acumulador
        {
            acumulador += Conversor.BinarioEntero(adicionString);
        }
        public void acumularInt(int adicionInt)//: void recibirá un binario en formato ASCII y lo acumulará como entero en el atributo acumulador
        {
            acumulador += adicionInt;
        }
        public string getResultadoBinario()//string retornará la variable acumulador convertida a binario.
        {
            return Conversor.EnteroBinario(acumulador);
        }
        public int getResultadoEntero()//int retornará la variable acumulador Siempre que se cargue un binario, deberá realizar la suma en Calculador a través del método acumular.
        {
            return acumulador;
        }
        public string getUsuario()//string retorna nombre de usuario
        {
            return usuario;
        }


    }
}
