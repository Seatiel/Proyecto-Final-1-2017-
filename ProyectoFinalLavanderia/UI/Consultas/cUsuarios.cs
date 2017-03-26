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
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
            LLenarComboBox();
        }

        public void LLenarComboBox()
        {
            FiltrarcomboBox.Items.Insert(0, "Todos");
            FiltrarcomboBox.Items.Insert(1, "ID");
            FiltrarcomboBox.Items.Insert(2, "Nombres");            
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
                UsuariosdataGridView.DataSource = BLL.UsuariosBLL.ListarTodo();
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
                    UsuariosdataGridView.DataSource = BLL.UsuariosBLL.Listar(u => u.UsuarioId == num);
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
                    UsuariosdataGridView.DataSource = BLL.UsuariosBLL.Listar(u => u.Nombres.Equals(FiltrartextBox.Text));
                }
            }            
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
