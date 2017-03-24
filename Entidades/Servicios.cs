using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Servicios
    {
        [Key]
        public int ServicioId { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }

        public virtual ICollection<FacturasServicios> ServiciosDetalle { get; set; }        

        public Servicios()
        {
            this.ServiciosDetalle = new HashSet<FacturasServicios>();
        }        

        public Servicios(int servicioId, string descripcion, decimal costo)
        {
            this.ServicioId = servicioId;
            this.Descripcion = descripcion;
            this.Costo = costo;
        }

        public override string ToString()
        {
            return string.Format("ServicioId: {0}, Descripción: {1}", this.ServicioId, this.Descripcion);
        }

    }
}
