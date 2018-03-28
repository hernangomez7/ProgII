using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_2017_ejercicio_19
{
    class sumador
    {
        int cantidadSumas;
        public sumador(int valorInicial)//contr
        {
            this.cantidadSumas = valorInicial;
        }
        public sumador()//contr
        {
            this.cantidadSumas = 0;
        }
        public long sumar(long a,long b)
        {
            cantidadSumas += 1;
            long returnLong = 0;
            returnLong = a + b;
            return returnLong;
        }
        public string sumar(string a,string b)
        {
            cantidadSumas += 1;
            string returnString = "";
            returnString += a;
            returnString += b;
            return returnString;
        }
        public int getCantidadSumas()
        {
            return cantidadSumas;
        }
        
        public static long operator +(sumador a, sumador b)
        {
            return a.cantidadSumas + b.cantidadSumas;
        }
        public static bool operator |(sumador a, sumador b)
        {
            if (a.cantidadSumas == b.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
