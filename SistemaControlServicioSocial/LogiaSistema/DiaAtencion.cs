using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiaSistema
{
    public class DiaAtencion
    {
        public int IdDiaAtencion { get; set; }
        public string Nombre { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public string Lugar { get; set; }
        public int IdTecnicoAcademico { get; set; }
    }
}
