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
        Facturas factura = new Facturas();
        FacturasServicios detalle = new FacturasServicios();

        public rFactura()
        {
            InitializeComponent();
            LlenarComboCliente();
            Limpiar();
        }

        private Facturas LlenarClase()
        {
            factura.Fecha = FechadateTimePicker.Value;
            factura.ClienteId = (int)ClientecomboBox.SelectedValue;
            factura.Total = Convert.ToDecimal(TotalmaskedTextBox.Text);
            return factura;
        }

        private void Limpiar()
        {
            detalle = new FacturasServicios();            
            factura = new Facturas();
            FacturaIdmaskedTextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;            
            TotalmaskedTextBox.Clear();
            ValidarerrorProvider.Clear();
            FacturasDetallesdataGridView.DataSource = null;
            ServicioIdmaskedTextBox.Clear();
            CostomaskedTextBox.Clear();
            ClientecomboBox.SelectedIndex = 0;
            DescripciontextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();                      
            CantidadnumericUpDown.Value = 0;
            TotalmaskedTextBox.Enabled = false;
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(ClientecomboBox.Text)) || (string.IsNullOrEmpty(ServicioIdmaskedTextBox.Text)) || (FacturasDetallesdataGridView.DataSource == null))
            {
                ValidarerrorProvider.SetError(ClientecomboBox, "Debe de Seleccionar un Cliente.");
                ValidarerrorProvider.SetError(ServicioIdmaskedTextBox, "Debe de ingresar el Servicio ID.");
                ValidarerrorProvider.SetError(DescripciontextBox, "Debe de ingresar .");
                ValidarerrorProvider.SetError(FacturasDetallesdataGridView, "Debe agregar los Datos.");                
                retorno = false;
            }
            return retorno;
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

        private void LlenarGrid(Facturas factura)
        {
            FacturasDetallesdataGridView.DataSource = null;         
            FacturasDetallesdataGridView.DataSource = factura.Detalle.ToList();
            this.FacturasDetallesdataGridView.Columns["FacturaServicioId"].Visible = false;
            this.FacturasDetallesdataGridView.Columns["FacturaId"].Visible = false;
            this.FacturasDetallesdataGridView.Columns["Servicio"].Visible = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            //int id = 0;            
            factura = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else
            {
                if (factura.FacturaId  != 0)
                {
                    BLL.FacturasBLL.Mofidicar(factura);
                    MessageBox.Show("La Factura se ha Modifico.");
                }
                else
                {
                    BLL.FacturasBLL.Guardar(factura);
                    MessageBox.Show("La Factura se ha Guardo.");                    
                }
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Los campos estan vacios.");
            }
            else
            {
                int id = Utilitarios.ToInt(FacturaIdmaskedTextBox.Text);
                Facturas fac = BLL.FacturasBLL.Buscar(f => f.FacturaId == id);
                if (BLL.FacturasBLL.Eliminar(fac))
                {
                    Limpiar();
                    MessageBox.Show("La cotizacion se elimino con exito.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la cotizacion.");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Facturas fac = new Facturas();
            int id = Utilitarios.ToInt(FacturaIdmaskedTextBox.Text);
            fac = BLL.FacturasBLL.Buscar(f => f.FacturaId == id);
            if (fac != null)
            {
                ClientecomboBox.SelectedValue = fac.ClienteId;
                FechadateTimePicker.Value = fac.Fecha;
                TotalmaskedTextBox.Text = fac.Total.ToString();
                LlenarGrid(fac);
            }
            else
            {
                MessageBox.Show("No existe Factura con ese Id.");
                Limpiar();
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            factura.AgregarDetalle(detalle.Servicio, CantidadnumericUpDown.Value);
            LlenarGrid(factura);
            CantidadnumericUpDown.Enabled = false;
            CalcularTotal();            
        }

        private void CalcularTotal()
        {
            factura.Total += detalle.Servicio.Costo * CantidadnumericUpDown.Value;
            TotalmaskedTextBox.Text = factura.Total.ToString();            
        }

        private void BuscarServicio()
        {
            if (!string.IsNullOrEmpty(ServicioIdmaskedTextBox.Text))
            {
                int id = Utilitarios.ToInt(ServicioIdmaskedTextBox.Text);
                detalle.Servicio = BLL.ServiciosBLL.Buscar(s => s.ServicioId == id);
                if (detalle.Servicio != null)
                {
                    DescripciontextBox.Text = detalle.Servicio.Descripcion;
                    CostomaskedTextBox.Text = detalle.Servicio.Costo.ToString();
                    CantidadnumericUpDown.Enabled = true;
                    CantidadnumericUpDown.Focus();
                }
                else
                {
                    ServicioIdmaskedTextBox.Clear();
                    ValidarerrorProvider.SetError(ServicioIdmaskedTextBox, "No existe un Servicio con ese id.");
                    DescripciontextBox.Clear();
                    CostomaskedTextBox.Clear();
                    CantidadnumericUpDown.Enabled = false;
                    ServicioIdmaskedTextBox.Focus();
                }
            }
            else
            {
                DescripciontextBox.Clear();
                ValidarerrorProvider.SetError(ServicioIdmaskedTextBox, "Digite el id del Servicio nuevamente.");
                ServicioIdmaskedTextBox.Focus();
            }
        }

        private void ServicioIdmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarServicio();
            }
        }
    }
}
