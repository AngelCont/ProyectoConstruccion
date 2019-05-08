using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    interface IReporteDAO
    {
        void GuardarReporte(Reporte nuevoReporte);
        List<Reporte> CargarReportes();
        List<Reporte> CargarReportesPorMatricula(string matricula);
        Reporte CargarReporte();
    }
}
