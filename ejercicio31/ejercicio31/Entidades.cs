using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ejercicio31
{
    class Cliente
    {
        private static string nombre;
        private static int numero;
        public static Cliente(int numeroIng) 
        {
            nombre = "";
            numero = numeroIng;
        }
        public static Cliente(int numeroIng, string nombreIng)
        {
            nombre = nombreIng;
            numero = numeroIng;
        }
        public static bool operator ==(Cliente cl1, Cliente cl2) 
        {
            bool boolRetorno = false;
            if (cl1.Numero == cl2.Numero)
            {
                boolRetorno = true;
            }
            return boolRetorno;
        }
        public static bool operator !=(Cliente cl1, Cliente cl2)
        {
            bool boolRetorno = false;
            if (cl1.Numero != cl2.Numero)
            {
                boolRetorno = true;
            }
            return boolRetorno;
        }
        private string Nombre//setget
        {
            set
            {
                Cliente.nombre = value;
            }
            get
            {
                return Cliente.nombre;
            }
        }
        private int Numero//setget
        {
            get
            {
                return Cliente.numero;
            }
        }

    }
    class Negocio
    {
        private static PuestoAtencion Caja;
        private static Queue<Cliente> clientes;
        private static string nombre;

        private static Negocio()
        {
            Caja = new PuestoAtencion();
            clientes = new Queue<Cliente>();
            nombre = "";
        }
        private static Negocio(string nombreIng)
        {
            Caja = new PuestoAtencion();
            clientes = new Queue<Cliente>();
            nombre = nombreIng;
        }

        private Cliente Cliente//setget
        {
            set
            {
                clientes.Enqueue(value);
            }
            get
            {
                return clientes.Dequeue();
            }
        }

        public static bool operator ==(Negocio n, Negocio c)
        {
            bool boolRetorno = false;
            if (n.Cliente == c.Cliente)
            {
                boolRetorno = true;
            }
            return boolRetorno;
        }
        public static bool operator !=(Negocio n, Negocio c)
        {
            bool boolRetorno = false;
            if (n.Cliente == c.Cliente)
            {
                boolRetorno = true;
            }
            return boolRetorno;
        }
        public static bool operator +(Negocio n, Negocio c)
        {
            bool boolRetorno = false;
            if(n.Cliente == c.Cliente)
            {
                n.Cliente = c.Cliente;
            }
            return boolRetorno;
        }
    }
    class PuestoAtencion
    {
        public static enum Puesto
        { 
            Caja1,
            Caja2
        }
        private static int numeroActual;
        private static Puesto puesto;

        public static PuestoAtencion()//conts
        {
            numeroActual = 0;
            puesto = 0;
        }
        public static PuestoAtencion(Puesto puestoIng)//conts
        {
            numeroActual = 0;
            puesto = puestoIng;
        }
        private int NumeroActual//setget
        {
            get 
            {
                return ++numeroActual;
            }
        }
        public bool Atender(Cliente cli)
        {
            bool boolRetorno = false;
            Thread.Sleep(5000);
            boolRetorno = true;
            return boolRetorno;
        }

    }
}
