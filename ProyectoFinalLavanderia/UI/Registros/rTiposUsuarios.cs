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
    public partial class rTiposUsuarios : Form
    {
        public rTiposUsuarios()
        {
            InitializeComponent();
        }

        private TiposUsuarios LlenarClase()
        {
            TiposUsuarios tipoUsuario = new TiposUsuarios();
            tipoUsuario.TipoUsuario = TipoUsuariotextBox.Text;
            return tipoUsuario; 
        }

        public void Limpiar()
        {
            TipoUsuarioIdtextBox.Clear();
            TipoUsuariotextBox.Clear();
            ValidarerrorProvider.Clear();
        }

        public bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(TipoUsuariotextBox.Text))
            {
                ValidarerrorProvider.SetError(TipoUsuariotextBox, "Debe de ingresar el Tipo de Usuario.");                
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            TiposUsuarios tipoUsuario = null;
            tipoUsuario = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (tipoUsuario != null)
            {
                BLL.TiposusuariosBLL.Guardar(tipoUsuario);
                MessageBox.Show("Tipo de Usuario guardado!");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilitarios.ToInt(TipoUsuarioIdtextBox.Text);
            TiposUsuarios tipoUsuario = BLL.TiposusuariosBLL.Buscar(tu => tu.TipoUsuarioId == id);
            if (!string.IsNullOrEmpty(TipoUsuarioIdtextBox.Text))
            {
                if (BLL.TiposusuariosBLL.Eliminar(tipoUsuario))
                {
                    MessageBox.Show("Tipo de Usuario Eliminado!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Tipo de Usuario no existe!");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilitarios.ToInt(TipoUsuarioIdtextBox.Text);
            TiposUsuarios tipoUsuario = BLL.TiposusuariosBLL.Buscar(tu => tu.TipoUsuarioId == id);
            if (!string.IsNullOrEmpty(TipoUsuarioIdtextBox.Text))
            {
                if (tipoUsuario != null)
                {
                    TipoUsuariotextBox.Text = tipoUsuario.TipoUsuario;                  
                }
                else
                {
                    MessageBox.Show("El Tipo de Usuario no ha sido creado");
                }
            }
        }


    }
}
