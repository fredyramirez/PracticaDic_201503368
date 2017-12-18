using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDoble.Estructuras.Matriz
{
    class ListaMatrizBidimensional
    {
        private NodoMatrizBidimensional primero;

        public NodoMatrizBidimensional getPrimero()
        {
            return primero;
        }

        public ListaMatrizBidimensional(int anchura)
        {
            primero = null;
            for (int i = 0; i < anchura; i++)
            {
                push();
            }
        }

        private bool estaVacia()
        {
            return primero == null;
        }

        public void push()
        {
            if (estaVacia())
            {
                primero = new NodoMatrizBidimensional(0);
            }
            else
            {
                NodoMatrizBidimensional nuevo = new NodoMatrizBidimensional(0);
                nuevo.setSiguiente(primero);
                primero = nuevo;
            }
        }
    }
}
