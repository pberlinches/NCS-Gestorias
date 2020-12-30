using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCS_Gestorias.Models
{
    public class Perfil
    {
        [Key]
        public int IdPerfil { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }

    }
}
