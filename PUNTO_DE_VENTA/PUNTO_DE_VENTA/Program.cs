using PUNTO_DE_VENTA.presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            presentacion.login frm = new presentacion.login();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
            Application.Run();
        }

        private static void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }


    }
}
