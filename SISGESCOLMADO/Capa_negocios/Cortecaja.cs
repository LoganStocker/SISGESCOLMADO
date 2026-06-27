using System;

namespace SISGESCOLMADO.Capa_negocios
{
    public class CorteCaja
    {
        private DateTime fechaCorte;
        private decimal totalVentasContado;
        private decimal totalVentasFiado;
        private int cantidadTransacciones;

        // Constructor completo
        public CorteCaja(decimal totalVentasContado, decimal totalVentasFiado, int cantidadTransacciones)
        {
            this.fechaCorte = DateTime.Now;
            this.totalVentasContado = totalVentasContado;
            this.totalVentasFiado = totalVentasFiado;
            this.cantidadTransacciones = cantidadTransacciones;
        }

        // Constructor vacio
        public CorteCaja()
        {
            this.fechaCorte = DateTime.Now;
            this.totalVentasContado = 0;
            this.totalVentasFiado = 0;
            this.cantidadTransacciones = 0;
        }

        public decimal TotalVentasContado => totalVentasContado;
        public decimal TotalVentasFiado => totalVentasFiado;
        public decimal TotalGeneral => totalVentasContado + totalVentasFiado;
        public int CantidadTransacciones => cantidadTransacciones;

        //Genera el resumen
        public string GenerarResumen()
        {
            return $"=== CORTE DE CAJA ===\n" +
                   $"Fecha: {fechaCorte:dd/MM/yyyy HH:mm}\n" +
                   $"Total Ventas Contado: ${totalVentasContado}\n" +
                   $"Total Ventas Fiado: ${totalVentasFiado}\n" +
                   $"Total General: ${TotalGeneral}\n" +
                   $"Cantidad de Transacciones: {cantidadTransacciones}";
        }

        // DESTRUCTOR genera el resumen antes de destruirlo
        ~CorteCaja()
        {
            // Recurso que libera antes de que el objeto CorteCaja lo destruya, 
            // genera el resumen para confirmar que el cierre quedó registrado.
            string resumen = GenerarResumen();
            System.Diagnostics.Debug.WriteLine(resumen);
        }
    }
}
