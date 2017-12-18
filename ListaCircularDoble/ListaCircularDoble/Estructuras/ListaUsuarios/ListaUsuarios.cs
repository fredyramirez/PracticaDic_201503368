using ListaCircularDoble.Estructuras.PilaCola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDoble.Estructuras.ListaUsuarios
{
    public class ListaUsuarios
    {
        NodoUsuario inicio;

        public ListaUsuarios()
        {
            inicio = null;
        }

        public bool estaVacia()
        {
            return inicio == null;
        }

        public void insertarFinal(string nombre, string contrasenia)
        {
            NodoUsuario nuevo = new NodoUsuario(nombre, contrasenia);
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.Siguiente = inicio;
                inicio.Anterior = inicio;
            }
            else
            {
                NodoUsuario aux = inicio;
                while (aux.Siguiente != inicio)
                    aux = aux.Siguiente;
                aux.Siguiente = nuevo;
                nuevo.Anterior = aux;
                nuevo.Siguiente = inicio;
                inicio.Anterior = nuevo;
            }
        }

        public void mostrarUsuarios()
        {
            if (inicio == null)
                Console.WriteLine("<-->NULL<-->");
            else
            {
                NodoUsuario aux = inicio;
                Console.WriteLine("<--> Inicio");
                do
                {
                    Console.WriteLine(" <--> " + aux.Nombre);
                    aux = aux.Siguiente;
                } while (aux != inicio);
                Console.WriteLine(" <-->NULL<-->");
            }
        }

        public bool existeUsuario(string nombre)
        {
            NodoUsuario aux = inicio;
            if (aux == null)
                return false;
            while ((aux.Siguiente != inicio) && !(esIgual(aux.Nombre, nombre)))
                aux = aux.Siguiente;
            return esIgual(aux.Nombre, nombre);
        }

        public NodoUsuario getUsuario(string nombre)
        {
            NodoUsuario aux = inicio;
            if (aux == null)
                return null;
            while ((aux.Siguiente != inicio) && !(esIgual(aux.Nombre, nombre)))
                aux = aux.Siguiente;
            return esIgual(aux.Nombre, nombre) ? aux : null;
        }

        public NodoUsuario setUsuario(NodoUsuario nuevo)
        {
            NodoUsuario aux = inicio;
            if (aux == null)
                return null;
            while ((aux.Siguiente != inicio))
                aux = aux.Siguiente;
            
            return esIgual(aux.Nombre, nuevo.Nombre) ? aux : null;
        }

        public bool credencialesValidas(string nombre, string contrasenia)
        {
            NodoUsuario aux = inicio;
            if (aux == null)
                return false;
            while ((aux.Siguiente != inicio) && !(esIgual(aux.Nombre, nombre)) && !(esIgual(aux.Contrasenia, contrasenia)))
                aux = aux.Siguiente;
            return esIgual(aux.Nombre, nombre) && esIgual(aux.Contrasenia, contrasenia);
        }

        bool esIgual(string a, string b)
        {
            return a.Equals(b, StringComparison.InvariantCultureIgnoreCase);
        }

        public void actualizarUsuario(string nombre, Pila pila, Cola cola)
        {
            if (existeUsuario(nombre))
            {
                NodoUsuario aux = inicio;
                while (aux.Nombre != nombre)
                    aux = aux.Siguiente;
                aux.Pila = pila;
                aux.Cola = cola;
            }
        }

        public void eliminaValor(string nombre)
        {
            if (inicio != null)
            {
                NodoUsuario aux = inicio;
                NodoUsuario ant = null;
                while (aux.Siguiente != inicio)
                {
                    if (esIgual(aux.Nombre, nombre))
                    {
                        if (ant == null)
                        {
                            if (aux.Siguiente == inicio)
                                inicio = null;
                            else
                            {
                                ant = aux.Anterior;
                                ant.Siguiente = aux.Siguiente;
                                aux = aux.Siguiente;
                                aux.Anterior = ant;
                                inicio = aux;
                                ant = null;
                            }
                        }
                        else
                        {
                            aux.Anterior = null;
                            ant.Siguiente = aux.Siguiente;
                            aux = aux.Siguiente;
                            aux.Anterior = ant;
                        }
                    }
                    else
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }
                }
            }
        }

    }
}
