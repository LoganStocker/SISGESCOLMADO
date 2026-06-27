using System;

namespace SISGESCOLMADO.Capa_negocios
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
        private bool tieneCredito;
        private decimal limiteCredito;

        // Constructor parametrizado completo
        public Cliente(string nombre, bool tieneCredito)
        {
            this.nombre = nombre;
            this.tieneCredito = tieneCredito;
            this.limiteCredito = tieneCredito ? 1000.00m : 0; // límite por si tiene crédito
        }

        // Constructor con nombre solo
        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.tieneCredito = false; // sin crédito 
            this.limiteCredito = 0;
        }

        // Propiedades para acceder a los atributos 
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nombre => nombre;
        public bool TieneCredito => tieneCredito;
        public decimal LimiteCredito => limiteCredito;
    }
}
