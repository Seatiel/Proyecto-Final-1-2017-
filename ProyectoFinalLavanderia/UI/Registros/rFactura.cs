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
    public partial class rFactura : Form
    {
        Facturas Factura = new Facturas();
        FacturasServicios Detalle = new FacturasServicios();

        public rFactura()
        {
            InitializeComponent();
            LlenarComboCliente();
        }

        private Facturas LlenarClase()
        {
            Facturas factura = new Facturas();
            factura.Fecha = FechadateTimePicker.Value;
            factura.ClienteId = (int)ClientecomboBox.SelectedValue;
            factura.Total = Convert.ToDecimal(TotalmaskedTextBox.Text);
            return factura;
        }

        private void Limpiar()
        {
            Detalle = new FacturasServicios();            
            Factura = new Facturas();
            FacturaIdmaskedTextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;            
            TotalmaskedTextBox.Clear();
            ValidarerrorProvider.Clear();
            FacturasDetallesdataGridView.DataSource = null;
            ServicioIdmaskedTextBox.Clear();
            CostomaskedTextBox.Clear();
            DescripciontextBox.Clear();
            ImportemaskedTextBox.Clear();
            CantidadnumericUpDown.Value = 0;
        }

        private void LlenarComboCliente()
        {
            List<Clientes> lista = BLL.ClientesBLL.ListarTodo();
            ClientecomboBox.DataSource = lista;
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";
        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes cliente = BLL.ClientesBLL.Buscar(c=> c.ClienteId == (int)ClientecomboBox.SelectedValue);
            if (cliente != null)
            {
                DirecciontextBox.Text = cliente.Direccion;
                TelefonomaskedTextBox.Text = cliente.Telefono;
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        private void Agregarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
