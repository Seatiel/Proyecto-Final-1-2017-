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
    public partial class cFacturas : Form
    {
        public cFacturas()
        {
            InitializeComponent();
            LLenarComboBox();
        }

        public void LLenarComboBox()
        {
            FiltrarcomboBox.Items.Insert(0, "Todos");
            FiltrarcomboBox.Items.Insert(1, "ID");            
            FiltrarcomboBox.Items.Insert(2, "Fecha");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Todos";            
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
                FacturasdataGridView.DataSource = BLL.FacturasBLL.ListarTodo();
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
                    FacturasdataGridView.DataSource = BLL.FacturasBLL.Listar(f => f.FacturaId == num);
                }
            }
            else if (FiltrarcomboBox.SelectedIndex == 2)
            {
                FacturasdataGridView.DataSource = BLL.FacturasBLL.Listar(f => f.Fecha >= DesdedateTimePicker.Value.Date && f.Fecha <= HastadateTimePicker.Value.Date);
            }            
        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacturasdataGridView.DataSource = null;
            int num = Utilitarios.ToInt(FiltrartextBox.Text);
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                FacturasdataGridView.DataSource = BLL.FacturasBLL.ListarTodo();
                FiltrartextBox.Enabled = false;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
            else if (FiltrarcomboBox.SelectedIndex == 1)
            {
                FacturasdataGridView.DataSource = BLL.FacturasBLL.Listar(c => c.ClienteId == num);
                FiltrartextBox.Enabled = true;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
            else if (FiltrarcomboBox.SelectedIndex == 2)
            {
                DesdedateTimePicker.Enabled = true;
                HastadateTimePicker.Enabled = true;
                FiltrartextBox.Enabled = false;
                if (DesdedateTimePicker != null)
                {
                    FacturasdataGridView.DataSource = BLL.FacturasBLL.Listar(f => f.Fecha >= DesdedateTimePicker.Value.Date && f.Fecha <= HastadateTimePicker.Value.Date);
                }
            }            
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            var reporte = new Reportes.rpFacturas(FacturasdataGridView.DataSource);
            reporte.Show();
        }
    }
}
