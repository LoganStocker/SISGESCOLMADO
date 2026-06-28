using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SISGESCOLMADO.Capa_datos
{
    public class ClienteDT
    {
        // Insertar cliente y devolver el IdCliente generado
        public int Insertar(string nombre, string telefono, bool tieneCredito, decimal limiteCredito)
        {
            int idGenerado = 0;

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"INSERT INTO Clientes (Nombre, Telefono, TieneCredito, LimiteCredito) 
                                      VALUES (@Nombre, @Telefono, @TieneCredito, @LimiteCredito);
                                      SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@TieneCredito", tieneCredito);
                    cmd.Parameters.AddWithValue("@LimiteCredito", limiteCredito);

                    con.Open();
                    idGenerado = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }

            return idGenerado;
        }

        // Consultar clientes
        public DataTable ConsultarTodos()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT * FROM Clientes";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar clientes: " + ex.Message);
            }

            return tabla;
        }

        // Buscar cliente nombre
        public DataTable BuscarPorNombre(string nombre)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT * FROM Clientes WHERE Nombre LIKE @Nombre";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente: " + ex.Message);
            }

            return tabla;
        }

        // Actualizar cliente
        public void Actualizar(int idCliente, string nombre, string telefono, bool tieneCredito, decimal limiteCredito)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"UPDATE Clientes 
                                      SET Nombre = @Nombre, Telefono = @Telefono, 
                                          TieneCredito = @TieneCredito, LimiteCredito = @LimiteCredito
                                      WHERE IdCliente = @IdCliente";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@TieneCredito", tieneCredito);
                    cmd.Parameters.AddWithValue("@LimiteCredito", limiteCredito);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

        // Eliminar cliente
        public void Eliminar(int idCliente)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }
    }
}