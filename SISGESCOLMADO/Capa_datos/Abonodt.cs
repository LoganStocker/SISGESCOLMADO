using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SISGESCOLMADO.Capa_datos
{
    public class AbonoDT
    {
        // Insertar abono
        public void Insertar(int idCredito, decimal montoAbonado)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"INSERT INTO Abonos (IdCredito, MontoAbonado) 
                                      VALUES (@IdCredito, @MontoAbonado)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdCredito", idCredito);
                    cmd.Parameters.AddWithValue("@MontoAbonado", montoAbonado);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar abono: " + ex.Message);
            }
        }

        // Consultar abonos por credito 
        public DataTable ConsultarPorCredito(int idCredito)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT IdAbono, MontoAbonado, FechaAbono 
                                      FROM Abonos 
                                      WHERE IdCredito = @IdCredito
                                      ORDER BY FechaAbono DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdCredito", idCredito);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar abonos: " + ex.Message);
            }

            return tabla;
        }
    }
}
