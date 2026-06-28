using SISGESCOLMADO.Capa_datos;
using System;
using System.Data;

namespace SISGESCOLMADO.Capa_negocios
{
    public class GestorVentas
    {
        // Metodo normal registrarVenta
        public string registrarVenta(int? idCliente, int idProducto, int cantidad, decimal total, string tipoVenta)
        {
            try
            {
                VentaDT ventaDT = new VentaDT();
                int idVenta = ventaDT.Insertar(idCliente, idProducto, cantidad, total, tipoVenta);
                return "Venta registrada correctamente. Id: " + idVenta;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Metodo normal abonarDeuda
        public string abonarDeuda(int idCredito, decimal montoAbonado, decimal montoPendienteActual)
        {
            try
            {
                AbonoDT abonoDT = new AbonoDT();
                abonoDT.Insertar(idCredito, montoAbonado);

                decimal nuevoMontoPendiente = montoPendienteActual - montoAbonado;

                CreditoDT creditoDT = new CreditoDT();
                creditoDT.ActualizarMontoPendiente(idCredito, nuevoMontoPendiente);

                return "Abono registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Metodo normal actualizarInventario
        public string actualizarInventario(int idProducto, int nuevoStock)
        {
            try
            {
                ProductoDT productoDT = new ProductoDT();
                productoDT.ActualizarStock(idProducto, nuevoStock);
                return "Inventario actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}