using Proyecto_Salon_de_Eventos;
using System;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Principal formPrincipal = new Principal();
            Application.Run(formPrincipal);
        }
    }
}