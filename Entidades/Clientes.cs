﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Email { get; set; }
        //public int UsuarioId { get; set; }


        public Clientes()
        {

        }

        public Clientes(int clienteId, string nombres, string direccion, string telefono, DateTime fecha, string email)
        {
            this.ClienteId = clienteId;
            this.Nombres = nombres;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.FechaCreacion = fecha;
            this.Email = email;
        }

    }
}
