using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Propiedad
    {
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public string Prorrateo { get; set; }
        public string Propietario { get; set; }
        public string Estado { get; set; }
    }
}