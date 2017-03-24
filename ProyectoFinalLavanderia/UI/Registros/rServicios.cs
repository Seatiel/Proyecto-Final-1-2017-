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
    public partial class rServicios : Form
    {
        public rServicios()
        {
            InitializeComponent();
        }

        private Servicios LlenarClase()
        {
            Servicios servicio = new Servicios();
            servicio.Descripcion = DescripciontextBox.Text;
            servicio.Costo = Convert.ToDecimal(CostomaskedTextBox.Text);
            return servicio;
        }

        public void Limpiar()
        {
            ServicioIdtextBox.Clear();
            DescripciontextBox.Clear();
            CostomaskedTextBox.Clear();
            ValidarerrorProvider.Clear();
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(DescripciontextBox.Text)) || (string.IsNullOrEmpty(CostomaskedTextBox.Text)))
            {
                ValidarerrorProvider.SetError(DescripciontextBox, "Debe de ingresar la Descripcion.");
                ValidarerrorProvider.SetError(CostomaskedTextBox, "Debe de ingresar el Costo.");
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Servicios servicio = null;
            servicio = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (servicio != null)
            {
                BLL.ServiciosBLL.Guardar(servicio);
                MessageBox.Show("Servicio guardado!");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilitarios.ToInt(ServicioIdtextBox.Text);
            Servicios servicio = BLL.ServiciosBLL.Buscar(s => s.ServicioId == id);
            if (!string.IsNullOrEmpty(ServicioIdtextBox.Text))
            {
                if (BLL.ServiciosBLL.Eliminar(servicio))
                {
                    MessageBox.Show("Servicio Eliminado!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Servicio no existe!");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilitarios.ToInt(ServicioIdtextBox.Text);
            Servicios servicio = BLL.ServiciosBLL.Buscar(s => s.ServicioId == id);
            if (!string.IsNullOrEmpty(ServicioIdtextBox.Text))
            {
                if (servicio != null)
                {
                    DescripciontextBox.Text = servicio.Descripcion;
                    CostomaskedTextBox.Text = servicio.Costo.ToString();
                }
                else
                {
                    MessageBox.Show("El Servicio no ha sido creado");
                }
            }
        }


    }
}
