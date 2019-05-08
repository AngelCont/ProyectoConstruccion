using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    interface ICoordinadorDAO
    {
        void GuardarCoordinador(Coordinador nuevoCoordinador);
        List<Coordinador> CargarCoordinadores();
        Coordinador CargarCoordinadorPorNumeroPersonal(int numeroDePersonal);
        void DarDeBajaCoordinador(int idCoordinador);
        void ModificarNombre(string nuevoNombre, int idCoordinador);
        void ModificarApellidoPaterno(string nuevoApellidoPaterno, int idCoordinador);
        void ModificarApellidoMaterno(string nuevoApellidoMaterno, int idCoordinador);
        void ModificarCorreo(string nuevoEmail, int idCoordinador);
        void ModificarNumeroDePersonal(string nuevoNumeroDePersonal, int idCoordinador);
        void ModificarTelefono(string nuevoTelefono, int idCoordinador);
    }
}
