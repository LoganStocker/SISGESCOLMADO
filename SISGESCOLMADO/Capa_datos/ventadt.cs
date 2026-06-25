using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SISGESCOLMADO.Capa_datos
{
    public class VentaDT
    {
        // Crear una venta y devolver el IdVenta generado
        public int Insertar(int? idCliente, int idProducto, int cantidad, decimal total, string tipoVenta)
        {
            int idVentaGenerado = 0;

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"INSERT INTO Ventas (IdCliente, IdProducto, Cantidad, Total, TipoVenta) 
                                      VALUES (@IdCliente, @IdProducto, @Cantidad, @Total, @TipoVenta);
                                      SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmd = new SqlCommand(query, con);

                    if (idCliente.HasValue)
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente.Value);
                    else
                        cmd.Parameters.AddWithValue("@IdCliente", DBNull.Value);

                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Total", total);
                    cmd.Parameters.AddWithValue("@TipoVenta", tipoVenta);

                    con.Open();
                    idVentaGenerado = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar venta: " + ex.Message);
            }

            return idVentaGenerado;
        }

        // buscar las ventas con nombre de cliente y producto 
        public DataTable ConsultarTodas()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT v.IdVenta, 
                                             ISNULL(c.Nombre, 'Cliente Mostrador') AS Cliente, 
                                             p.Nombre AS Producto, 
                                             v.Cantidad, v.Total, v.TipoVenta, v.FechaVenta
                                      FROM Ventas v
                                      LEFT JOIN Clientes c ON v.IdCliente = c.IdCliente
                                      INNER JOIN Productos p ON v.IdProducto = p.IdProducto
                                      ORDER BY v.FechaVenta DESC";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar ventas: " + ex.Message);
            }

            return tabla;
        }

        // buscar ventas de un cliente 
        public DataTable ConsultarPorCliente(int idCliente)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT v.IdVenta, p.Nombre AS Producto, 
                                             v.Cantidad, v.Total, v.TipoVenta, v.FechaVenta
                                      FROM Ventas v
                                      INNER JOIN Productos p ON v.IdProducto = p.IdProducto
                                      WHERE v.IdCliente = @IdCliente
                                      ORDER BY v.FechaVenta DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar ventas del cliente: " + ex.Message);
            }

            return tabla;
        }

        // Borrar venta 
        public void Eliminar(int idVenta)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "DELETE FROM Ventas WHERE IdVenta = @IdVenta";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar venta: " + ex.Message);
            }
        }
    }
}
