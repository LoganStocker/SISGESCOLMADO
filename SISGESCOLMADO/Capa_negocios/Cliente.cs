using System;
using SISGESCOLMADO.Capa_datos;

namespace SISGESCOLMADO.Capa_negocios
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
        private string telefono;
        private bool tieneCredito;
        private decimal limiteCredito;

        // Constructor completo
        public Cliente(string nombre, bool tieneCredito)
        {
            this.nombre = nombre;
            this.tieneCredito = tieneCredito;
            this.limiteCredito = tieneCredito ? 1000.00m : 0; // limite si tiene credito
        }

        // Constructor con nombre
        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.tieneCredito = false; // sin crédito por defecto
            this.limiteCredito = 0;
        }

        // Propiedades 
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Nombre => nombre;
        public bool TieneCredito => tieneCredito;
        public decimal LimiteCredito => limiteCredito;

        // METODO NORMAL toma los datos de este objeto y los envia a la Capa Datos
        public string GuardarCliente()
        {
            try
            {
                ClienteDT dt = new ClienteDT();
                this.idCliente = dt.Insertar(this.nombre, this.telefono ?? "" , this.tieneCredito, this.limiteCredito);
                return "Cliente guardado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al guardar cliente: " + ex.Message;
            }
        }
    }
}