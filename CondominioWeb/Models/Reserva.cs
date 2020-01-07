using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CondominioWeb.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Propiedad {get;set;}
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string dtDateFrom { get; set; }
    }
}