using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using System.Data.SqlClient;

namespace LogiaSistema
{
    public class ProgramaEducativoDAO : IProgramaEducativoDAO
    {
        public List<ProgramaEducativo> CargarListaProgramaEducativo()
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            List<ProgramaEducativo> programasEducativos = new List<ProgramaEducativo>();

            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT FROM", sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        ProgramaEducativo programaEducativo = new ProgramaEducativo();

                        programaEducativo.IdProgramaEducativo = reader.GetInt32(0);
                        programaEducativo.ClavePrograma = reader.GetString(1);
                        programaEducativo.NombrePrograma = reader.GetString(2);
                        programaEducativo.IdTecnicoAcademico = reader.GetInt32(3);
                        programaEducativo.IdCoordinador = reader.GetInt32(3);

                        programasEducativos.Add(programaEducativo);
                    }
                }
                acceso.CerrarConexion();
            }
            return programasEducativos;
        }

        public ProgramaEducativo CargarProgramaEducativo(int busquedaId)
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            ProgramaEducativo programaEducativo = new ProgramaEducativo();

            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT FROM LIKE @busqueda", sqlConnection))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("busqueda", busquedaId));
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        programaEducativo.IdProgramaEducativo = reader.GetInt32(0);
                        programaEducativo.ClavePrograma = reader.GetString(1);
                        programaEducativo.NombrePrograma = reader.GetString(2);
                        programaEducativo.IdTecnicoAcademico = reader.GetInt32(3);
                        programaEducativo.IdCoordinador = reader.GetInt32(3);
                    }
                }
                acceso.CerrarConexion();
            }
            return programaEducativo;
        }

        public void DarDeBajaProgramaEducativo(int busquedaId)
        {
            throw new NotImplementedException();
        }

        public void GuardarNuevoProgramaEducativo(ProgramaEducativo nuevoProgramaEducativo)
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO  VALUES (@clave, @nombre)"))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("ciudad", nuevoProgramaEducativo.ClavePrograma));
                    sqlCommand.Parameters.Add(new SqlParameter("direccion", nuevoProgramaEducativo.NombrePrograma));                    

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
