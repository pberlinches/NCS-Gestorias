using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCS_Gestorias.Models
{
    public class Publicaciones
    {
        [Key]
        public int IdPublicacion { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Column(TypeName = "bool")]
        public bool Publicacion { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string DetalleNoticia { get; set; }

        [StringLength(500)]
        public string Imagen { get; set; }

        [StringLength(100)]
        public string Enlace { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaBaja { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaInicioVigencia { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaFinVigencia { get; set; }

        [Column(TypeName = "bool")]
        public bool Activo { get; set; }
    }
}
