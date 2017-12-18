using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDoble.Estructuras.PilaCola
{
    public class Cola
    {
        Nodo primero, ultimo;

        public void queue(Nodo nodo)
        {
            if (estaVacia())
            {
                primero = nodo;
                ultimo = nodo;
            }
            else
            {
                ultimo.Siguiente = nodo;
                ultimo = ultimo.Siguiente;
            }
        }

        public Nodo pop()
        {
            if (estaVacia())
                return null;
            else
            {
                Nodo nodo = primero;
                primero = primero.Siguiente;
                return nodo;
            }
        }

        public Nodo peek()
        {
            if (estaVacia())
                return null;
            else
                return primero;
        }

        public bool estaVacia()
        {
            return primero == null;
        }

        public string graphviz(int numero)
        {
            string dot = "digraph lista{\nrankdir = LR;\ninicio [shape = plaintext, label = \"inicio\"];\nnull [shape = plaintext, label = \"null\"];\n";
            String str1 = "inicio -> struct0;\n";
            String str = "";
            Nodo actual = this.primero;
            int i = 0;
            while (actual != null)
            {
                str = str + " -> struct" + i + "";
                int suma = actual.Matriz.getSuma();
                dot +="struct" + i + " [shape = record,label=\"{<f0> |<f1>" + suma+ " |<f2> }\"];\n";
                actual = actual.Siguiente;
                ++i;
            }
            str = str + ";\nlabel = \"Cola\";\n";
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
