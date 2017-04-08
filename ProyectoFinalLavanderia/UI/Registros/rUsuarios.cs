using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalLavanderia.UI.Registros
{
    public partial class rUsuarios : Form
    {
        Usuarios usuario;
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void rUsuarios_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            LlenarComboTiposUsuarios();
        }

        private Usuarios LlenarClase()
        {
            string tipoUsuario = TipoUsuariocomboBox.SelectedValue.ToString();

            Usuarios usuario = new Usuarios();
            usuario.NombreUsuario = NombreUsuariotextBox.Text;
            usuario.Nombres = NombrestextBox.Text;
            usuario.Clave = ClavetextBox.Text;
            usuario.TipoUsuarioId = Utilitarios.ToInt(tipoUsuario);
            
            return usuario;
        }

        private void PermisosRegistro(Usuarios usuario)
        {
            if (RClientescheckBox.Checked)
                usuario.RCliente = 1;
            if (RFacturascheckBox.Checked)
                usuario.RFactura = 1;
            if (RServicioscheckBox.Checked)
                usuario.RServicio = 1;
            if (RTiposUsuarioscheckBox.Checked)
                usuario.RTipoUsuario = 1;
            if (RUsuarioscheckBox.Checked)
                usuario.RUsuario = 1;            
        }

        private void PermisosConsulta(Usuarios usuario)
        {
            if (CClientescheckBox.Checked)
                usuario.CCliente = 1;
            if (CServicioscheckBox.Checked)
                usuario.CServicio = 1;
            if (CUsuarioscheckBox.Checked)
                usuario.CUsuario = 1;
           
        }

        private void AsignarPermisos(Usuarios usuario)
        {
            //Para Registros
            PermisosRegistro(usuario);
            //Para Consultas
            PermisosConsulta(usuario);
        }

        private void MostrarPermisos(Usuarios usuario)
        {
            //Para subir los permisos de registro del usuario
            MostrarPermisosRegistros(usuario);
            //Para subir los permisos de consulta del usuario
            MostrarPermisosConsultas(usuario);
        }

        private void MostrarPermisosRegistros(Usuarios usuario)
        {
            RClientescheckBox.Checked = Convert.ToBoolean(usuario.RCliente);
            RFacturascheckBox.Checked = Convert.ToBoolean(usuario.RFactura);
            RServicioscheckBox.Checked = Convert.ToBoolean(usuario.RServicio);
            RTiposUsuarioscheckBox.Checked = Convert.ToBoolean(usuario.RTipoUsuario);
            RUsuarioscheckBox.Checked = Convert.ToBoolean(usuario.RUsuario);            
        }
        private void MostrarPermisosConsultas(Usuarios usuario)
        {
            CClientescheckBox.Checked = Convert.ToBoolean(usuario.CCliente);
            CServicioscheckBox.Checked = Convert.ToBoolean(usuario.CServicio);
            CUsuarioscheckBox.Checked = Convert.ToBoolean(usuario.CUsuario);         
        }

        private void LimpiarCampos()
        {           
            LimpiarPermisos();
            UsuarioIdtextBox.Clear();
            NombreUsuariotextBox.Clear();
            NombrestextBox.Clear();
            ClavetextBox.Clear();
            ConfirmarClavetextBox.Clear();           
            
        }

        private void LimpiarPermisos()
        {
            LimpiarPermisosRegistros();
            LimpiarPermisosConsultas();
        }

        private void LimpiarPermisosRegistros()
        {
            RClientescheckBox.Checked = false;
            RFacturascheckBox.Checked = false;
            RServicioscheckBox.Checked = false;
            RTiposUsuarioscheckBox.Checked = false;
            RTiposUsuarioscheckBox.Checked = false;
            
        }

        private void LimpiarPermisosConsultas()
        {
            CClientescheckBox.Checked = false;
            CServicioscheckBox.Checked = false;
            CUsuarioscheckBox.Checked = false;
            
        }

        private void LlenarComboTiposUsuarios()
        {
            List<TiposUsuarios> lista = BLL.TiposusuariosBLL.ListarTodo();
            TipoUsuariocomboBox.DataSource = lista;
            TipoUsuariocomboBox.DisplayMember = "TipoUsuario";
            TipoUsuariocomboBox.ValueMember = "TipoUsuarioId";
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(NombreUsuariotextBox.Text)) || (string.IsNullOrEmpty(NombrestextBox.Text)) || (string.IsNullOrEmpty(ClavetextBox.Text)) || (string.IsNullOrEmpty(ConfirmarClavetextBox.Text)))
            {
                ValidarerrorProvider.SetError(NombreUsuariotextBox, "Debe de ingresar el Nombre del usuario.");
                ValidarerrorProvider.SetError(NombrestextBox, "Debe de ingresar el Nombre.");
                ValidarerrorProvider.SetError(ClavetextBox, "Debe de ingresar la Contraseña.");
                ValidarerrorProvider.SetError(ConfirmarClavetextBox, "Debe de ingresar la Contraseña de confirmacion.");         
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {          
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (ClavetextBox.Text.Equals(ConfirmarClavetextBox.Text))
            {
                usuario = LlenarClase(); //new Usuarios(NombreUsuariotextBox.Text, NombrestextBox.Text, ClavetextBox.Text, (int)TipoUsuariocomboBox.SelectedValue);
                AsignarPermisos(usuario);
                usuario.UsuarioId = Utilitarios.ToInt(UsuarioIdtextBox.Text);
                if (BLL.UsuariosBLL.Guardar(usuario))
                    MessageBox.Show("Usuario Guardado");
                else
                    MessageBox.Show("Usuario no guardado");
                LimpiarCampos();
            }
            else
            {
                ValidarerrorProvider.SetError(ConfirmarClavetextBox, "Las contraseñas no coinciden");
                ValidarerrorProvider.SetError(ClavetextBox, "Las contraseñas no coinciden");
                ConfirmarClavetextBox.Clear();
                ClavetextBox.Clear();                
            }            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilitarios.ToInt(UsuarioIdtextBox.Text);
            Usuarios usuario = BLL.UsuariosBLL.Buscar(u=> u.UsuarioId == id);
            if (usuario != null)
            {
                if (BLL.UsuariosBLL.Eliminar(usuario))
                    MessageBox.Show("El Usuario ha sido eliminado");
                else
                    MessageBox.Show("No se ha podido eliminar el usuario solicitado");
            }
            else
                MessageBox.Show("El usuario no existe");
            LimpiarCampos();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilitarios.ToInt(UsuarioIdtextBox.Text);
            Usuarios usuario = BLL.UsuariosBLL.Buscar(u => u.UsuarioId == id);
            if (usuario != null)
            {
                NombreUsuariotextBox.Text = usuario.NombreUsuario;
                NombrestextBox.Text = usuario.Nombres;
                ClavetextBox.Text = ConfirmarClavetextBox.Text = usuario.Clave;
                TipoUsuariocomboBox.SelectedValue = usuario.TipoUsuarioId;
                MostrarPermisos(usuario);
            }
            else
            {
                MessageBox.Show("No se encontró ningun Usuario");
                LimpiarCampos();
            }
        }

        private void TipoUsuariobutton_Click(object sender, EventArgs e)
        {
            UI.Registros.rTiposUsuarios tu = new rTiposUsuarios();
            tu.Show();
        }
    }
}
