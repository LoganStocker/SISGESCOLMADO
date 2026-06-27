using System;

namespace SISGESCOLMADO.Capa_negocios
{
    public abstract class Transaccion
    {
        protected int idProducto;
        protected int cantidad;
        protected decimal total;
        protected DateTime fecha;

        // Constructor completo
        public Transaccion(int idProducto, int cantidad, decimal total)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.total = total;
            this.fecha = DateTime.Now;
        }

        // Constructor vacio
        public Transaccion()
        {
            this.idProducto = 0;
            this.cantidad = 0;
            this.total = 0;
            this.fecha = DateTime.Now;
        }

        public int IdProducto => idProducto;
        public int Cantidad => cantidad;
        public decimal Total => total;
        public DateTime Fecha => fecha;

        // MÉTODO ABSTRACTO
        public abstract string FinalizarTransaccion();

        // MÉTODO VIRTUAL
        public virtual string ProcesarPago()
        {
            return "Procesando pago genérico de $" + total;
        }
    }
}