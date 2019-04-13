using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiaSistema
{
    interface IOrganizacionVinculadaDAO
    {
        void GuardarOrganizacionVinculada(OrganizacionVinculada nuevaOrganizacionVinculada);
        List<OrganizacionVinculada> CargarListaOrganizacionVinculada();
        OrganizacionVinculada CargarOrganizacionVinculada(int busquedaId);
        void ModificarNombreOrganixacion(string nuevoNombre, int busquedaId);
        void ModificarCiudadOrganizacion(string nuevaCiudad, int busquedaId);
        void ModificarDireccionOrganizacion(string nuevaDireccion, int busquedaId);
        void ModificarEmailOrganziacion(string nuevoEmail, int busquedaId);
        void ModificarTelefonoOrganizacion(string nuevoTelefono, int busquedaId);
        void DarDeBajaOrganizacion(int busquedaId);
    }
}
