using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCircularDoble.Estructuras.PilaCola
{
    public class Pila
    {
        private Nodo primero;
        private Nodo ultimo;

        public void push(Nodo nuevo)
        {
            if (this.primero == null)
            {
                this.primero = this.ultimo = nuevo;
            }
            else
            {
                Nodo actual = this.ultimo;
                while (actual.Anterior != null)
                {
                    actual = actual.Anterior;
                }
                actual.Anterior = nuevo;
                this.primero = nuevo;
            }
        }

        public Nodo pop()
        {
            Nodo actual = this.ultimo;
            Nodo anterior = this.ultimo;
            if (this.ultimo == this.primero)
            {
                Nodo retorno = primero;
                this.ultimo = null;
                this.primero = null;
                return retorno;
            }
            else
            {
                while (actual.Anterior != null)
                {
                    anterior = actual;
                    actual = actual.Anterior;
                }
                Nodo retorno = anterior.Anterior;
                anterior.Anterior = null;
                this.primero = anterior;
                return retorno;
            }
        }

        public Nodo peek()
        {
            Nodo actual = this.ultimo;
            Nodo anterior = this.ultimo;
            if (this.ultimo == this.primero)
                return primero;
            else
            {
                while (actual.Anterior != null)
                {
                    anterior = actual;
                    actual = actual.Anterior;
                }
                return anterior.Anterior; 
            }
        }

        public bool estaVacia()
        {
            return primero == null;
        }

        public string graphviz(int numero)
        {
            string dot = "digraph lista{\nrankdir = LR;\ninicio [shape = plaintext, label = \"Fondo\"];\nnull [shape = plaintext, label = \"Cima\"];\n";
            String str1 = "inicio -> struct0;\n";
            String str = "";
            Nodo actual = this.ultimo;
            int i = 0;
            while (actual != null)
            {
                str = str + " -> struct" + i + "";
                dot+="struct" + i + " [shape = record,label=\"{<f0> |<f1>" + actual.Matriz.getSuma() + " |<f2> }\"];\n";
                actual = actual.Anterior;
                ++i;
            }
            str = str + ";\nlabel = \"Pila\";\n";
            str = str.Substring(4);
            str1 = str1 + "struct" + (i - 1) + " -> null;\n";
            if (this.primero != null)
            {
                dot += str + str1;
            }
            else
            {
                dot += "inicio -> null\n;";
            }
            dot += "}";
            return dot;
        }

    }
}
