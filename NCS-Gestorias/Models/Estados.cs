using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCS_Gestorias.Models
{
    public class Estados
    {
        [Key]
        public int IdEstado { get; set; }

        [StringLength(50)]
        public string Valor { get; set; }

    }
}
