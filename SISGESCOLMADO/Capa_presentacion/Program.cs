using SISGESCOLMADO.Capa_datos;
using System;
using System.Windows.Forms;

namespace SISGESCOLMADO.Capa_presentacion
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