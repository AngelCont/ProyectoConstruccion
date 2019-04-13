using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using System.Data.SqlClient;

namespace LogiaSistema
{
    public class ProyectoDAO : IProyectoDAO
    {
        public Proyecto CargarProyecto(int busqueda)
        {
            throw new NotImplementedException();
        }

        public List<Proyecto> CargarProyectos()
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            List<Proyecto> proyectos = new List<Proyecto>();

            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM", sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Proyecto proyecto = new Proyecto();

                        proyecto.IdProyecto = reader.GetInt32(0);
                        proyecto.Cupo = reader.GetInt32(1);
                        proyecto.HoraInicio = reader.GetInt32(2);
                        proyecto.HoraFin = reader.GetInt32(3);
                        proyecto.FechaInicio = reader.GetDateTime(4);
                        proyecto.FechaFin = reader.GetDateTime(5);
                        proyecto.NombreProyecto = reader.GetString(6);
                        proyecto.ObjetivoGeneral = reader.GetString(7);
                        proyecto.PoblacionAtendida = reader.GetString(8);
                        proyecto.Responsabilidad = reader.GetString(9);
                        proyecto.IdEncargadoDeOrganizacion = reader.GetInt32(10);

                        proyectos.Add(proyecto);
                    }
                }
                acceso.CerrarConexion();
            }
            return proyectos;
        }

        public void GuardarNuevoProyecto(Proyecto nuevoProyecto)
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO  VALUES (@dato)"))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("dato", nuevoProyecto));
                    
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
