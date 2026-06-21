using System;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_presentacion;

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