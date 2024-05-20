using ImaginaTuMundo.Shared.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginaTuMundo.Shared.Entidades
{
    public class User:IdentityUser
    {
        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 digitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Documento { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Apellido { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Foto")]
        public string Foto {  get; set; }

        //Enum
        public UserType UserType { get; set; }

    }
}
