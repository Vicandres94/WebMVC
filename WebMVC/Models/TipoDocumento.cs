using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebMantenimiento.Models;

namespace WebMVC.Models
{
    public class TipoDocumento
    {
        [Key]
        public int TipoDocId { get; set; } 
        [Display(Name = "Tipo Documento")]
        public string Documento { get; set; }
        public virtual List<Usuario> Usuarios  { get; set; }
    }
}