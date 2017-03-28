using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalLavanderia
{
    public partial class FormularioPrincipal : Form
    {
        //private Usuarios Usuario;
        private Form Login;

        public FormularioPrincipal(Form login)
        {
            InitializeComponent();
            this.Login = login;
        }

        private void registrosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rClientes rc = new UI.Registros.rClientes();
            rc.Show();
        }        

        private void rsgistrosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rUsuarios ru = new UI.Registros.rUsuarios();
            ru.Show();
        }        

        private void consultasClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.cClientes cc = new UI.Consultas.cClientes();
            cc.Show();
        }

        private void consultasServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.cServicios cs = new UI.Consultas.cServicios();
            cs.Show();
        }

        private void consultasUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.cUsuarios cu = new UI.Consultas.cUsuarios();
            cu.Show();
        }

        private void registrosFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rFactura rf = new UI.Registros.rFactura();
            rf.Show();  
        }

        private void consultasFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.cFacturas cf = new UI.Consultas.cFacturas();
            cf.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrosServiciosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UI.Registros.rServicios rs = new UI.Registros.rServicios();
            rs.Show();
        }

        private void registroDeTiposDeUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UI.Registros.rTiposUsuarios tu = new UI.Registros.rTiposUsuarios();
            tu.Show();
        }
    }
}
