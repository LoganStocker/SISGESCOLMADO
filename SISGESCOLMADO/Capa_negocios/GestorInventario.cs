using System;
using System.Data;
using SISGESCOLMADO.Capa_datos;

namespace SISGESCOLMADO.Capa_negocios
{
    public class GestorInventario
    {
        // Consultar productos
        public DataTable ConsultarProductos()
        {
            ProductoDT productoDT = new ProductoDT();
            return productoDT.ConsultarTodos();
        }

        // Insertar producto
        public string InsertarProducto(string nombre, decimal precio, int stock, string categoria)
        {
            try
            {
                ProductoDT productoDT = new ProductoDT();
                productoDT.Insertar(nombre, precio, stock, categoria);
                return "Producto agregado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Actualizar producto 
        public string ActualizarProducto(int idProducto, string nombre, decimal precio, int stock, string categoria)
        {
            try
            {
                ProductoDT productoDT = new ProductoDT();
                productoDT.Actualizar(idProducto, nombre, precio, stock, categoria);
                return "Producto actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Eliminar producto
        public string EliminarProducto(int idProducto)
        {
            try
            {
                ProductoDT productoDT = new ProductoDT();
                productoDT.Eliminar(idProducto);
                return "Producto eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public decimal ObtenerPrecioProducto(int idProducto)
        {
            ProductoDT productoDT = new ProductoDT();
            DataTable dt = productoDT.ConsultarTodos();

            foreach (DataRow fila in dt.Rows)
            {
                if (Convert.ToInt32(fila["IdProducto"]) == idProducto)
                {
                    return Convert.ToDecimal(fila["Precio"]);
                }
            }
            return 0;
        }
        public string ActualizarStock(int idProducto, int nuevoStock)
        {
            try
            {
                ProductoDT productoDT = new ProductoDT();
                productoDT.ActualizarStock(idProducto, nuevoStock);
                return "Stock actualizado.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
