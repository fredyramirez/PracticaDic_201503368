using ListaCircularDoble.Estructuras.PilaCola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDoble.Estructuras.ListaUsuarios
{
    public class NodoUsuario
    {
        string nombre;
        string contrasenia;
        NodoUsuario siguiente;
        NodoUsuario anterior;
        Pila pila;
        Cola cola;
        

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                contrasenia = value;
            }
        }

        public NodoUsuario Siguiente
        {
            get
            {
                return siguiente;
            }

            set
            {
                siguiente = value;
            }
        }

        public NodoUsuario Anterior
        {
            get
            {
                return anterior;
            }

            set
            {
                anterior = value;
            }
        }

        internal Pila Pila
        {
            get
            {
                return pila;
            }

            set
            {
                pila = value;
            }
        }

        internal Cola Cola
        {
            get
            {
                return cola;
            }

            set
            {
                cola = value;
            }
        }

        public NodoUsuario(string nombre, string contrasenia)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            pila = new Pila();
            cola = new Cola();
        }
    }
}
