using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalLavanderia.UI.Login
{
    public partial class Login : Form
    {
        private int intentos;
        private static Usuarios user = null;

        public Login()
        {
            InitializeComponent();
            Crear();
            intentos = 0;
        }

        private void Crear()
        {
            if (BLL.UsuariosBLL.ListarTodo().Count() <= 0)
            {
                BLL.UsuariosBLL.Guardar(new Entidades.Usuarios(1, "Admin", "Seatiel Ygnacio", "1234", 1));
            }
            if (BLL.TiposusuariosBLL.ListarTodo().Count() <= 0)
            {
                BLL.TiposusuariosBLL.Guardar(new Entidades.TiposUsuarios(1,"Administrador"));
            }
            if (BLL.ServiciosBLL.ListarTodo().Count() <= 0)
            {
                BLL.ServiciosBLL.Guardar(new Entidades.Servicios(1, "Pantalon Lavado y Planchado", 75));
                BLL.ServiciosBLL.Guardar(new Entidades.Servicios(2, "Camisa Lavado y Planchado", 75));
                BLL.ServiciosBLL.Guardar(new Entidades.Servicios(3, "Sueter Lavado y Planchado", 75));
            }
            if (BLL.ClientesBLL.ListarTodo().Count() <= 0)
            {
                BLL.ClientesBLL.Guardar(new Entidades.Clientes(1, "Seatiel Ygnacio", "C/ D #19 Urb. Alvarez", "8092697360", DateTime.Now, "Seatiel_2010@hotmail.com"));
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(NombreUsuariotextBox.Text))
            {
                if (!string.IsNullOrEmpty(ClavetextBox.Text))
                {
                    Usuarios usuario = null;
                    usuario = BLL.UsuariosBLL.Buscar(u => u.NombreUsuario == NombreUsuariotextBox.Text);
                    user = usuario;
                    if (user != null)
                    {
                        if (usuario.Clave == ClavetextBox.Text)
                        {
                            FormularioPrincipal principal = new FormularioPrincipal(this);
                            this.Hide();
                            principal.Show();
                        }                        
                    }
                    else
                    {
                        if (intentos < 5)
                        {
                            MessageBox.Show("Ha ocurrido un erro al verificar sus datos de Usuario");
                            NombreUsuariotextBox.Clear();
                            ClavetextBox.Clear();                            
                            ++intentos;
                        }
                        else
                        {
                            MessageBox.Show("Ha sobrepasado el límite de intentos fallidos,\n...Adios.");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puedes dejar campos vacios");                    
                }
            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacios");                
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
