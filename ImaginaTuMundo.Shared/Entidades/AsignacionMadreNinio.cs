using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImaginaTuMundo.Shared.Entidades
{
    public class AsignacionMadreNinio
    {

        public int Id { get; set; }

        [JsonIgnore]
        public MadreComunitaria MadresComunitarias { get; set; }
        public int MadreComunitariaId { get; set; }

        [JsonIgnore]
        public Ninios Ninios { get; set; }
        public int NiniosId { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaAsignacionMadre { get; set; }
    }
}
