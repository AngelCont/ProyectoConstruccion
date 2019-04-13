using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiaSistema
{
    interface ITecnicoAcademicoDAO
    {
        void GuardarTecnicoAcademico(TecnicoAcademico nuevoTecnicoAcademico);
        List<TecnicoAcademico> CargarTecnicosAcademicos();
        TecnicoAcademico CargarTecnicoAcademico(string busquedaNombre);
    }
}
