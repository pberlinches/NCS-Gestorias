using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCS_Gestorias.Models
{
    public class Gestorias
    {

        [Key]
        public int IdGestoria { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Municipio { get; set; }

        [StringLength(100)]
        public string Provincia { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaBaja { get; set; }

        [StringLength(50)]
        public string UsuarioSolpheo { get; set; }

        [StringLength(50)]
        public string PasswordSolpheo { get; set; }

    }
}
