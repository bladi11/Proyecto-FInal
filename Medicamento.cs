using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FInal
{
    public class Medicamento
    {
        public string CodigoMedicamento { get; set; }
        public string IngredienteGenerico { get; set; }
        public string LaboratorioMarcaComercial { get; set; }
        public string ListadoEnfermedades { get; set; } //lista de enfermedades
    }
}