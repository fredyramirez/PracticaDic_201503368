using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaCircularDoble.Estructuras.Matriz;

namespace ListaCircularDoble.Estructuras.PilaCola
{
    public class Nodo
    {
        Nodo siguiente;
        Nodo anterior;
        MatrizBidimensional matriz;

        internal Nodo Siguiente
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

        internal MatrizBidimensional Matriz
        {
            get
            {
                return matriz;
            }

            set
            {
                matriz = value;
            }
        }

        internal Nodo Anterior
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

        public Nodo(MatrizBidimensional matriz)
        {
            Matriz = matriz;
        }
    }
}
