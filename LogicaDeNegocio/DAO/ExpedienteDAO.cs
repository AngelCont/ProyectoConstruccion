using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDeDatos;
using System.Data.SqlClient;

namespace LogicaDeNegocio
{
    public class ExpedienteDAO : IExpedienteDAO
    {
        public void GuardarExpediente(Expediente nuevoExpediente)
        {
            ConexionBD conexionBD = new ConexionBD();
            using (SqlConnection sqlConnection = conexionBD.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Expediente VALUES(@id, @asignacion, @horas)", sqlConnection))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("id", null));
                    sqlCommand.Parameters.Add(new SqlParameter("asignacion", nuevoExpediente.FechaAsignacion));
                    sqlCommand.Parameters.Add(new SqlParameter("horas", nuevoExpediente.TotalHorasRegistradas));

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                conexionBD.CloseConnection();
            }
        }

        public void SumarHoras(int horasRegistradas)
        {
            throw new NotImplementedException();
        }
    }
}
