using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImaginaTuMundo.Shared.Entidades
{
    public class MadreComunitaria
    {

        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Apellidos { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Direccion { get; set; }

        [Display(Name = "Barrio")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Barrio { get; set; }
        public string Celular { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 digitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Documento { get; set; }
        public string CertificadoManipulacionAlimentos { get; set; }
        public string Foto { get; set; }

        [Display(Name = "Correo electronico")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "Digite un Email válido")]
        public string CorreoElectronico { get; set; }

        [JsonIgnore]
        public ICollection<AsignacionMadreNinio> AsignacionesMadresNinios { get; set; }


        [JsonIgnore]
        public Asociacion Asociaciones { get; set; }
        public int AsociacionId { get; set; }

        [JsonIgnore]
        public ICollection<Evidencia> Evidencias { get; set; }
        [JsonIgnore]
        public ICollection<SeguimientoNinios> SeguimientosNinios { get; set; }
    }
}
