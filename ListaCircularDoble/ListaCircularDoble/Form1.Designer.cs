namespace ListaCircularDoble
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSignIn = new System.Windows.Forms.TabPage();
            this.txtUserCreate = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassCreate = new System.Windows.Forms.TextBox();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarUsuario = new System.Windows.Forms.TextBox();
            this.tabCarga = new System.Windows.Forms.TabPage();
            this.btnPeekCola = new System.Windows.Forms.Button();
            this.btnPeekPila = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnRepPila = new System.Windows.Forms.Button();
            this.btnRepCola = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabSignIn.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.tabCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(297, 120);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(116, 23);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(297, 164);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(116, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(450, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 27);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSignIn);
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabEliminar);
            this.tabControl.Controls.Add(this.tabCarga);
            this.tabControl.Location = new System.Drawing.Point(14, 47);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(805, 356);
            this.tabControl.TabIndex = 3;
            // 
            // tabSignIn
            // 
            this.tabSignIn.Controls.Add(this.txtUserCreate);
            this.tabSignIn.Controls.Add(this.btnSignIn);
            this.tabSignIn.Controls.Add(this.txtPassCreate);
            this.tabSignIn.Location = new System.Drawing.Point(4, 24);
            this.tabSignIn.Name = "tabSignIn";
            this.tabSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignIn.Size = new System.Drawing.Size(797, 328);
            this.tabSignIn.TabIndex = 1;
            this.tabSignIn.Text = "Registrarse";
            this.tabSignIn.UseVisualStyleBackColor = true;
            // 
            // txtUserCreate
            // 
            this.txtUserCreate.Location = new System.Drawing.Point(276, 147);
            this.txtUserCreate.Name = "txtUserCreate";
            this.txtUserCreate.Size = new System.Drawing.Size(116, 23);
            this.txtUserCreate.TabIndex = 3;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(429, 144);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(87, 27);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Registrar";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassCreate
            // 
            this.txtPassCreate.Location = new System.Drawing.Point(276, 190);
            this.txtPassCreate.Name = "txtPassCreate";
            this.txtPassCreate.PasswordChar = '*';
            this.txtPassCreate.Size = new System.Drawing.Size(116, 23);
            this.txtPassCreate.TabIndex = 4;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.txtUser);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Location = new System.Drawing.Point(4, 24);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(797, 328);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.btnEliminar);
            this.tabEliminar.Controls.Add(this.txtEliminarUsuario);
            this.tabEliminar.Location = new System.Drawing.Point(4, 24);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Size = new System.Drawing.Size(797, 328);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "Eliminar Usuario";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(244, 159);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(227, 27);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminarUsuario
            // 
            this.txtEliminarUsuario.Location = new System.Drawing.Point(244, 111);
            this.txtEliminarUsuario.Name = "txtEliminarUsuario";
            this.txtEliminarUsuario.Size = new System.Drawing.Size(228, 23);
            this.txtEliminarUsuario.TabIndex = 0;
            // 
            // tabCarga
            // 
            this.tabCarga.Controls.Add(this.btnPeekCola);
            this.tabCarga.Controls.Add(this.btnPeekPila);
            this.tabCarga.Controls.Add(this.btnAbrir);
            this.tabCarga.Controls.Add(this.txtEditor);
            this.tabCarga.Location = new System.Drawing.Point(4, 24);
            this.tabCarga.Name = "tabCarga";
            this.tabCarga.Size = new System.Drawing.Size(797, 328);
            this.tabCarga.TabIndex = 3;
            this.tabCarga.Text = "Carga de archivo";
            this.tabCarga.UseVisualStyleBackColor = true;
            // 
            // btnPeekCola
            // 
            this.btnPeekCola.Location = new System.Drawing.Point(606, 92);
            this.btnPeekCola.Name = "btnPeekCola";
            this.btnPeekCola.Size = new System.Drawing.Size(168, 35);
            this.btnPeekCola.TabIndex = 3;
            this.btnPeekCola.Text = "Peek Cola";
            this.btnPeekCola.UseVisualStyleBackColor = true;
            this.btnPeekCola.Click += new System.EventHandler(this.btnPeekCola_Click);
            // 
            // btnPeekPila
            // 
            this.btnPeekPila.Location = new System.Drawing.Point(605, 51);
            this.btnPeekPila.Name = "btnPeekPila";
            this.btnPeekPila.Size = new System.Drawing.Size(168, 35);
            this.btnPeekPila.TabIndex = 2;
            this.btnPeekPila.Text = "Peek Pila";
            this.btnPeekPila.UseVisualStyleBackColor = true;
            this.btnPeekPila.Click += new System.EventHandler(this.btnPeekPila_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(605, 5);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(168, 40);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Cargar Archivo JSON";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(5, 5);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(594, 326);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.Text = "";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(681, 14);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(111, 27);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnRepPila
            // 
            this.btnRepPila.Location = new System.Drawing.Point(23, 14);
            this.btnRepPila.Name = "btnRepPila";
            this.btnRepPila.Size = new System.Drawing.Size(102, 23);
            this.btnRepPila.TabIndex = 5;
            this.btnRepPila.Text = "Reporte Pila";
            this.btnRepPila.UseVisualStyleBackColor = true;
            this.btnRepPila.Click += new System.EventHandler(this.btnRepPila_Click);
            // 
            // btnRepCola
            // 
            this.btnRepCola.Location = new System.Drawing.Point(132, 13);
            this.btnRepCola.Name = "btnRepCola";
            this.btnRepCola.Size = new System.Drawing.Size(110, 23);
            this.btnRepCola.TabIndex = 6;
            this.btnRepCola.Text = "Reporte Cola";
            this.btnRepCola.UseVisualStyleBackColor = true;
            this.btnRepCola.Click += new System.EventHandler(this.btnRepCola_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(249, 14);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(146, 23);
            this.btnMatriz.TabIndex = 7;
            this.btnMatriz.Text = "Reporte de Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 430);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnRepCola);
            this.Controls.Add(this.btnRepPila);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Practica 1 - Fredy Ramirez";
            this.tabControl.ResumeLayout(false);
            this.tabSignIn.ResumeLayout(false);
            this.tabSignIn.PerformLayout();
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabEliminar.ResumeLayout(false);
            this.tabEliminar.PerformLayout();
            this.tabCarga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabSignIn;
        private System.Windows.Forms.TextBox txtUserCreate;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPassCreate;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.TextBox txtEliminarUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabPage tabCarga;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnRepPila;
        private System.Windows.Forms.Button btnRepCola;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Button btnPeekCola;
        private System.Windows.Forms.Button btnPeekPila;
    }
}

