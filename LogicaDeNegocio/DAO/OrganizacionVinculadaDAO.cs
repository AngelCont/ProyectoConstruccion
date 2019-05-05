using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using System.Data.SqlClient;

namespace LogicaDeNegocio
{
    public class OrganizacionVinculadaDAO : IOrganizacionVinculadaDAO
    {
        public List<OrganizacionVinculada> CargarListaOrganizacionVinculada()
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            List<OrganizacionVinculada> organizacionesVinculadas = new List<OrganizacionVinculada>();

            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT FROM", sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        OrganizacionVinculada organizacionVinculada = new OrganizacionVinculada();

                        organizacionVinculada.IdOrganizacionVinculada = reader.GetInt32(0);
                        organizacionVinculada.Ciudad = reader.GetString(1);
                        organizacionVinculada.Direccion = reader.GetString(2);
                        organizacionVinculada.Email = reader.GetString(3);
                        organizacionVinculada.NombreOrganizacion = reader.GetString(4);
                        organizacionVinculada.Telefono = reader.GetString(5);

                        organizacionesVinculadas.Add(organizacionVinculada);
                    }
                }
                acceso.CerrarConexion();
            }
            return organizacionesVinculadas;
        }
        
        public OrganizacionVinculada CargarOrganizacionVinculada(int busquedaId)
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            OrganizacionVinculada organizacionVinculada = new OrganizacionVinculada();
            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT FROM WEHERE LIKE @busqueda", sqlConnection))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("busqueda", busquedaId));

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        organizacionVinculada.IdOrganizacionVinculada = reader.GetInt32(0);
                        organizacionVinculada.Ciudad = reader.GetString(1);
                        organizacionVinculada.Direccion = reader.GetString(2);
                        organizacionVinculada.Email = reader.GetString(3);
                        organizacionVinculada.NombreOrganizacion = reader.GetString(4);
                        organizacionVinculada.Telefono = reader.GetString(5);
                    }
                }
                acceso.CerrarConexion();
            }
            return organizacionVinculada;
        }

        public void DarDeBajaOrganizacion(int busquedaId)
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM WHERE LIKE @busqueda"))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("busqueda", busquedaId));

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

        public void GuardarOrganizacionVinculada(OrganizacionVinculada nuevaOrganizacionVinculada)
        {
            AccesoDeDatos acceso = new AccesoDeDatos();
            using (SqlConnection sqlConnection = acceso.GetConexion())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO  VALUES (@ciudad, @direccion, @email, @nombreOrganizacion, @telefono)"))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("ciudad", nuevaOrganizacionVinculada.Ciudad));
                    sqlCommand.Parameters.Add(new SqlParameter("direccion", nuevaOrganizacionVinculada.Direccion));
                    sqlCommand.Parameters.Add(new SqlParameter("email", nuevaOrganizacionVinculada.Email));
                    sqlCommand.Parameters.Add(new SqlParameter("nombreOrganizacion", nuevaOrganizacionVinculada.NombreOrganizacion));
                    sqlCommand.Parameters.Add(new SqlParameter("telefono", nuevaOrganizacionVinculada.Telefono));

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

        public void ModificarCiudadOrganizacion(string nuevaCiudad, int busquedaId)
        {
            throw new NotImplementedException();
        }

        public void ModificarDireccionOrganizacion(string nuevaDireccion, int busquedaId)
        {
            throw new NotImplementedException();
        }

        public void ModificarEmailOrganziacion(string nuevoEmail, int busquedaId)
        {
            throw new NotImplementedException();
        }

        public void ModificarNombreOrganixacion(string nuevoNombre, int busquedaId)
        {
            throw new NotImplementedException();
        }

        public void ModificarTelefonoOrganizacion(string nuevoTelefono, int busquedaId)
        {
            throw new NotImplementedException();
        }
    }
}
