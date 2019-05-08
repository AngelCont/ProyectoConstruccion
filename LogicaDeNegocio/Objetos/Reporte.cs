using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Reporte
    {
        public int IdReporte { get; set; }
        public string Actividad { get; set; }
        public byte[] Archivo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int HorasReportadas { get; set; }
        public int IdExpediente { get; set; }
    }
}
