using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Reporte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReporteId { get; set; }
        [Required]
        public DateTime Fecha_Reporte { get; set; }
        public DateTime Fecha_Realizado { get; set; }
        [Required]
        public string Descripcion { get; set; }  
        public string Estado { get; set; }
        [ForeignKey("Usuario")]
        public int UserId { get; set; }
        [ForeignKey("Equipo")]
        public int EquipoId { get; set; }
        public int User_RealizadoId { get; set; }
        public int User_AsignadoId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Equipo Equipo { get; set; }

    }
}