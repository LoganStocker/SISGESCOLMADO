namespace SISGESCOLMADO.Capa_negocios
{
    public abstract class VentaContado : Transaccion
    {
        public VentaContado(int idProducto, int cantidad, decimal total)
            : base(idProducto, cantidad, total)
        {
        }

        public VentaContado() : base()
        {
        }

        // Implementacion metodo abstract
        public override string FinalizarTransaccion()
        {
            return $"Venta al contado finalizada. Total cobrado: ${total}";
        }

        // Sobreescritura metodo virtual
        public override string ProcesarPago()
        {
            return $"Pago al contado recibido completo: ${total}.";
        }
    }
}
