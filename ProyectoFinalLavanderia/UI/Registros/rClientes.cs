using BLL;
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
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }        

        private Clientes LlenarClase()
        {
            Clientes cliente = new Clientes();
            cliente.Nombres = NombrestextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Telefono = TelefonomaskedTextBox.Text;
            cliente.FechaCreacion = FechaCreaciondateTimePicker.Value;
            cliente.Email = EmailtextBox.Text;

            return cliente;
        }


        public void Limpiar()
        {
            ClienteIdtextBox.Clear();
            NombrestextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            FechaCreaciondateTimePicker.Value = DateTime.Today;
            EmailtextBox.Clear();
            ValidarerrorProvider.Clear();
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(NombrestextBox.Text)) || (string.IsNullOrEmpty(DirecciontextBox.Text)) || (string.IsNullOrEmpty(TelefonomaskedTextBox.Text)) || (string.IsNullOrEmpty(EmailtextBox.Text)))
            {
                ValidarerrorProvider.SetError(NombrestextBox, "Debe de ingresar el Nombre.");
                ValidarerrorProvider.SetError(DirecciontextBox, "Debe de ingresar la Direccion.");
                ValidarerrorProvider.SetError(TelefonomaskedTextBox, "Debe de ingresar el Telefono.");
                ValidarerrorProvider.SetError(EmailtextBox, "Debe de ingresar el Email.");
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
            Clientes cliente = null;
            cliente = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (cliente != null)
            {
                BLL.ClientesBLL.Guardar(cliente);
                MessageBox.Show("Cliente guardado!");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilitarios.ToInt(ClienteIdtextBox.Text);
            Clientes cliente = BLL.ClientesBLL.Buscar(c => c.ClienteId == id);
            if (!string.IsNullOrEmpty(ClienteIdtextBox.Text))
            {
                if (BLL.ClientesBLL.Eliminar(cliente))
                {
                    MessageBox.Show("Cliente Eliminado!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Cliente no existe!");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {            
            int id = Utilitarios.ToInt(ClienteIdtextBox.Text);
            Clientes cliente = BLL.ClientesBLL.Buscar(c => c.ClienteId == id);
            if (!string.IsNullOrEmpty(ClienteIdtextBox.Text))
            {
                if (cliente != null)
                {
                    NombrestextBox.Text = cliente.Nombres;
                    DirecciontextBox.Text = cliente.Direccion;
                    TelefonomaskedTextBox.Text = cliente.Telefono.ToString();
                    FechaCreaciondateTimePicker.Value = cliente.FechaCreacion;
                    EmailtextBox.Text = cliente.Email;
                }
                else
                {
                    MessageBox.Show("El Cliente no ha sido creado");
                }
            }
        }


    }
}
