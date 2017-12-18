﻿using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace ListaCircularDoble.Estructuras.Matriz
{
    public class MatrizBidimensional
    {
        public int altura, anchura;
        String dot;
        ListaMatrizBidimensional ultima;

        public int getAltura()
        {
            return altura;
        }

        public int getAnchura()
        {
            return anchura;
        }

        public MatrizBidimensional(int altura, int anchura)
        {
            dot = "";
            this.altura = altura;
            this.anchura = anchura;
            if (anchura > 0 && altura > 0)
            {
                ultima = new ListaMatrizBidimensional(anchura);
                for (int i = 1; i < altura; i++)
                {
                    ListaMatrizBidimensional aux = new ListaMatrizBidimensional(anchura);
                    NodoMatrizBidimensional recorredorAux = aux.getPrimero();
                    NodoMatrizBidimensional recorredorUltima = ultima.getPrimero();
                    while (recorredorAux != null && recorredorUltima != null)
                    {
                        recorredorAux.setArriba(recorredorUltima);
                        recorredorUltima.setAbajo(recorredorAux);
                        recorredorUltima = recorredorUltima.getSiguiente();
                        recorredorAux = recorredorAux.getSiguiente();
                    }
                    ultima = aux;
                }
            }
        }

        public void setValor(int valor, int fila, int columna)
        {
            if (fila < altura && columna < anchura)
            {
                NodoMatrizBidimensional cabeza = ultima.getPrimero();
                while (cabeza.getArriba() != null)
                    cabeza = cabeza.getArriba();

                for (int i = 0; i < fila; i++)
                {
                    cabeza = cabeza.getAbajo();
                }

                for (int i = 0; i < columna; i++)
                {
                    cabeza = cabeza.getSiguiente();
                }
                cabeza.setValor(valor);
            }
        }

        public int getValor(int fila, int columna)
        {
            NodoMatrizBidimensional cabeza = ultima.getPrimero();
            while (cabeza.getArriba() != null)
            {
                cabeza = cabeza.getArriba();
            }
            for (int i = 0; i < fila; i++)
            {
                cabeza = cabeza.getAbajo();
            }

            for (int i = 0; i < columna; i++)
            {
                cabeza = cabeza.getSiguiente();
            }
            return cabeza.getValor();
        }



        public void grafica(String nombreArchivo)
        {
            dot = "digraph lista{ \n";
            dot += "rankdir = TB; \n";
            dot += "node [shape = record];\n";
            dot += "Matriz[shape = record,label=\"{";
            for (int i = 0; i < altura - 1; i++)
            {
                dot += "{";
                for (int j = 0; j < anchura - 1; j++)
                {
                    dot += "{" + getValor(i, j) + "}|";
                }
                dot += "{" + getValor(i, anchura - 1) + "}";
                dot += "}|";
            }
            dot += "{";
            for (int j = 0; j < anchura - 1; j++)
            {
                dot += "{" + getValor(altura - 1, j) + "}|";
            }
            dot += "{" + getValor(altura - 1, anchura - 1) + "}";
            dot += "}";
            dot += "}\"]; \n";
            dot += "}";
            StreamWriter fichero = null;
            try
            {
                fichero = new StreamWriter(nombreArchivo + ".dot");
                fichero.Write(dot);
            }
            catch (Exception e) { }
            finally
            {
                try
                {
                    if (null != fichero)
                        fichero.Close();
                }
                catch (Exception e2) { }
            }
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Program Files (x86)\\Graphviz\\bin\\dot.exe");
                startInfo.Arguments = "-Tpng  " + nombreArchivo + ".dot  -o  " + nombreArchivo + ".png ";
                Process.Start(startInfo);
                Thread.Sleep(1000);
                Process.Start(nombreArchivo + ".png ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en generar archivo dot " + ex.ToString());
            }
        }

        public int getSuma()
        {
            int suma = 0;
            for (int i = 0; i < altura - 1; i++)
                for (int j = 0; j < anchura - 1; j++)
                    suma = suma + getValor(i, j)+ getValor(i, anchura - 1);
            for (int j = 0; j < anchura - 1; j++)
                suma = suma + getValor(altura - 1, j);
            suma = suma + getValor(altura - 1, anchura - 1);
            return suma;
        }

    }
}
