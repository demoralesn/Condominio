using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Propiedad
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public Tipo _Tipo { get; set; }
        public string Prorrateo { get; set; }
        public string Propietario { get; set; }
        public EstadoPro _Estado_Prop { get; set; }
        public Boolean Estado { get; set; }
    }

    public enum Tipo { Casa, Departamento, Estacionamiento, Bodega };

    public enum EstadoPro { Habitada, Abandonada, Arrendada, Propietario };
}