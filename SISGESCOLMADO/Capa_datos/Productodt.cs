using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SISGESCOLMADO.Capa_datos
{
    public class ProductoDT
    {
        // Para crear un nuevo producto
        public void Insertar(string nombre, decimal precio, int stock, string categoria)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"INSERT INTO Productos (Nombre, Precio, Stock, Categoria) 
                                      VALUES (@Nombre, @Precio, @Stock, @Categoria)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@Categoria", categoria);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
        }

        // Para poder alar todo los productos
        public DataTable ConsultarTodos()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT * FROM Productos";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar productos: " + ex.Message);
            }

            return tabla;
        }

        // para poder buscar los productos
        public DataTable BuscarPorNombre(string nombre)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT * FROM Productos WHERE Nombre LIKE @Nombre";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar producto: " + ex.Message);
            }

            return tabla;
        }

        // Para modificar los productos
        public void Actualizar(int idProducto, string nombre, decimal precio, int stock, string categoria)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"UPDATE Productos 
                                      SET Nombre = @Nombre, Precio = @Precio, 
                                          Stock = @Stock, Categoria = @Categoria
                                      WHERE IdProducto = @IdProducto";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@Categoria", categoria);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }

        // Para poder modificar un stock 
        public void ActualizarStock(int idProducto, int nuevoStock)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "UPDATE Productos SET Stock = @Stock WHERE IdProducto = @IdProducto";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Stock", nuevoStock);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar stock: " + ex.Message);
            }
        }

        // Para borrar un producto
        public void Eliminar(int idProducto)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }
    }
}
