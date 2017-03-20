using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposUsuarios
    {
        [Key]
        public int TipoUsuarioId { get; set; }
        public string TipoUsuario { get; set; }

    }
}
