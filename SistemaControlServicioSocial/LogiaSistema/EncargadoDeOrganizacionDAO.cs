using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using System.Data.SqlClient;

namespace LogiaSistema
{
    public class EncargadoDeOrganizacionDAO : IEncargadoDeOrganizacionDAO
    {
        public EncargadoDeOrganizacion CargarEncargadoDeOrganizacion()
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            EncargadoDeOrganizacion encargadoDeOrganizacion = new EncargadoDeOrganizacion();

            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT FROM", sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        encargadoDeOrganizacion.IdEncargadoDeOrganizacion = reader.GetInt32(0);
                        encargadoDeOrganizacion.Nombre = reader.GetString(1);
                        encargadoDeOrganizacion.ApellidoPaterno = reader.GetString(2);
                        encargadoDeOrganizacion.ApellidoMaterno = reader.GetString(3);
                        encargadoDeOrganizacion.Cargo = reader.GetString(4);
                        encargadoDeOrganizacion.Email = reader.GetString(5);
                        encargadoDeOrganizacion.IdOrganizacion = reader.GetInt32(6);
                    }
                }
                acceso.CerrarConexion();
            }
            return encargadoDeOrganizacion;
        }

        public void GuardarEncargadoDeOrganizacion(EncargadoDeOrganizacion nuevoEncargadoDeOrganizacion)
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO  VALUES (@nombre, @apellidoPaterno, @apellidoMaterno, @cargo, @email, @idOrganizacion)"))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("nombre", nuevoEncargadoDeOrganizacion.Nombre));
                    sqlCommand.Parameters.Add(new SqlParameter("apellidoPaterno", nuevoEncargadoDeOrganizacion.ApellidoPaterno));
                    sqlCommand.Parameters.Add(new SqlParameter("apellidoMaterno", nuevoEncargadoDeOrganizacion.ApellidoMaterno));
                    sqlCommand.Parameters.Add(new SqlParameter("cargo", nuevoEncargadoDeOrganizacion.Cargo));
                    sqlCommand.Parameters.Add(new SqlParameter("email", nuevoEncargadoDeOrganizacion.Email));
                    sqlCommand.Parameters.Add(new SqlParameter("idOrganizacion", nuevoEncargadoDeOrganizacion.IdOrganizacion));

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                acceso.CerrarConexion();
            }
        }
    }
}
