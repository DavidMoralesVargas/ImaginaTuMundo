using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImaginaTuMundo.Shared.Entidades
{
    public class ICBF
    {

        public int Id { get; set; }

        [Display(Name = "Nombre Entidad")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string NombreEntidad { get; set; }

        [Display(Name = "NIT")]
        [MaxLength(30, ErrorMessage = "No se permiten más de 30 digitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nit { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Direccion { get; set; }

        [Display(Name = "Barrio")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Barrio { get; set; }
        public string Telefono { get; set; }

        [Display(Name = "Correo electronico")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "Digite un Email válido")]
        public string CorreoElectronico { get; set; }

        [JsonIgnore]
        public ICollection<Inscripcion> Inscripciones { get; set; }

        [JsonIgnore]
        public ICollection<TareaParaMadre> TareasParaMadres { get; set; }
    }
}
