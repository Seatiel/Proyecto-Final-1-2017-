using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public decimal Total { get; set; }

        public virtual Clientes Cliente { get; set; }

        public virtual ICollection<FacturasServicios> Detalle { get; set; } //Muchos

        public Facturas()
        {
            this.Detalle = new HashSet<FacturasServicios>();
        }

        public void AgregarDetalle(Servicios servicio, decimal cantidad)
        {
            this.Detalle.Add(new FacturasServicios(servicio.ServicioId, servicio.Descripcion, cantidad, servicio.Costo));
        }

    }
}
