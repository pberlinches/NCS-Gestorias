using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCS_Gestorias.Models
{
    public class TipoDocumento
    {
        [Key]
        public int IdTipoDocumento { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }

     }
}