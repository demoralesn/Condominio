using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Resumen
    {
        public int Id { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Ing_Rec { get; set; }
        public int Ing_Mul { get; set; }
        public int Egr_Nor { get; set; }
        public int Egr_Otr { get; set; }
        public int Ajust { get; set; }
        public int Balan { get; set; }
    }
}