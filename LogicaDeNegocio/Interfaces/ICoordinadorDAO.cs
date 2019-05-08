using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaDeNegocio.Objetos;

namespace LogicaDeNegocio.Interfaces
{
    interface ICoordinadorDeServicioSocialDAO
    {
        CoordinadorDeServicioSocial recuperarDatos(int numeroDePersonal);
        List<CoordinadorDeServicioSocial> recuperarListaDeCoordinadores();
        void cambiarEstado(CoordinadorDeServicioSocial coordinador);
        void actualizarDatosBasicos(CoordinadorDeServicioSocial coordinador);
        void registrarCoordinador(CoordinadorDeServicioSocial coordinador);
        
    }
}
