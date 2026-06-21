using System;
using Microsoft.Data.SqlClient;   

namespace SISGESCOLMADO.Capa_datos
{
    public class Conexion
    {
        private static string cadenaConexion =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=SISGESCOLMADO_BD;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}