using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FInal
{
    public class HistorialPaciente
    {
        public string IdConsulta { get; set; }
        public string NITPaciente { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string HoraConsulta { get; set; }
        public string Temperatura { get; set; }
        public string Presion { get; set; }
        public string Sinotmas { get; set; }//lista de sintomas
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Receta { get; set; } //Lista de medicamentos
        public string ProximaVisita { get; set; }
        public string CostoConsulta { get; set; }
        public string ImagenesVarias { get; set; }

    }
}