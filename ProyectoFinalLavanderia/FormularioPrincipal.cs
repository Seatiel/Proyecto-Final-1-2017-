﻿using System;
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
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void registrosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rClientes rc = new UI.Registros.rClientes();
            rc.Show();
        }

        private void registroDeTiposDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rTiposUsuarios tu = new UI.Registros.rTiposUsuarios();
            tu.Show();
        }

        private void rsgistrosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rUsuarios ru = new UI.Registros.rUsuarios();
            ru.Show();
        }

        private void consutasClientesToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
