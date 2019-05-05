using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    interface IExpedienteDAO
    {
        void GuardarExpediente(Expediente nuevoExpediente);
        Expediente CargarExpedientePorMatricula(string matricula);
        void SumarHoras(int horasRegistradas);
    }
}
