using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiaSistema
{
    interface IProyectoDAO
    {
        void GuardarNuevoProyecto(Proyecto nuevoProyecto);
        List<Proyecto> CargarProyectos();
        Proyecto CargarProyecto(int busqueda);
    }
}
