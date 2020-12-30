using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCS_Gestorias.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaBaja { get; set; }


        

    }
}
