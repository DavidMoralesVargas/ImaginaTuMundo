using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginaTuMundo.Shared.Entidades
{
    public class Asociacion
    {

        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "NIT")]
        [MaxLength(30, ErrorMessage = "No se permiten más de 30 digitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nit { get; set; }

        [Display(Name = "Rut")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 digitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Rut { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Direccion { get; set; }

        [Display(Name = "Barrio")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Barrio { get; set; }

        public string Celular { get; set; }

        [Display(Name = "Correo electronico")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "Digite un Email válido")]
        public string CorreoElectronico { get; set; }

        public string RepresentacionJuridica { get; set; }
    }
}
