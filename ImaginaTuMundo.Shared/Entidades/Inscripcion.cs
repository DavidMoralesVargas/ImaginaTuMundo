using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImaginaTuMundo.Shared.Entidades
{
    public class Inscripcion
    {

        public int Id { get; set; }
        public string RegistroCivil { get; set; }
        public string CarneVacunas { get; set; }
        public string CremientoYDesarrollo { get; set; }
        public string CuentaServicios { get; set; }

        public string CedulaMama { get; set; }
        public string CedulaPapa { get; set; }

        public string Sisben { get; set; }
        public string Fosyga { get; set; }

        [JsonIgnore]
        public ICBF ICBFs { get; set; }
        public int ICBFId { get; set; }

        [JsonIgnore]
        public Ninios Ninios { get; set; }
        public int NiniosId { get; set; }

    }
}
