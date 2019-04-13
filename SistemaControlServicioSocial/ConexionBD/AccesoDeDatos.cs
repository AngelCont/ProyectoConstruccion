using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConexionBD
{
    public class AccesoDeDatos
    {
        private SqlConnection conexionBD;
        private String conexionString;

        public AccesoDeDatos()
        {
            conexionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            conexionBD = new SqlConnection(conexionString);
        }

        public SqlConnection GetConexion()
        {
            return conexionBD;
        }

        public void CerrarConexion()
        {
            if (conexionBD != null)
            {
                if (conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }
    }
}
