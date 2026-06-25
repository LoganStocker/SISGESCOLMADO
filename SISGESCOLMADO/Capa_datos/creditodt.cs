using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SISGESCOLMADO.Capa_datos
{
    public class CreditoDT
    {
        // crear una venta cuando es fiado
        public void Insertar(int idVenta, int idCliente, decimal montoTotal, DateTime fechaVencimiento)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"INSERT INTO CreditosFiado (IdVenta, IdCliente, MontoTotal, MontoPendiente, FechaVencimiento, Estado) 
                                      VALUES (@IdVenta, @IdCliente, @MontoTotal, @MontoPendiente, @FechaVencimiento, 'Pendiente')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@MontoTotal", montoTotal);
                    cmd.Parameters.AddWithValue("@MontoPendiente", montoTotal); // al inicio, pendiente = total
                    cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar crédito: " + ex.Message);
            }
        }

        // buscar por nombre
        public DataTable ConsultarTodos()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT cf.IdCredito, c.Nombre AS Cliente, cf.MontoTotal, 
                                             cf.MontoPendiente, cf.FechaVencimiento, cf.Estado
                                      FROM CreditosFiado cf
                                      INNER JOIN Clientes c ON cf.IdCliente = c.IdCliente
                                      ORDER BY cf.FechaVencimiento ASC";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar créditos: " + ex.Message);
            }

            return tabla;
        }

        // buscar deudores que aun esten 
        public DataTable ConsultarPorCliente(int idCliente)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT IdCredito, MontoTotal, MontoPendiente, FechaVencimiento, Estado
                                      FROM CreditosFiado
                                      WHERE IdCliente = @IdCliente AND Estado != 'Pagado'
                                      ORDER BY FechaVencimiento ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar créditos del cliente: " + ex.Message);
            }

            return tabla;
        }

        // renovar el monto pendiente 
        public void ActualizarMontoPendiente(int idCredito, decimal nuevoMontoPendiente)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string estado = nuevoMontoPendiente <= 0 ? "Pagado" : "Pendiente";

                    string query = @"UPDATE CreditosFiado 
                                      SET MontoPendiente = @MontoPendiente, Estado = @Estado
                                      WHERE IdCredito = @IdCredito";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MontoPendiente", nuevoMontoPendiente);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@IdCredito", idCredito);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar crédito: " + ex.Message);
            }
        }

        // mostrar credito pasados de tiempo
        public void ActualizarEstadosVencidos()
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"UPDATE CreditosFiado 
                                      SET Estado = 'Vencido'
                                      WHERE FechaVencimiento < GETDATE() AND Estado = 'Pendiente'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar estados vencidos: " + ex.Message);
            }
        }

        // Obtener un crédito con su Id
        public DataTable ObtenerPorId(int idCredito)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT * FROM CreditosFiado WHERE IdCredito = @IdCredito";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdCredito", idCredito);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener crédito: " + ex.Message);
            }

            return tabla;
        }
    }
}
