using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImaginaTuMundo.Shared.Entidades
{
    public class Evidencia
    {

        public int Id { get; set; }
        public string Cronograma { get; set; }
        public string Asistencia { get; set; }
        public string Observaciones { get; set; }
        public string Novedades { get; set; }
        public string EvaluacionDiaria { get; set; }
        public string ActividadesMensuales { get; set; }
        public string EscalaEvaluacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaDeEnvio { get; set; }

        [JsonIgnore]
        public RepresentanteLegal RepresentantesLegales { get; set; }
        public int RepresentanteLegalId { get; set; }

        [JsonIgnore]
        public MadreComunitaria MadresComunitarias { get; set; }
        public int MadreComunitariaId { get; set; }
    }
}
