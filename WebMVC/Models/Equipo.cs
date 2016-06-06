using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Equipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EquipoId { get; set; }
        [Required]
        public string NombreEquipo { get; set; }
        [Required]
        public string Especificacion { get; set; }
        public string Estado { get; set; }
        [ForeignKey("Sala")]
        public int SalaId { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual List<Reporte> Reportes { get; set; }
    }
}