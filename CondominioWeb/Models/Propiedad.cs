using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Propiedad
    {
        public string numero { get; set; }
        public string tipo { get; set; }
        public string prorrateo { get; set; }
        public string propietario { get; set; }
        public string estado { get; set; }
    }
}