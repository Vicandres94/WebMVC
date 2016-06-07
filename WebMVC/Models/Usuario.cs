using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebMVC.Models;

namespace WebMantenimiento.Models
{
    public class Usuario
    {     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId {get; set;}
        public string UserName { get; set; }
        [ScaffoldColumn(false)]
        public string Password { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        
        [ForeignKey("TipoDocumento")]
        public int TipoDocId { get; set; }
        [Required]
        [Display(Name = "Número Documento")]
        public string Documento { get; set; }
        
        [ScaffoldColumn(false)]
        public char Sexo { get; set; }
        [Required]
        public string Carrera { get; set; }
        [Required]
        public string Semestre { get; set; }
        
        [ScaffoldColumn(false)]
        public string Estado { get; set; }
        [ForeignKey("Rol")]
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}