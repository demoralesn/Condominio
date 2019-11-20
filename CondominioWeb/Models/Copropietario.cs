using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CondominioWeb.Models
{
    public class Copropietario
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        [Display(Name="Fecha Nac.")]
        public string Fec_Nac { get; set; }
        [Required]
        public string Nacionalidad { get; set; }
        [Required]
        public string Email { get; set; }
    }
}