using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class LavanderiaDb : DbContext 
    {
        public LavanderiaDb() : base("ConStr")
        {

        }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<TiposUsuarios> TipoUsuario { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Servicios> Servicio { get; set; }
        public DbSet<Facturas> Factura { get; set; }




    }
}
