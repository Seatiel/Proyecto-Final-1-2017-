using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalLavanderia.UI.Consultas
{
    public partial class cServicios : Form
    {
        public cServicios()
        {
            InitializeComponent();
            LLenarComboBox();
        }

        public void LLenarComboBox()
        {
            FiltrarcomboBox.Items.Insert(0, "Todos");
            FiltrarcomboBox.Items.Insert(1, "ID");
            FiltrarcomboBox.Items.Insert(2, "Descripcion");           
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Todos";

            //if (FiltrarcomboBox.Items.Count >= 1)
            //{
            //    FiltrarcomboBox.SelectedIndex = -1;
            //}
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(FiltrartextBox.Text))
            {
                ValidarerrorProvider.SetError(FiltrartextBox, "Llenar los campos vacios.");
                return false;
            }
            return true;
        }

        public void FiltrarOpcion()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                ServiciosdataGridView.DataSource = BLL.ServiciosBLL.ListarTodo();
            }
            else if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!Validar())
                {
                    MessageBox.Show("Llenar los campos.");
                }
                else
                {
                    int num;
                    int.TryParse(FiltrartextBox.Text, out num);
                    ServiciosdataGridView.DataSource = BLL.ServiciosBLL.Listar(s => s.ServicioId == num);
                }
            }
            else if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!Validar())
                {
                    MessageBox.Show("Llenar los campos.");
                }
                else
                {
                    ServiciosdataGridView.DataSource = BLL.ServiciosBLL.Listar(s => s.Descripcion.Equals(FiltrarcomboBox.Text));
                }
            }            
        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiciosdataGridView.DataSource = null;
            int num = Utilitarios.ToInt(FiltrartextBox.Text);
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                ServiciosdataGridView.DataSource = BLL.ServiciosBLL.ListarTodo();
                FiltrartextBox.Enabled = false;                
            }
            else if (FiltrarcomboBox.SelectedIndex == 1)
            {
                ServiciosdataGridView.DataSource = BLL.ServiciosBLL.Listar(s => s.ServicioId == num);
                FiltrartextBox.Enabled = true;                
            }
            else if (FiltrarcomboBox.SelectedIndex == 2)
            {
                ServiciosdataGridView.DataSource = BLL.ServiciosBLL.Listar(s => s.Descripcion.Equals(FiltrartextBox.Text));
                FiltrartextBox.Enabled = true;                
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            var reporte = new Reportes.rpServicios(ServiciosdataGridView.DataSource);
            reporte.Show();
        }
    }
}
