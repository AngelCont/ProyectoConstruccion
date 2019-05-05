using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Expediente
    {
        public int IdExpediente { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int TotalHorasRegistradas { get; set; }
    }
}
