using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombres { get; set; }
        public string Clave { get; set; }
        public int TipoUsuarioId { get; set; }
        // Registros
        public int RCliente { get; set; }
        public int RFactura { get; set; }
        public int RServicio { get; set; }
        public int RTipoUsuario { get; set; }
        public int RUsuario { get; set; }
        // Consultas 
        public int CCliente { get; set; }
        public int CServicio { get; set; }
        public int CUsuario { get; set; }

        public Usuarios(int usuarioId, string nombreUsuario, string nombres, string clave, int tipoUsuarioId)
        {
            this.UsuarioId = usuarioId;
            this.NombreUsuario = nombreUsuario;
            this.Nombres = nombres;
            this.Clave = clave;
            this.TipoUsuarioId = tipoUsuarioId;
            this.RCliente = 0;
            this.RFactura = 0;
            this.RServicio = 0;
            this.RTipoUsuario = 0;
            this.RUsuario = 0;
            this.CCliente = 0;
            this.CServicio = 0;
            this.CUsuario = 0;

        }

        public Usuarios()
        {
            this.RCliente = 0;
            this.RFactura = 0;
            this.RServicio = 0;
            this.RTipoUsuario = 0;
            this.RUsuario = 0;
            this.CCliente = 0;
            this.CServicio = 0;
            this.CUsuario = 0;
        }

        public Usuarios(string nombreUsuario, string nombres, string clave, int tipoUsuarioId)
        {
            this.NombreUsuario = nombreUsuario;
            this.Nombres = nombres;
            this.Clave = clave;
            this.TipoUsuarioId = tipoUsuarioId;
            this.RCliente = 0;
            this.RFactura = 0;
            this.RServicio = 0;
            this.RTipoUsuario = 0;
            this.RUsuario = 0;

        }


    }
}
