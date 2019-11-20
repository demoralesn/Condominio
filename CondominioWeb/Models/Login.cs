using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CondominioWeb.Models
{
    public class Login
    {
        [Required]
        [Display(Name="Usuario")]
        public string user { get; set; }
        [Required]
        [Display(Name="Contraseña")]
        public string pass { get; set; }
    }
}