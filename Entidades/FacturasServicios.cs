using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FacturasServicios
    {
        [Key]
        public int FacturaServicioId { get; set; }
        public int FacturaId { get; set; }
        public int ServicioId { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public Servicios Servicio { get; set; }
        //public virtual Facturas Facturas { get; set; } //Uno

        public FacturasServicios()
        {
            //Servicio = new Servicios();
        }

        public FacturasServicios(int servicioId, string descripcion, decimal cantidad, decimal costo)
        {
            this.ServicioId = servicioId;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Costo = costo;
        }


    }
}
