using System;
using System.Collections.Generic;
using System.Data;
using SISGESCOLMADO.Capa_datos;

namespace SISGESCOLMADO.Capa_negocios
{
    // DELEGATE personalizado define la firma de un método que evalúa una fila de credito
    public delegate bool FiltroCredito(DataRow fila);

    public class GestorAlertas
    {
        // Metodo normal que usa el delegate mas lambda para filtrar creditos vencidos
        public List<DataRow> ObtenerCreditosVencidos()
        {
            CreditoDT creditoDT = new CreditoDT();
            DataTable tablaCreditos = creditoDT.ConsultarTodos();

            // Se asigna una expresión LAMBDA al delegado FiltroCredito
            FiltroCredito esVencido = (fila) => fila["Estado"].ToString() == "Vencido";

            List<DataRow> creditosVencidos = new List<DataRow>();

            foreach (DataRow fila in tablaCreditos.Rows)
            {
                if (esVencido(fila))
                {
                    creditosVencidos.Add(fila);
                }
            }

            return creditosVencidos;
        }
    }
}