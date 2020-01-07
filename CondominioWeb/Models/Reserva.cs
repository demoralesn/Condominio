using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Propiedad {get;set;}
        public string Fecha { get; set; }
    }
}