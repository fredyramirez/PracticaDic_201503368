using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDoble.Estructuras.Matriz
{
    class NodoMatrizBidimensional
    {
        NodoMatrizBidimensional anterior, siguiente, arriba, abajo;
        int valor;

        public NodoMatrizBidimensional(int valor)
        {
            anterior = null;
            siguiente = null;
            arriba = null;
            abajo = null;
            this.valor = valor;
        }

        public NodoMatrizBidimensional getAbajo()
        {
            return abajo;
        }

        public void setAbajo(NodoMatrizBidimensional abajo)
        {
            this.abajo = abajo;
        }

        public NodoMatrizBidimensional getAnterior()
        {
            return anterior;
        }

        public void setAnterior(NodoMatrizBidimensional anterior)
        {
            this.anterior = anterior;
        }

        public NodoMatrizBidimensional getArriba()
        {
            return arriba;
        }

        public void setArriba(NodoMatrizBidimensional arriba)
        {
            this.arriba = arriba;
        }

        public NodoMatrizBidimensional getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(NodoMatrizBidimensional siguiente)
        {
            this.siguiente = siguiente;
        }

        public int getValor()
        {
            return valor;
        }

        public void setValor(int valor)
        {
            this.valor = valor;
        }

    }
}
