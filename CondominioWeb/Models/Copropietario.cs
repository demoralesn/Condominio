using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CondominioWeb.Models
{
    public class Copropietario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "El minimo es de 9 caracteres")]
        public string Rut { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Dv { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "El minimo es de 5 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "El minimo es de 5 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefono invalido")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "El Telefono debe tener 9 digitos")]
        public string Telefono { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public Genero _Genero { get; set; }

        [Display(Name = "Fecha Nac")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Fec_Nac { get; set; }

        [Display(Name = "Nacionalidad")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public Nacionalidad _Nacionalidad { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "E-mail invalido")]
        public string Email { get; set; }

        public Boolean Estado { get; set; }
    }
    public enum Genero { Masculino, Femenino };
    public enum Nacionalidad { Chileno, Extranjero };
}