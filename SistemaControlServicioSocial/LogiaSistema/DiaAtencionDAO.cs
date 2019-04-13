using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using System.Data.SqlClient;

namespace LogiaSistema
{
    public class DiaAtencionDAO : IDiaAtencionDAO
    {
        public DiaAtencion CargarDiaAtencion()
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            DiaAtencion diaAtencion = new DiaAtencion();

            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ", sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        diaAtencion.IdDiaAtencion = reader.GetInt32(0);
                        diaAtencion.Nombre = reader.GetString(1);
                        diaAtencion.HoraInicio = reader.GetInt32(2);
                        diaAtencion.HoraFin = reader.GetInt32(3);
                        diaAtencion.Lugar = reader.GetString(4);
                        diaAtencion.IdTecnicoAcademico = reader.GetInt32(5);
                    }
                }
                acceso.CerrarConexion();
            }
            return diaAtencion;
        }

        public void GuardarNuevoDiaAtencion(DiaAtencion nuevoDiaAtención)
        {
            AccesoDeDatos acceso = new AccesoDeDatos();

            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO  VALUES (@dia, @horaInicio, @horaFin, @lugar, @tecnico)"))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("dia", nuevoDiaAtención.Nombre));
                    sqlCommand.Parameters.Add(new SqlParameter("horaInicio", nuevoDiaAtención.HoraInicio));
                    sqlCommand.Parameters.Add(new SqlParameter("horaFin", nuevoDiaAtención.HoraFin));
                    sqlCommand.Parameters.Add(new SqlParameter("lugar", nuevoDiaAtención.Lugar));
                    sqlCommand.Parameters.Add(new SqlParameter("tecnico", nuevoDiaAtención.IdTecnicoAcademico));

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
