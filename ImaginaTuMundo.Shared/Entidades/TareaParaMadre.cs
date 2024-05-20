using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImaginaTuMundo.Shared.Entidades
{
    public class TareaParaMadre
    {

        public int Id { get; set; }
        public string Cronograma { get; set; }
        public string Asistencia { get; set; }
        public string Observaciones { get; set; }
        public string Novedades { get; set; }
        public string EvaluacionDiaria { get; set; }
        public string ActividadesMensuales { get; set; }
        public string EscalaEvaluacion { get; set; }

        [JsonIgnore]
        public ICBF ICBFs { get; set; }
        public int ICBFId { get; set; }

        [JsonIgnore]
        public RepresentanteLegal RepresentantesLegales { get; set; }
        public int RepresentanteLegalId { get; set; }
    }
}
