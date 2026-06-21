using SISGESCOLMADO.Capa_datos;
using SISGESCOLMADO.Capa_presentacion;
using System;
using System.Windows.Forms;

namespace SISGESCOLMADO
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {   
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}