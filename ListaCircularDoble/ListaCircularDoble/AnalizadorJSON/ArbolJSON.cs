using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDoble.AnalizadorJSON
{
    public class ArbolJSON
    {
        public Archivo archivo { get; set; }
    }
    public class Archivo
    {
        public Pila pila { get; set; }
        public Cola cola { get; set; }
    }

    public class Pila
    {
        public Matrices matrices { get; set; }
    }

    public class Cola
    {
        public Matrices matrices { get; set; }
    }

    public class Matrices
    {
        public List<Matriz> matriz { get; set; }
    }

    public class Matriz
    {
        public int size_x { get; set; }
        public int size_y { get; set; }
        public Valores valores { get; set; }
    }

    public class Valores
    {
        public List<Valor> valor { get; set; }
    }

    public class Valor
    {
        public int pos_x { get; set; }
        public int pos_y { get; set; }
        public int dato { get; set; }
    }
}
