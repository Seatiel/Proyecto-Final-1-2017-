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
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private void cClientes_Load(object sender, EventArgs e)
        {
            LLenarComboBox();
        }

        public void LLenarComboBox()
        {
            FiltrarcomboBox.Items.Insert(0, "Todos");
            FiltrarcomboBox.Items.Insert(1, "ID");
            FiltrarcomboBox.Items.Insert(2, "Nombres");
            FiltrarcomboBox.Items.Insert(3, "Direccion");
            FiltrarcomboBox.Items.Insert(4, "Telefono");
            FiltrarcomboBox.Items.Insert(5, "Fecha Creacion");
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
            if (!Validar())
            {
                if (FiltrarcomboBox.SelectedIndex == 0)
                {
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.ListarTodo();
                }
                else if (FiltrarcomboBox.SelectedIndex == 5)
                {
                    int num;
                    int.TryParse(FiltrartextBox.Text, out num);
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Lista(c => c.ClienteId == num);
                }                
                else if (FiltrarcomboBox.SelectedIndex == 1)
                {
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Lista(c => c.Nombres.Equals(FiltrarcomboBox.Text));
                }
                else if (FiltrarcomboBox.SelectedIndex == 2)
                {
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Lista(c => c.Direccion.Equals(FiltrarcomboBox.Text));
                }
                else if (FiltrarcomboBox.SelectedIndex == 3)
                {
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Lista(c => c.Telefono.Equals(FiltrarcomboBox.Text));
                }
                else if (FiltrarcomboBox.SelectedIndex == 4)
                {
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Lista(c => c.FechaCreacion.Equals(FechaCreaciondateTimePicker.Value.Date));
                }
            }
            else
            {
                MessageBox.Show("Llenar los campos.");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }

        
    }
}
