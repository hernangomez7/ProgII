using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometría
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Punto
    {
        private int x;
        private int y;
        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }

    }
    class Rectangulo
    {
        private float areaRectangulo;
        private float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice2;
        Punto vertice4;
        public Rectangulo()
        {
            this.areaRectangulo = 0;
            this.perimetro = 0;
        }

        public int Rectangulo(Punto vertice1,Punto vertice3)
        {
            double verticeAux1 = Convert.ToDouble(vertice1.getX());
            double verticeAux2 = Convert.ToDouble(vertice3.getY());
            double resultadoDoble;
            int retornoInt;
            //resultado = (vertice1.getX() * vertice1.getX()) + (vertice3.getY() * vertice3.getY());
            resultadoDoble = Math.Sqrt(Math.Pow(verticeAux1, 2) + Math.Pow(verticeAux2, 2));
            retornoInt = Convert.ToInt32(Math.Abs(resultadoDoble));
            return retornoInt;
        }
        public float area()
        {
            float returnFloat =4;

            return returnFloat;
        }
        public float getArea() 
        {
            return areaRectangulo;
        }
        public float getPerimetro()
        {
            return perimetro;
        }

    }
}
namespace PruevaGeometría
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
