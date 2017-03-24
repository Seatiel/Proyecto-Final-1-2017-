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
            CrearUsuarioAdmin();
            intentos = 0;
        }

        private void CrearUsuarioAdmin()
        {
            if (BLL.UsuariosBLL.ListarTodo().Count() <= 0)
            {
                BLL.UsuariosBLL.Guardar(new Entidades.Usuarios(1, "Admin", "Seatiel Ygnacio", "1234", 1));
            }
            if (BLL.TiposusuariosBLL.ListarTodo().Count() <= 0)
            {
                BLL.TiposusuariosBLL.Guardar(new Entidades.TiposUsuarios(1,"Administrador"));
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
