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
        public List<Entidades.Clientes> Lista { get; set; }

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
            FiltrarcomboBox.Items.Insert(5, "Fecha");
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
                ClientesdataGridView.DataSource = BLL.ClientesBLL.ListarTodo();
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
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.ClienteId == num);
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
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.Nombres == FiltrarcomboBox.Text);
                }                
            }
            else if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!Validar())
                {
                    MessageBox.Show("Llenar los campos.");
                }
                else
                {
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.Direccion == FiltrarcomboBox.Text);
                }                    
            }
            else if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!Validar())
                {
                    MessageBox.Show("Llenar los campos.");
                }
                else
                {
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.Telefono == FiltrarcomboBox.Text);
                }                    
            }
            else if (FiltrarcomboBox.SelectedIndex == 5)
            {
                ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.FechaCreacion >= DesdedateTimePicker.Value.Date && c.FechaCreacion <= HastadateTimePicker.Value.Date);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientesdataGridView.DataSource = null;
            int num = Utilitarios.ToInt(FiltrartextBox.Text);
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                ClientesdataGridView.DataSource = BLL.ClientesBLL.ListarTodo();
                FiltrartextBox.Enabled = false;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
            else if (FiltrarcomboBox.SelectedIndex == 1)
            {
                ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.ClienteId == num);
                FiltrartextBox.Enabled = true;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
            else if (FiltrarcomboBox.SelectedIndex == 2)
            {
                ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.Nombres == FiltrartextBox.Text);
                FiltrartextBox.Enabled = true;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
            else if (FiltrarcomboBox.SelectedIndex == 3)
            {
                ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.Direccion == FiltrartextBox.Text);
                FiltrartextBox.Enabled = true;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
            else if (FiltrarcomboBox.SelectedIndex == 4)
            {
                ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.Telefono == FiltrartextBox.Text);
                FiltrartextBox.Enabled = true;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
            else if (FiltrarcomboBox.SelectedIndex == 5)
            {
                DesdedateTimePicker.Enabled = true;
                HastadateTimePicker.Enabled = true;
                FiltrartextBox.Enabled = false;
                if (DesdedateTimePicker != null)
                {
                    ClientesdataGridView.DataSource = BLL.ClientesBLL.Listar(c => c.FechaCreacion >= DesdedateTimePicker.Value.Date && c.FechaCreacion <= HastadateTimePicker.Value.Date);
                }
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            var reporte = new Reportes.rpClientes();
            reporte.Show();

            //new UI.Reportes.rpClientes(Lista).Show();
            //new UI.Reportes.rpClientes(Lista).Activate();
        }
    }
}
