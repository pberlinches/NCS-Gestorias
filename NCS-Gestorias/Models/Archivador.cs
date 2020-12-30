using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCS_Gestorias.Models
{
    public class Archivador
    {
        [Key]
        public int IdArchivador { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        

    }
}
