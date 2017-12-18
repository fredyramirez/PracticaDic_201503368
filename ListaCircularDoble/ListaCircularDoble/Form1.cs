using System;
using System.Windows.Forms;
using ListaCircularDoble.Estructuras.ListaUsuarios;
using System.IO;
using Newtonsoft.Json;
using ListaCircularDoble.AnalizadorJSON;
using ListaCircularDoble.Estructuras.Matriz;
using ListaCircularDoble.Estructuras.PilaCola;
using System.Diagnostics;
using System.Threading;

namespace ListaCircularDoble
{
    public partial class Form1 : Form
    {
        ListaUsuarios listaUsuarios;
        NodoUsuario usuarioActual;
        int correlativo;
        public Form1()
        {
            InitializeComponent();
            listaUsuarios = new ListaUsuarios();
            ((Button)tabControl.TabPages[3].Controls["btnAbrir"]).Visible = false;
            correlativo = 0;
            usuarioActual = null;
            btnCerrarSesion.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string nombre = ((TextBox)tabControl.SelectedTab.Controls["txtUserCreate"]).Text;
            string contrasenia = ((TextBox)tabControl.SelectedTab.Controls["txtPassCreate"]).Text;
            if (listaUsuarios.existeUsuario(nombre))
                MessageBox.Show("Error, el nombre de usuario que ingreso ya existe, intente de nuevo.");
            else
            {
                listaUsuarios.insertarFinal(nombre, contrasenia);
                MessageBox.Show("Usuario " + nombre + " creado con exito!");
                ((TextBox)tabControl.SelectedTab.Controls["txtUserCreate"]).Text = string.Empty;
                ((TextBox)tabControl.SelectedTab.Controls["txtPassCreate"]).Text = string.Empty;
                tabControl.SelectedIndex = 1;
            }
            listaUsuarios.mostrarUsuarios();
        }

        string cargaArchivo()
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JSON Files|*.json";
            abrir.Title = "Select a cursor File json";
            if (abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(abrir.FileName);
                string contenido = sr.ReadToEnd();
                ((RichTextBox)tabControl.SelectedTab.Controls["txtEditor"]).Text = contenido;
                sr.Close();
                return contenido;
            }
            return "";
        }

        ArbolJSON analizarJSON(string contenido)
        {
            return JsonConvert.DeserializeObject<ArbolJSON>(contenido);

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = ((TextBox)tabControl.SelectedTab.Controls["txtUser"]).Text;
            string contrasenia = ((TextBox)tabControl.SelectedTab.Controls["txtPassword"]).Text;
            if (listaUsuarios.credencialesValidas(nombre, contrasenia))
            {
                MessageBox.Show("Logueo exitoso!");
                ((TextBox)tabControl.SelectedTab.Controls["txtUser"]).Text = string.Empty;
                ((TextBox)tabControl.SelectedTab.Controls["txtPassword"]).Text = string.Empty;
                tabControl.SelectedIndex = 3;
                ((Button)tabControl.TabPages[3].Controls["btnAbrir"]).Visible = true;
                usuarioActual = listaUsuarios.getUsuario(nombre);
                btnCerrarSesion.Visible = true;
            }
            else
                MessageBox.Show("Error, las credenciales ingresadas no son validas.");
            listaUsuarios.mostrarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = ((TextBox)tabControl.SelectedTab.Controls["txtEliminarUsuario"]).Text;
            if (listaUsuarios.existeUsuario(nombre))
                listaUsuarios.eliminaValor(nombre);
            else
                MessageBox.Show("Error, el usuario que intenta ingresar no existe, intente de nuevo.");
            listaUsuarios.mostrarUsuarios();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string contenido = cargaArchivo();
            ArbolJSON arbol = analizarJSON(contenido);
            foreach (Matriz mat in arbol.archivo.cola.matrices.matriz)
            {
                MatrizBidimensional matrix = new MatrizBidimensional(mat.size_y, mat.size_x);
                foreach (Valor elemento in mat.valores.valor)
                {
                    matrix.setValor(elemento.dato, elemento.pos_y, elemento.pos_x);
                }
                usuarioActual.Cola.queue(new Nodo(matrix));
            }
            foreach (Matriz mat in arbol.archivo.pila.matrices.matriz)
            {
                MatrizBidimensional matrix = new MatrizBidimensional(mat.size_y, mat.size_x);
                foreach (Valor elemento in mat.valores.valor)
                {
                    matrix.setValor(elemento.dato, elemento.pos_y, elemento.pos_x);
                }
                usuarioActual.Pila.push(new Nodo(matrix));
            }
            Console.Write(usuarioActual);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Error, es necesario estar logueado para mostrar los reportes.");
            }
            else
            {
                listaUsuarios.actualizarUsuario(usuarioActual.Nombre, usuarioActual.Pila, usuarioActual.Cola);
                MessageBox.Show("Se ha cerrado la sesion y guardado los cambios del usuario: " + usuarioActual.Nombre + "!");
                usuarioActual = null;
                ((Button)tabControl.TabPages[3].Controls["btnAbrir"]).Visible = false;
                btnCerrarSesion.Visible = false;
            }
        }

        private void btnRepPila_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Error, es necesario estar logueado para mostrar los reportes.");
            }
            else
            {
                string dot = usuarioActual.Pila.graphviz(correlativo);
                StreamWriter fichero = null;
                try
                {
                    fichero = new StreamWriter("ReportePila" + correlativo + ".dot");
                    fichero.Write(dot);
                }
                catch (Exception ex) { }
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
                    startInfo.Arguments = "-Tpng  " + "ReportePila" + correlativo + ".dot  -o  " + "ReportePila" + correlativo + ".png ";
                    Process.Start(startInfo);
                    Thread.Sleep(1000);
                    Process.Start("ReportePila" + correlativo + ".png ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en generar archivo dot " + ex.ToString());
                }
                correlativo++;
            }
        }

        private void btnRepCola_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Error, es necesario estar logueado para mostrar los reportes.");
            }
            else
            {
                string dot = usuarioActual.Cola.graphviz(correlativo);
                StreamWriter fichero = null;
                try
                {
                    fichero = new StreamWriter("ReporteCola" + correlativo + ".dot");
                    fichero.Write(dot);
                }
                catch (Exception ex) { }
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
                    startInfo.Arguments = "-Tpng  " + "ReporteCola" + correlativo + ".dot  -o  " + "ReporteCola" + correlativo + ".png ";
                    Process.Start(startInfo);
                    Thread.Sleep(1000);
                    Process.Start("ReporteCola" + correlativo + ".png ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en generar archivo dot " + ex.ToString());
                }
                correlativo++;
            }
        }

        private void btnPeekPila_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Error, es necesario estar logueado para mostrar los reportes.");
            }
            else
            {
                usuarioActual.Pila.peek().Matriz.grafica("ReporteMatrizPila" + correlativo);
            }
        }

        private void btnPeekCola_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Error, es necesario estar logueado para mostrar los reportes.");
            }
            else
            {
                usuarioActual.Cola.peek().Matriz.grafica("ReporteMatrizCola" + correlativo);
            }
        }

        MatrizBidimensional multiplicarMatrices(MatrizBidimensional firstMatrix, MatrizBidimensional secondMatrix, int r1, int c1, int r2, int c2)
        {
            if (c1 != r2)
                return null;
            MatrizBidimensional product = new MatrizBidimensional(r1, c2);
            for (int i = 0; i < r1; i++)
                for (int j = 0; j < c2; j++)
                    for (int k = 0; k < c1; k++)
                        product.setValor(product.getValor(i, j) + firstMatrix.getValor(i, k) * secondMatrix.getValor(k, j), i, j);
            return product;
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Error, es necesario estar logueado para mostrar los reportes.");
            }
            else
            {
                if (usuarioActual.Pila.estaVacia() || usuarioActual.Cola.estaVacia())
                {
                    MessageBox.Show("Error, una o ambas estructuras estan vacias.");
                }
                else
                {
                    MatrizBidimensional a = usuarioActual.Pila.pop().Matriz;
                    MatrizBidimensional b = usuarioActual.Cola.pop().Matriz;
                    MatrizBidimensional result = multiplicarMatrices(a, b, a.getAltura(), a.getAnchura(), b.getAltura(), b.getAnchura());
                    if (result == null)
                    {
                        MessageBox.Show("Error, las dimensiones entre las matrices no son las correctas.");
                    }
                    else
                        result.grafica("ReporteMatriz" + correlativo);
                }
            }
        }
    }
}
