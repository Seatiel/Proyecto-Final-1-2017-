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
        public rUsuarios()
        {
            InitializeComponent();
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

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
