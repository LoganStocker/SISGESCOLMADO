using System;

namespace SISGESCOLMADO.Capa_negocios
{
    public abstract class VentaFiado : Transaccion
    {
        private int idCliente;
        private DateTime fechaVencimiento;

        public VentaFiado(int idProducto, int cantidad, decimal total, int idCliente, DateTime fechaVencimiento)
            : base(idProducto, cantidad, total)
        {
            this.idCliente = idCliente;
            this.fechaVencimiento = fechaVencimiento;
        }

        public int IdCliente => idCliente;
        public DateTime FechaVencimiento => fechaVencimiento;

        // Implementacion metodo abstracto
        public override string FinalizarTransaccion()
        {
            return $"Venta a crédito registrada. Cliente {idCliente} debe ${total} antes del {fechaVencimiento:dd/MM/yyyy}";
        }

        // Sobreescritura metodo virtual 
        public override string ProcesarPago()
        {
            return $"Venta a crédito pendiente: ${total}. Cliente {idCliente} debe pagar antes del {fechaVencimiento:dd/MM/yyyy}.";
        }
    }
}
